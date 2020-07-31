using System.ServiceModel;
using System.Threading.Tasks;

namespace Streamer.Dodpv1.Models
{
    [ServiceContract(Name = "DODP", Namespace = "http://www.daisy.org/ns/daisy-online/")]
    public interface IDODPMobile
    {
        /// Required operations

        // Logs a Reading System on to a Service.
        [OperationContract]
        bool logOn(string username, string password);

        [OperationContract]
        bool logOff();

        [OperationContract]
        bool issueContent(string contentID);

        [OperationContract]
        ContentMetadata getContentMetadata(string contentID);

        [OperationContract]
        void getContentResources(string contentID);

        [OperationContract]
        void getServiceAttributes();

        [OperationContract]
        void getContentList(string id, int firstItem, int lastItem);

        /// Optional operations
        [OperationContract]
        void getServiceAnnouncements();

        [OperationContract]
        void markAnnouncementsAsRead();

        [OperationContract]
        bool returnContent(string contentID);

        [OperationContract]
        bool setBookmarks();

        [OperationContract]
        bool getQuestions();

        [OperationContract]
        bool getKeyExchangeObject();
    }
}
