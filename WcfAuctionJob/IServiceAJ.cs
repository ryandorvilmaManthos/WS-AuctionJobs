using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfAuctionJob.DataTransfertObject;

namespace WcfAuctionJob
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceAJ" in both code and config file together.
    [ServiceContract]
    public interface IServiceAJ
    {
        [OperationContract]
        string GetData(int number);

        [OperationContract]
        void AddUser(DtoTUser dtoUser);

        [OperationContract]
        List<DtoTUser> GetUsers();

        [OperationContract]
        void UpdateUser(DtoTUser dtoUser);

        //[OperationContract]
        //void InsertUser(DtoTUser dtoUser);

        // TODO: Add your service operations here
    }
}
