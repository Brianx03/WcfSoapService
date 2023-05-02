using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    [OperationContract]
    User SelectUser(int userId);

    [OperationContract]
    string InsertUser(User user);

    [OperationContract]
    string DeleteUser(int user);

    [OperationContract]
    string UpdateUser(User user);

}