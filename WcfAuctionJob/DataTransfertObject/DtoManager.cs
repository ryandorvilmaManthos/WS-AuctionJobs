using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfAuctionJob.ExtensionsClass;
using WcfAuctionJob.model;

namespace WcfAuctionJob.DataTransfertObject
{
    public static class DtoManager<TIn> where TIn :class 
    {
        public static void Insert<TOut>(TIn dtoClass) where TOut : class 
        {
            TOut bddClass = dtoClass.Convert<TOut, TIn>();
            using (AuctionJobEntities bddEntities = new AuctionJobEntities())
            {
                bddEntities.Set<TOut>().Add(bddClass);
                bddEntities.SaveChanges();
            }
        }

        public static void Update<TOut>(TIn dtoClass) where TOut : class
        {
            using (AuctionJobEntities bddEntities = new AuctionJobEntities())
            {
                TOut recordUpdate = bddEntities.Set<TOut>().Find(dtoClass);
                if (recordUpdate != null)
                {
                    bddEntities.Entry(recordUpdate).CurrentValues.SetValues(dtoClass);
                    bddEntities.SaveChanges();
                }
            }
        }
        
        public static void Delete<TOut>(int id) where TOut : class
        {
            using (AuctionJobEntities bddEntities = new AuctionJobEntities())
            {
                TOut recordDelete = bddEntities.Set<TOut>().Find(id);
                if (recordDelete != null)
                {
                    bddEntities.Set<TOut>().Remove(recordDelete);
                    bddEntities.SaveChanges();
                }
            }
        }
    }
}
