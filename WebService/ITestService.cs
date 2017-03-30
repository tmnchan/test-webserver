using System.ServiceModel;
using System.ServiceModel.Web;
using WebService.DTO;

namespace WebService
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        SettingList GetItems(string searchField = null);
    }
}
