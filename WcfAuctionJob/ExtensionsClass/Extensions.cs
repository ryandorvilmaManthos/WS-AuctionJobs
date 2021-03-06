﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using WcfAuctionJob.DataTransfertObject;
using WcfAuctionJob.model;

namespace WcfAuctionJob.ExtensionsClass
{
    public static class Extensions
    {
        public static IEnumerable<T> ConvertAll<T, TIn>(this IEnumerable<TIn> inputs)
        {
            if (inputs == null) throw new ArgumentNullException("inputs");
            return inputs.Select(input => input.Convert<T, TIn>());
        }

        public static T Convert<T, TIn>(this TIn input)
        {
            if (input == null) throw new ArgumentNullException("input");


            Type inputType = typeof(TIn);
            Type outputType = typeof(T);
            object outputObject = Activator.CreateInstance(outputType, false);
            //Get all members of input type
            List<MemberInfo> inputMemberInfos = GetMembers(inputType);
            //Get all members of ouput type
            List<MemberInfo> outputMemberInfos = GetMembers(outputType);

            //Compare and select the same members between input and output type
            List<MemberInfo> members = outputMemberInfos.Where(memberInfo => inputMemberInfos.Select(c => c.Name)
                .Contains(memberInfo.Name)).ToList();
            //a revoir 
            if (members.Count == 0) throw new InvalidCastException("you can't convert this both classes");

            foreach (MemberInfo memberInfo in members)
            {
                PropertyInfo outputProperty = outputType.GetProperty(memberInfo.Name);
                PropertyInfo inputProperty = inputType.GetProperty(memberInfo.Name);
                Type typeOutput = outputProperty.PropertyType;
                Type typeInput = inputProperty.PropertyType;

                //Test if class implements IDictionnary
                object resultObject;
                

                if (typeof(IDictionary).IsAssignableFrom(typeOutput))
                {
                    // Get all value of Dictionnary property
                    IDictionary inputDictionary =
                        (IDictionary)inputType.GetProperty(memberInfo.Name).GetValue(input, null);

                    Type[] genericTypeInput = typeInput.GenericTypeArguments;
                    Type[] genericTypeOutput = typeOutput.GenericTypeArguments;

                    IEnumerable keysConvert = CallConvertAll(genericTypeInput[0], genericTypeOutput[0],
                        new object[] { inputDictionary.Keys });

                    IEnumerable valuesConvert = CallConvertAll(genericTypeInput[1], genericTypeOutput[1],
                        new object[] { inputDictionary.Values });

                    resultObject = typeof(Extensions).GetMethod("Merge")
                        .MakeGenericMethod(genericTypeOutput[0],
                            genericTypeOutput[1])
                        .Invoke(null, new object[] { keysConvert, valuesConvert });
                }
                else
                {
                    
                   
                    //Test if class implements ICollection
                    //var isAssignableFrom =  == typeOutput;
                    if (typeOutput.GenericTypeArguments.FirstOrDefault() != null)
                    {
                        if (typeof (ICollection<>).MakeGenericType(typeOutput.GenericTypeArguments.FirstOrDefault()) ==
                            typeOutput)
                        {
                            //Get all value of Collection property
                            object inputList = inputType.GetProperty(memberInfo.Name).GetValue(input, null);

                            //Call extension method "ConvertAll" to convert
                            object convertResult = CallConvertAll(typeInput.GenericTypeArguments.First(),
                                typeOutput.GenericTypeArguments.First(), new[] {inputList});
                            var listType =
                                (Type)typeof (Extensions).GetMethod("GetListType")
                                    .MakeGenericMethod(typeOutput.GenericTypeArguments.FirstOrDefault())
                                    .Invoke(null, null);
                            //new generic list
                            resultObject =  Activator.CreateInstance(listType, convertResult);
                        }
                        else
                        {
                            resultObject = inputProperty.GetValue(input, null);
                        }
                       
                    }
                    else
                    {
                        resultObject = inputProperty.GetValue(input, null);
                    }
                    
                    
                }
                //Set output value
                outputProperty.SetValue(outputObject, resultObject, null);
            }
            return (T)outputObject;
        }

        private static List<MemberInfo> GetMembers(Type type)
        {
            return (type.GetMembers().Where(source => source.MemberType == MemberTypes.Property)).ToList();
        }

        private static IEnumerable CallConvertAll(Type inputType, Type outputType, object[] param)
        {
            return (IEnumerable)typeof(Extensions).GetMethod("ConvertAll")
                .MakeGenericMethod(outputType,
                    inputType)
                .Invoke(null, param);
        }

        public static Type GetListType<T>()
        {
            PropertyInfo property = typeof(AuctionJobEntities).GetProperty(typeof(T).Name);
            if (property != null)
            {
                return typeof(HashSet<>).MakeGenericType(typeof(T));
            }
            return typeof(List<>).MakeGenericType(typeof(T));
        }


        public static IDictionary Merge<TKey, TValues>(this IEnumerable keys, IEnumerable values)
        {
            IEnumerator valuesEnumerator = values.GetEnumerator();
            IDictionary dictionary = new Dictionary<TKey, TValues>();
            foreach (var key in keys)
            {
                valuesEnumerator.MoveNext();
                dictionary.Add(key, valuesEnumerator.Current);
            }
            return dictionary;
        }
    }
}