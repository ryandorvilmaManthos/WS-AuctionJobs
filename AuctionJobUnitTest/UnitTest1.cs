using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfAuctionJob;
using WcfAuctionJob.ExtensionsClass;
using WcfAuctionJob.DataTransfertObject;
using WcfAuctionJob.model;

namespace AuctionJobUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private DtoTUser _newUser;
        [TestMethod]
        public void AddUserBdd()
        {
            _newUser = new DtoTUser
            {
                user_nom = "Peyregne",
                user_prenom = "Thomas",
                user_mail = "thomas.peyregne@live.fr",
                user_mdp = "MyRoot",
                user_ip  = "0.0.0.0"
            };
            IServiceAJ aj = new ServiceAj();
            aj.AddUser(_newUser);

        }

        
        //public void ConvertClasses()
        //{
        //    _newUser = new DtoTUser
        //    {
        //        user_nom = "Peyregne",
        //        user_prenom = "Thomas",
        //        user_mail = "thomas.peyregne@live.fr",
        //        user_mdp = "MyRoot",
        //        user_ip = "0.0.0.0"
        //    };
        //    IServiceAJ aj = new ServiceAj();
        //    aj.AddUser(_newUser);

        //}

        //[TestMethod]
        //public void UpdateUserBdd()
        //{
        //    //_newUser.user_nom = "UpdatePeyregne";
        //    //using (AuctionJobEntities bddEntities = new AuctionJobEntities())
        //    //{

        //    //}
        //}
    }
}
