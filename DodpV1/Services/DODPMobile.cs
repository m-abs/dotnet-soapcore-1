
using Streamer.Dodpv1.Models;
using System;

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

        public bool issueContent(string contentID)
        {
            throw new System.NotImplementedException();
        }

        public ContentMetadata getContentMetadata(string contentID)
        {
            throw new System.NotImplementedException();
        }

        public void getContentResources(string contentID)
        {
            throw new System.NotImplementedException();
        }

        public void getServiceAttributes()
        {
            throw new System.NotImplementedException();
        }

        public void getContentList(string id, int firstItem, int lastItem)
        {
            throw new System.NotImplementedException();
        }

        public void getServiceAnnouncements()
        {
            throw new System.NotImplementedException();
        }

        public void markAnnouncementsAsRead()
        {
            throw new System.NotImplementedException();
        }

        public bool returnContent(string contentID)
        {
            throw new System.NotImplementedException();
        }

        public bool setBookmarks()
        {
            throw new System.NotImplementedException();
        }

        public bool getQuestions()
        {
            throw new System.NotImplementedException();
        }

        public bool getKeyExchangeObject()
        {
            throw new System.NotImplementedException();
        }
    }
}
