using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Resources;

namespace UWaterlooAPIDotNet.Modules
{
    public class Resources : GenericModule
    {
        public Resources(string apikey, HttpClient client) : base(apikey, client) { }

        private string GetYearParamString(int year) {
            var paramstr = m_baseparam;
            if (year >= 1996 && DateTime.Now.Year > year) {
                paramstr += $"&year={year}";
            }
            return paramstr;
        }

        private string GetTermParamString(string term) {
            var paramstr = m_baseparam;
            if (term != "") {
                paramstr += $"&term={term}";
            }
            return paramstr;
        }

        public RunResult<List<TutorData>> GetTutors() {
            return Get<List<TutorData>>("RS_TUTORS", m_baseparam);
        }

        public Task<RunResult<List<TutorData>>> GetTutorsAsync() {
            return GetAsync<List<TutorData>>("RS_TUTORS", m_baseparam);
        }

        public RunResult<List<InfosessionData>> GetInfosessions() {
            return Get<List<InfosessionData>>("RS_INFOSESSIONS", m_baseparam);
        }

        public Task<RunResult<List<InfosessionData>>> GetInfosessionsAsync() {
            return GetAsync<List<InfosessionData>>("RS_INFOSESSIONS", m_baseparam);
        }

        public RunResult<List<GooseData>> GetGooseWatchData(string term) {
            return Get<List<GooseData>>("RS_GOOSEWATCH", GetTermParamString(term));
        }

        public Task<RunResult<List<GooseData>>> GetGooseWatchDataAsync(string term) {
            return GetAsync<List<GooseData>>("RS_GOOSEWATCH", GetTermParamString(term));
        }

        public RunResult<List<GooseData>> GetGooseWatchData(int term = -1) {
            return GetGooseWatchData(term == -1 ? "" : term.ToString());
        }

        public Task<RunResult<List<GooseData>>> GetGooseWatchDataAsync(int term = -1) {
            return GetGooseWatchDataAsync(term == -1 ? "" : term.ToString());
        }

        public RunResult<List<SunshineData>> GetSunshineList(int year = -1) {
            return Get<List<SunshineData>>("RS_SUNSHINELIST", GetYearParamString(year));
        }

        public Task<RunResult<List<SunshineData>>> GetSunshineListAsync(int year = -1) {
            return GetAsync<List<SunshineData>>("RS_SUNSHINELIST", GetYearParamString(year));
        }
    }
}
