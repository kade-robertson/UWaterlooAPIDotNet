using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Codes;

namespace UWaterlooAPIDotNet.Modules
{
    public class Codes : GenericModule
    {
        public Codes(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<UnitCode>> GetUnits() {
            return Get<List<UnitCode>>("CODES_UNITS", m_baseparam);
        }

        public Task<RunResult<List<UnitCode>>> GetUnitsAsync() {
            return GetAsync<List<UnitCode>>("CODES_UNITS", m_baseparam);
        }

        public RunResult<List<Code>> GetTerms() {
            return Get<List<Code>>("CODES_TERMS", m_baseparam);
        }

        public Task<RunResult<List<Code>>> GetTermsAsync() {
            return GetAsync<List<Code>>("CODES_TERMS", m_baseparam);
        }

        public RunResult<List<GroupCode>> GetGroups() {
            return Get<List<GroupCode>>("CODES_GROUPS", m_baseparam);
        }

        public Task<RunResult<List<GroupCode>>> GetGroupsAsync() {
            return GetAsync<List<GroupCode>>("CODES_GROUPS", m_baseparam);
        }

        public RunResult<List<SubjectCode>> GetSubjects() {
            return Get<List<SubjectCode>>("CODES_SUBJECTS", m_baseparam);
        }

        public Task<RunResult<List<SubjectCode>>> GetSubjectsAsync() {
            return GetAsync<List<SubjectCode>>("CODES_SUBJECTS", m_baseparam);
        }

        public RunResult<List<Code>> GetInstructions() {
            return Get<List<Code>>("CODES_INSTRUCTIONS", m_baseparam);
        }

        public Task<RunResult<List<Code>>> GetInstructionsAsync() {
            return GetAsync<List<Code>>("CODES_INSTRUCTIONS", m_baseparam);
        }
    }
}
