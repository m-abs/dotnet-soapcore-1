using System.ServiceModel;

namespace Streamer.Dodpv1.Models
{
    [ServiceContract]
    public interface IDODPMobile
    {
        [OperationContract]
        public bool logOn(string username, string password);

        [OperationContract]
        public bool logOff();

    }
}
