
using Streamer.Dodpv1.Models;

namespace Streamer.Dodpv1.Services
{
    public class DODPMobile : IDODPMobile
    {
        public bool logOn(string username, string password)
        {
            System.Console.WriteLine(username);
            return username == "abc";
        }

        public bool logOff()
        {
            return true;
        }
    }
}
