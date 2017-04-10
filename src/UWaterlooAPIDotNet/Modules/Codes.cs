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

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="UnitCode"/> for all organizational units.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="UnitCode"/>, if available.</returns>
        public RunResult<List<UnitCode>> GetUnits() {
            return Get<List<UnitCode>>("CODES_UNITS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="UnitCode"/> for all organizational units.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="UnitCode"/>, if available.</returns>
        public Task<RunResult<List<UnitCode>>> GetUnitsAsync() {
            return GetAsync<List<UnitCode>>("CODES_UNITS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="Code"/> for all terms.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Code"/>, if available.</returns>
        public RunResult<List<Code>> GetTerms() {
            return Get<List<Code>>("CODES_TERMS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="Code"/> for all terms.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Code"/>, if available.</returns>
        public Task<RunResult<List<Code>>> GetTermsAsync() {
            return GetAsync<List<Code>>("CODES_TERMS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="GroupCode"/> for all groups.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="GroupCode"/>, if available.</returns>
        public RunResult<List<GroupCode>> GetGroups() {
            return Get<List<GroupCode>>("CODES_GROUPS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="GroupCode"/> for all groups.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="GroupCode"/>, if available.</returns>
        public Task<RunResult<List<GroupCode>>> GetGroupsAsync() {
            return GetAsync<List<GroupCode>>("CODES_GROUPS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="SubjectCode"/> for all subjects.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="SubjectCode"/>, if available.</returns>
        public RunResult<List<SubjectCode>> GetSubjects() {
            return Get<List<SubjectCode>>("CODES_SUBJECTS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="SubjectCode"/> for all subjects.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="SubjectCode"/>, if available.</returns>
        public Task<RunResult<List<SubjectCode>>> GetSubjectsAsync() {
            return GetAsync<List<SubjectCode>>("CODES_SUBJECTS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="Code"/> for all instruction types.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Code"/>, if available.</returns>
        public RunResult<List<Code>> GetInstructions() {
            return Get<List<Code>>("CODES_INSTRUCTIONS", m_baseparam);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="Code"/> for all instruction types.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Code"/>, if available.</returns>
        public Task<RunResult<List<Code>>> GetInstructionsAsync() {
            return GetAsync<List<Code>>("CODES_INSTRUCTIONS", m_baseparam);
        }
    }
}
