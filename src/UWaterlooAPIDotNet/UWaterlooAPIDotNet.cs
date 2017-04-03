using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NodaTime;
using UWaterlooAPIDotNet.Modules;

namespace UWaterlooAPIDotNet
{
    public class UWaterlooAPI : IDisposable {
        private string m_apikey;
        private HttpClient m_client;

        public readonly FoodServices FoodServices;
        public readonly Feds Feds;
        public readonly Courses Courses;
        public readonly Awards Awards;
        public readonly Events Events;
        public readonly Weather Weather;
        public readonly Terms Terms;
        public readonly Resources Resources;
        public readonly Codes Codes;
        public readonly Buildings Buildings;
        public readonly PointsOfInterest PointsOfInterest;
        public readonly Parking Parking;
        public readonly Transit Transit;
        public readonly Directory Directory;
        public readonly API API;
        public readonly Server Server;

        public UWaterlooAPI(string apikey)
        {
            m_apikey = apikey;
            m_client = new HttpClient();
            m_client.BaseAddress = new Uri("https://api.uwaterloo.ca");

            FoodServices = new FoodServices(m_apikey, m_client);
            Feds = new Feds(m_apikey, m_client);
            Courses = new Courses(m_apikey, m_client);
            Awards = new Awards(m_apikey, m_client);
            Events = new Events(m_apikey, m_client);
            Weather = new Weather(m_apikey, m_client);
            Terms = new Terms(m_apikey, m_client);
            Resources = new Resources(m_apikey, m_client);
            Codes = new Codes(m_apikey, m_client);
            Buildings = new Buildings(m_apikey, m_client);
            PointsOfInterest = new PointsOfInterest(m_apikey, m_client);
            Parking = new Parking(m_apikey, m_client);
            Transit = new Transit(m_apikey, m_client);
            Directory = new Directory(m_apikey, m_client);
            API = new API(m_apikey, m_client);
            Server = new Server(m_apikey, m_client);
        }

        public void Dispose() {
            m_client.Dispose();
        }
    }
}
