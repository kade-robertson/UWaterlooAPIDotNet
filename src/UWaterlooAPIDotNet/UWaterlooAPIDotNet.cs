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

        public Modules.API API { get; private set; }

        public UWaterlooAPI(string apikey)
        {
            m_apikey = apikey;
            m_client = new HttpClient();
            m_client.BaseAddress = new Uri("https://api.uwaterloo.ca");

            API = new Modules.API(m_apikey, m_client);
        }
    }
}
