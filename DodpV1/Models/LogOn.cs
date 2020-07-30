using System.Runtime.Serialization;

namespace Streamer.Dodpv1.Models
{

    [DataContract]
    public class LogOnRequest
    {
        [DataMember]
        public string username { get; set; }

        [DataMember]
        public string password { get; set; }
    }
}
