using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Courses;
using UWaterlooAPIDotNet.Models.Terms;

namespace UWaterlooAPIDotNet.Modules
{
    public class Courses : GenericModule
    {
        public Courses(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<BasicCourse>> GetCourseList() {
            return Get<List<BasicCourse>>("CR_COURSES", m_baseparam);
        }

        public Task<RunResult<List<BasicCourse>>> GetCourseListAsync() {
            return GetAsync<List<BasicCourse>>("CR_COURSES", m_baseparam);
        }

        public RunResult<List<Course>> GetCoursesBySubject(string subject) {
            return Get<List<Course>>("CR_COURSES_BYSUB", m_baseparam);
        }

        public Task<RunResult<List<Course>>> GetCoursesBySubjectAsync(string subject) {
            return GetAsync<List<Course>>("CR_COURSES_BYSUB", m_baseparam);
        }

        public RunResult<ExtendedCourse> GetCourseDetails(string course_id) {
            return Get<ExtendedCourse>("CR_COURSES_BYID", m_baseparam, course_id);
        }

        public Task<RunResult<ExtendedCourse>> GetCourseDetailsAsync(string course_id) {
            return GetAsync<ExtendedCourse>("CR_COURSES_BYID", m_baseparam, course_id);
        }

        public RunResult<ExtendedCourse> GetCourseDetails(BasicCourse course) {
            return GetCourseDetails(course.ID);
        }

        public Task<RunResult<ExtendedCourse>> GetCourseDetailsAsync(BasicCourse course) {
            return GetCourseDetailsAsync(course.ID);
        }

        public RunResult<ClassSchedule> GetClassSchedule(int class_number) {
            return Get<ClassSchedule>("CR_COURSES_SCHED_BYCN", m_baseparam, class_number.ToString());
        }

        public Task<RunResult<ClassSchedule>> GetClassScheduleAsync(int class_number) {
            return GetAsync<ClassSchedule>("CR_COURSES_SCHED_BYCN", m_baseparam, class_number.ToString());
        }

        public RunResult<ExtendedCourse> GetCourseInfo(string subject, string catalog_number) {
            return Get<ExtendedCourse>("CR_COURSES_BYSUB", m_baseparam);
        }

        public Task<RunResult<ExtendedCourse>> GetCourseInfoAsync(string subject, string catalog_number) {
            return GetAsync<ExtendedCourse>("CR_COURSES_BYSUB", m_baseparam);
        }

        public RunResult<ExtendedCourse> GetCourseDetails(string subject, string catalog_number) {
            return Get<ExtendedCourse>("CR_COURSE_BYSPEC", m_baseparam, subject, catalog_number);
        }

        public Task<RunResult<ExtendedCourse>> GetCourseDetailsAsync(string subject, string catalog_number) {
            return GetAsync<ExtendedCourse>("CR_COURSE_BYSPEC", m_baseparam, subject, catalog_number);
        }

        public RunResult<List<ClassSchedule>> GetCourseSchedules(string subject, string catalog_number) {
            return Get<List<ClassSchedule>>("CR_COURSE_SCHED_BYSPEC", m_baseparam, subject, catalog_number);
        }

        public Task<RunResult<List<ClassSchedule>>> GetCourseSchedulesAsync(string subject, string catalog_number) {
            return GetAsync<List<ClassSchedule>>("CR_COURSE_SCHED_BYSPEC", m_baseparam, subject, catalog_number);
        }

        public RunResult<CoursePrerequisites> GetCoursePrerequisites(string subject, string catalog_number) {
            return Get<CoursePrerequisites>("CR_COURSE_PREQ_BYSPEC", m_baseparam, subject, catalog_number);
        }

        public Task<RunResult<CoursePrerequisites>> GetCoursePrerequisitesAsync(string subject, string catalog_number) {
            return GetAsync<CoursePrerequisites>("CR_COURSE_PREQ_BYSPEC", m_baseparam, subject, catalog_number);
        }

        public RunResult<ExamData> GetCourseExamSchedule(string subject, string catalog_number) {
            return Get<ExamData>("CR_COURSE_EXAMS_BYSPEC", m_baseparam, subject, catalog_number);
        }

        public Task<RunResult<ExamData>> GetCourseExamScheduleAsync(string subject, string catalog_number) {
            return GetAsync<ExamData>("CR_COURSE_EXAMS_BYSPEC", m_baseparam, subject, catalog_number);
        }
    }
}
