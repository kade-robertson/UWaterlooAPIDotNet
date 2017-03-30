using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NodaTime;

namespace UWaterlooAPIDotNet
{
    public class UWaterlooAPI : IDisposable {
        private string m_apikey;
        private HttpClient m_client;

        public Modules.Weather Weather { get; }
        public Modules.Terms Terms { get; }
        public Modules.Resources Resources { get; }
        public Modules.Codes Codes { get; }
        public Modules.Buildings Buildings { get; }
        public Modules.PointsOfInterest PointsOfInterest { get; }
        public Modules.Parking Parking { get; }
        public Modules.Transit Transit { get; }
        public Modules.Directory Directory { get; }
        public Modules.API API { get; }
        public Modules.Server Server { get; }

        public UWaterlooAPI(string apikey)
        {
            m_apikey = apikey;
            m_client = new HttpClient();
            m_client.BaseAddress = new Uri("https://api.uwaterloo.ca");

            Weather = new Modules.Weather(m_apikey, m_client);
            Terms = new Modules.Terms(m_apikey, m_client);
            Resources = new Modules.Resources(m_apikey, m_client);
            Codes = new Modules.Codes(m_apikey, m_client);
            Buildings = new Modules.Buildings(m_apikey, m_client);
            PointsOfInterest = new Modules.PointsOfInterest(m_apikey, m_client);
            Parking = new Modules.Parking(m_apikey, m_client);
            Transit = new Modules.Transit(m_apikey, m_client);
            Directory = new Modules.Directory(m_apikey, m_client);
            API = new Modules.API(m_apikey, m_client);
            Server = new Modules.Server(m_apikey, m_client);
        }

        public void Dispose() {
            m_client.Dispose();
        }
    }
}
