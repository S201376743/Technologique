using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Technologique_SVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool userRegister (string userName, string userSurname, string userEmail, string password);

        [OperationContract]
        int userLogin(string userEmail, string password);

        [OperationContract]
        bool addProduct(string prodName, string prodDescription, int prodStock, double prodPrice, string imgUrl);
    }
}
