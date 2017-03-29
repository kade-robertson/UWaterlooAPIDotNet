using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Terms;

namespace UWaterlooAPIDotNet.Modules
{
    public class Terms : GenericModule
    {
        public Terms(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<TermData> GetTermData() {
            return Get<TermData>("TERMS_LIST", m_baseparam);
        }

        public Task<RunResult<TermData>> GetTermDataAsync() {
            return GetAsync<TermData>("TERMS_LIST", m_baseparam);
        }

        public RunResult<List<CourseListing>> GetTermCourses(int term = 0) {
            if (term == 0) {
                var d = GetTermData();
                if (d.Success) {
                    term = d.Result.Data.CurrentTerm;
                } else {
                    return new RunResult<List<CourseListing>>(d.Error);
                }
            }
            return Get<List<CourseListing>>("TERM_COURSES_BYTERM", m_baseparam, term.ToString());
        }

        public async Task<RunResult<List<CourseListing>>> GetTermCoursesAsync(int term = 0) {
            if (term == 0) {
                var d = await GetTermDataAsync();
                if (d.Success) {
                    term = d.Result.Data.CurrentTerm;
                } else {
                    return new RunResult<List<CourseListing>>(d.Error);
                }
            }
            return await GetAsync<List<CourseListing>>("TERM_COURSES_BYTERM", m_baseparam, term.ToString());
        }

        public RunResult<List<CourseEnrollment>> GetCourseEnrollment(int term = 0) {
            if (term == 0) {
                var d = GetTermData();
                if (d.Success) {
                    term = d.Result.Data.CurrentTerm;
                } else {
                    return new RunResult<List<CourseEnrollment>>(d.Error);
                }
            }
            return Get<List<CourseEnrollment>>("TERM_ENROLLMENT_BYTERM", m_baseparam, term.ToString());
        }

        public async Task<RunResult<List<CourseEnrollment>>> GetCourseEnrollmentAsync(int term = 0) {
            if (term == 0) {
                var d = await GetTermDataAsync();
                if (d.Success) {
                    term = d.Result.Data.CurrentTerm;
                } else {
                    return new RunResult<List<CourseEnrollment>>(d.Error);
                }
            }
            return await GetAsync<List<CourseEnrollment>>("TERM_ENROLLMENT_BYTERM", m_baseparam, term.ToString());
        }
    }
}
