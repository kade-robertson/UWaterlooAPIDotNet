using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Resources;
using UWaterlooAPIDotNet.Models.Terms;

namespace UWaterlooAPIDotNet.Modules
{
    public class Terms : GenericModule
    {
        public Terms(string apikey, HttpClient client) : base(apikey, client) { }

        public int GetLatestTermNumber(int term) {
            if (term == 0) {
                var d = GetTermData();
                if (d.Success) {
                    return (int)d.Result.Data.CurrentTerm;
                } else {
                    return -1;
                }
            } else {
                return term;
            }
        }

        public async Task<int> GetLatestTermNumberAsync(int term) {
            if (term == 0) {
                var d = await GetTermDataAsync();
                if (d.Success) {
                    return (int)d.Result.Data.CurrentTerm;
                } else {
                    return -1;
                }
            } else {
                return term;
            }
        }

        public RunResult<TermData> GetTermData() {
            return Get<TermData>("TERMS_LIST", m_baseparam);
        }

        public Task<RunResult<TermData>> GetTermDataAsync() {
            return GetAsync<TermData>("TERMS_LIST", m_baseparam);
        }

        public RunResult<List<CourseListing>> GetTermCourses(int term = 0) {
            term = GetLatestTermNumber(term);
            if (term < 0) return new RunResult<List<CourseListing>>(new HttpRequestException("Unable to retrieve current school term."));
            return Get<List<CourseListing>>("TERM_COURSES_BYTERM", m_baseparam, term.ToString());
        }

        public async Task<RunResult<List<CourseListing>>> GetTermCoursesAsync(int term = 0) {
            term = await GetLatestTermNumberAsync(term);
            if (term < 0) return new RunResult<List<CourseListing>>(new HttpRequestException("Unable to retrieve current school term."));
            return await GetAsync<List<CourseListing>>("TERM_COURSES_BYTERM", m_baseparam, term.ToString());
        }

        public RunResult<List<ExamData>> GetTermExamSchedule(int term = 0) {
            term = GetLatestTermNumber(term);
            if (term < 0) return new RunResult<List<ExamData>>(new HttpRequestException("Unable to retrieve current school term."));
            return Get<List<ExamData>>("TERM_EXSCHED_BYTERM", m_baseparam, term.ToString());
        }

        public async Task<RunResult<List<ExamData>>> GetTermExamScheduleAsync(int term = 0) {
            term = await GetLatestTermNumberAsync(term);
            if (term < 0) return new RunResult<List<ExamData>>(new HttpRequestException("Unable to retrieve current school term."));
            return await GetAsync<List<ExamData>>("TERM_EXSCHED_BYTERM", m_baseparam, term.ToString());
        }

        public RunResult<List<ClassSchedule>> GetSubjectSchedules(string subject, int term = 0) {
            term = GetLatestTermNumber(term);
            if (term < 0) return new RunResult<List<ClassSchedule>>(new HttpRequestException("Unable to retrieve current school term."));
            return Get<List<ClassSchedule>>("TERM_SCHEDULE_ALL_BYSPEC", m_baseparam, term.ToString(), subject);
        }

        public async Task<RunResult<List<ClassSchedule>>> GetSubjectSchedulesAsync(string subject, int term = 0) {
            term = await GetLatestTermNumberAsync(term);
            if (term < 0) return new RunResult<List<ClassSchedule>>(new HttpRequestException("Unable to retrieve current school term."));
            return await GetAsync<List<ClassSchedule>>("TERM_SCHEDULE_ALL_BYSPEC", m_baseparam, term.ToString(), subject);
        }

        public RunResult<List<ClassSchedule>> GetClassSchedules(string subject, string catalog_number, int term = 0) {
            term = GetLatestTermNumber(term);
            if (term < 0) return new RunResult<List<ClassSchedule>>(new HttpRequestException("Unable to retrieve current school term."));
            return Get<List<ClassSchedule>>("TERM_SCHEDULE_CN_BYSPEC", m_baseparam, term.ToString(), subject, catalog_number);
        }

        public async Task<RunResult<List<ClassSchedule>>> GetClassSchedulesAsync(string subject, string catalog_number, int term = 0) {
            term = await GetLatestTermNumberAsync(term);
            if (term < 0) return new RunResult<List<ClassSchedule>>(new HttpRequestException("Unable to retrieve current school term."));
            return await GetAsync<List<ClassSchedule>>("TERM_SCHEDULE_CN_BYSPEC", m_baseparam, term.ToString(), subject, catalog_number);
        }

        public RunResult<List<ClassSchedule>> GetClassSchedules(string subject, int catalog_number, int term = 0) {
            return GetClassSchedules(subject, catalog_number.ToString(), term);
        }

        public Task<RunResult<List<ClassSchedule>>> GetClassSchedulesAsync(string subject, int catalog_number, int term = 0) {
            return GetClassSchedulesAsync(subject, catalog_number.ToString(), term);
        }

        public RunResult<List<CourseEnrollment>> GetCourseEnrollment(int term = 0) {
            term = GetLatestTermNumber(term);
            if (term < 0) return new RunResult<List<CourseEnrollment>>(new HttpRequestException("Unable to retrieve current school term."));
            return Get<List<CourseEnrollment>>("TERM_ENROLLMENT_BYTERM", m_baseparam, term.ToString());
        }

        public async Task<RunResult<List<CourseEnrollment>>> GetCourseEnrollmentAsync(int term = 0) {
            term = await GetLatestTermNumberAsync(term);
            if (term < 0) return new RunResult<List<CourseEnrollment>>(new HttpRequestException("Unable to retrieve current school term."));
            return await GetAsync<List<CourseEnrollment>>("TERM_ENROLLMENT_BYTERM", m_baseparam, term.ToString());
        }

        public RunResult<List<CourseEnrollment>> GetSubjectEnrollment(string subject, int term = 0) {
            term = GetLatestTermNumber(term);
            if (term < 0) return new RunResult<List<CourseEnrollment>>(new HttpRequestException("Unable to retrieve current school term."));
            return Get<List<CourseEnrollment>>("TERM_ENROLLMENT_BYSPEC", m_baseparam, term.ToString(), subject);
        }

        public async Task<RunResult<List<CourseEnrollment>>> GetSubjectEnrollmentAsync(string subject, int term = 0) {
            term = await GetLatestTermNumberAsync(term);
            if (term < 0) return new RunResult<List<CourseEnrollment>>(new HttpRequestException("Unable to retrieve current school term."));
            return await GetAsync<List<CourseEnrollment>>("TERM_ENROLLMENT_BYSPEC", m_baseparam, term.ToString(), subject);
        }

        public RunResult<List<InfosessionData>> GetTermInfosessions(int term = 0) {
            term = GetLatestTermNumber(term);
            if (term < 0) return new RunResult<List<InfosessionData>>(new HttpRequestException("Unable to retrieve current school term."));
            return Get<List<InfosessionData>>("TERM_INFOSESS_BYTERM", m_baseparam, term.ToString());
        }

        public async Task<RunResult<List<InfosessionData>>> GetTermInfosessionsAsync(int term = 0) {
            term = await GetLatestTermNumberAsync(term);
            if (term < 0) return new RunResult<List<InfosessionData>>(new HttpRequestException("Unable to retrieve current school term."));
            return await GetAsync<List<InfosessionData>>("TERM_INFOSESS_BYTERM", m_baseparam, term.ToString());
        }
    }
}
