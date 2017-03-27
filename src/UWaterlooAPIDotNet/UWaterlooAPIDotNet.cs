using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace UWaterlooAPIDotNet
{
    public class UWaterlooAPI
    {
        private string m_apikey;
        private HttpClient m_client;

        public UWaterlooAPI(string apikey)
        {
            m_apikey = apikey;
            m_client = new HttpClient();
            m_client.BaseAddress = new Uri("https://api.uwaterloo.ca/v2");
        }
    }
}
