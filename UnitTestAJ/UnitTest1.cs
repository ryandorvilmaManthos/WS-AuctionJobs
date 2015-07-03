using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfAuctionJob.DataTransfertObject;

namespace UnitTestAJ
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddUserToDatabase()
        {
            DtoTUser user = new DtoTUser
            {
                user_nom = "Peyregne",
                user_prenom = "Thomas",
                user_mail = "thomas.peyregne@live.fr",
                user_mdp = ""
            };
        }
    }
}
