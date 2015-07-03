using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfAuctionJob.DataTransfertObject;
using WcfAuctionJob.ExtensionsClass;
using WcfAuctionJob.model;

namespace WcfAuctionJob
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAj" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAj.svc or ServiceAj.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAj : IServiceAJ
    {
        public string GetData(int number)
        {
            return "Data : " + number;
        }

        public void AddUser(DtoTUser dtoUser)
        {
            DateTime currenTime = DateTime.Now;
            dtoUser.user_create = currenTime;
            dtoUser.user_last_connexion = currenTime;
            dtoUser.user_modif = currenTime;
            DtoManager<DtoTUser>.Insert<t_user>(dtoUser);
        }

        public List<DtoTUser> GetUsers()
        {
            using (AuctionJobEntities bddEntities = new AuctionJobEntities())
            {
                return bddEntities.t_user.Select(c => c).ConvertAll<DtoTUser,t_user>().ToList();
            }
        } 

        public void UpdateUser(DtoTUser dtoUser)
        {
            DateTime currentTime = DateTime.Now;
            dtoUser.user_modif = currentTime;
            DtoManager<DtoTUser>.Update<t_user>(dtoUser);
        }
        //public void InsertUser(DtoTUser dtoUser)
        //{
        //    DtoManager<DtoTUser>.Insert(dtoUser);
        //}
    }
}
