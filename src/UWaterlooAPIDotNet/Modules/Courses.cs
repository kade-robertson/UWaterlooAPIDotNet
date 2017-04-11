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

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of <see cref="BasicCourse"/> for all available courses.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="BasicCourse"/>.</returns>
        public RunResult<List<BasicCourse>> GetCourseList() {
            return Get<List<BasicCourse>>("CR_COURSES", m_baseparam);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of <see cref="BasicCourse"/> for all available courses.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="BasicCourse"/>.</returns>
        public Task<RunResult<List<BasicCourse>>> GetCourseListAsync() {
            return GetAsync<List<BasicCourse>>("CR_COURSES", m_baseparam);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of <see cref="Course"/> for all available courses in the specified subject.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Course"/>.</returns>
        public RunResult<List<Course>> GetCoursesBySubject(string subject) {
            return Get<List<Course>>("CR_COURSES_BYSUB", m_baseparam);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of <see cref="Course"/> for all available courses in the specified subject.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Course"/>.</returns>
        public Task<RunResult<List<Course>>> GetCoursesBySubjectAsync(string subject) {
            return GetAsync<List<Course>>("CR_COURSES_BYSUB", m_baseparam);
        }

        /// <summary>
        /// Obtain extra course details in an <see cref="ExtendedCourse"/> object.
        /// </summary>
        /// <param name="course_id">The course ID to obtain details for.</param>
        /// <returns>An <see cref="ExtendedCourse"/>.</returns>
        public RunResult<ExtendedCourse> GetCourseDetails(string course_id) {
            return Get<ExtendedCourse>("CR_COURSES_BYID", m_baseparam, course_id);
        }

        /// <summary>
        /// Obtain extra course details in an <see cref="ExtendedCourse"/> object.
        /// </summary>
        /// <param name="course_id">The course ID to obtain details for.</param>
        /// <returns>An awaitable task of an <see cref="ExtendedCourse"/>.</returns>
        public Task<RunResult<ExtendedCourse>> GetCourseDetailsAsync(string course_id) {
            return GetAsync<ExtendedCourse>("CR_COURSES_BYID", m_baseparam, course_id);
        }

        /// <summary>
        /// Obtain extra course details in an <see cref="ExtendedCourse"/> object.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to obtain more details for.</param>
        /// <returns>An <see cref="ExtendedCourse"/>.</returns>
        public RunResult<ExtendedCourse> GetCourseDetails(BasicCourse course) {
            return GetCourseDetails(course.ID);
        }

        /// <summary>
        /// Obtain extra course details in an <see cref="ExtendedCourse"/> object.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to obtain more details for.</param>
        /// <returns>An awaitable task of an <see cref="ExtendedCourse"/>.</returns>
        public Task<RunResult<ExtendedCourse>> GetCourseDetailsAsync(BasicCourse course) {
            return GetCourseDetailsAsync(course.ID);
        }

        /// <summary>
        /// Obtain the <see cref="ClassSchedule"/> for a specified class number.
        /// </summary>
        /// <param name="class_number">The class number.</param>
        /// <returns>A <see cref="ClassSchedule"/>.</returns>
        public RunResult<ClassSchedule> GetClassSchedule(int class_number) {
            return Get<ClassSchedule>("CR_COURSES_SCHED_BYCN", m_baseparam, class_number.ToString());
        }

        /// <summary>
        /// Obtain the <see cref="ClassSchedule"/> for a specified class number.
        /// </summary>
        /// <param name="class_number">The class number.</param>
        /// <returns>An awaitable task of a <see cref="ClassSchedule"/>.</returns>
        public Task<RunResult<ClassSchedule>> GetClassScheduleAsync(int class_number) {
            return GetAsync<ClassSchedule>("CR_COURSES_SCHED_BYCN", m_baseparam, class_number.ToString());
        }

        /// <summary>
        /// Obtain extra course details in an <see cref="ExtendedCourse"/> object.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>An <see cref="ExtendedCourse"/>.</returns>
        public RunResult<ExtendedCourse> GetCourseDetails(string subject, string catalog_number) {
            return Get<ExtendedCourse>("CR_COURSE_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain extra course details in an <see cref="ExtendedCourse"/> object.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>An awaitable task of an <see cref="ExtendedCourse"/>.</returns>
        public Task<RunResult<ExtendedCourse>> GetCourseDetailsAsync(string subject, string catalog_number) {
            return GetAsync<ExtendedCourse>("CR_COURSE_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain the <see cref="ClassSchedule"/> for a specified subject and catalog number.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>A <see cref="ClassSchedule"/>.</returns>
        public RunResult<List<ClassSchedule>> GetCourseSchedules(string subject, string catalog_number) {
            return Get<List<ClassSchedule>>("CR_COURSE_SCHED_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain the <see cref="ClassSchedule"/> for a specified subject and catalog number.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>An awaitable task of a <see cref="ClassSchedule"/>.</returns>
        public Task<RunResult<List<ClassSchedule>>> GetCourseSchedulesAsync(string subject, string catalog_number) {
            return GetAsync<List<ClassSchedule>>("CR_COURSE_SCHED_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain the <see cref="ClassSchedule"/> for a specified <see cref="BasicCourse"/>.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to pull information from.</param>
        /// <returns>A <see cref="ClassSchedule"/>.</returns>
        public RunResult<List<ClassSchedule>> GetCourseSchedules(BasicCourse course) {
            return GetCourseSchedules(course.Subject, course.CatalogNumber);
        }

        /// <summary>
        /// Obtain the <see cref="ClassSchedule"/> for a specified <see cref="BasicCourse"/>.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to pull information from.</param>
        /// <returns>An awaitable task of a <see cref="ClassSchedule"/>.</returns>
        public Task<RunResult<List<ClassSchedule>>> GetCourseSchedulesAsync(BasicCourse course) {
            return GetCourseSchedulesAsync(course.Subject, course.CatalogNumber);
        }

        /// <summary>
        /// Obtain <see cref="CoursePrerequisites"/> for a specified subject and catalog number.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>A <see cref="CoursePrerequisites"/>.</returns>
        public RunResult<CoursePrerequisites> GetCoursePrerequisites(string subject, string catalog_number) {
            return Get<CoursePrerequisites>("CR_COURSE_PREQ_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain <see cref="CoursePrerequisites"/> for a specified subject and catalog number.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>An awaitable task of a <see cref="CoursePrerequisites"/>.</returns>
        public Task<RunResult<CoursePrerequisites>> GetCoursePrerequisitesAsync(string subject, string catalog_number) {
            return GetAsync<CoursePrerequisites>("CR_COURSE_PREQ_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain <see cref="CoursePrerequisites"/> for a specified <see cref="BasicCourse"/>.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to pull information from.</param>
        /// <returns>A <see cref="CoursePrerequisites"/>.</returns>
        public RunResult<CoursePrerequisites> GetCoursePrerequisites(BasicCourse course) {
            return GetCoursePrerequisites(course.Subject, course.CatalogNumber);
        }

        /// <summary>
        /// Obtain <see cref="CoursePrerequisites"/> for a specified <see cref="BasicCourse"/>.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to pull information from.</param>
        /// <returns>An awaitable task of a <see cref="CoursePrerequisites"/>.</returns>
        public Task<RunResult<CoursePrerequisites>> GetCoursePrerequisitesAsync(BasicCourse course) {
            return GetCoursePrerequisitesAsync(course.Subject, course.CatalogNumber);
        }

        /// <summary>
        /// Obtain <see cref="ExamData"/> for a specified subject and catalog number.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>An <see cref="ExamData"/> object.</returns>
        public RunResult<ExamData> GetCourseExamSchedule(string subject, string catalog_number) {
            return Get<ExamData>("CR_COURSE_EXAMS_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain <see cref="ExamData"/> for a specified subject and catalog number.
        /// </summary>
        /// <param name="subject">The subject the course belongs to.</param>
        /// <param name="catalog_number">The catalog number of the course.</param>
        /// <returns>An awaitable task of an <see cref="ExamData"/> object.</returns>
        public Task<RunResult<ExamData>> GetCourseExamScheduleAsync(string subject, string catalog_number) {
            return GetAsync<ExamData>("CR_COURSE_EXAMS_BYSPEC", m_baseparam, subject, catalog_number);
        }

        /// <summary>
        /// Obtain <see cref="ExamData"/> for a specified <see cref="BasicCourse"/>.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to pull information from.</param>
        /// <returns>An <see cref="ExamData"/> object.</returns>
        public RunResult<ExamData> GetCourseExamSchedule(BasicCourse course) {
            return GetCourseExamSchedule(course.Subject, course.CatalogNumber);
        }

        /// <summary>
        /// Obtain <see cref="ExamData"/> for a specified <see cref="BasicCourse"/>.
        /// </summary>
        /// <param name="course">The <see cref="BasicCourse"/> to pull information from.</param>
        /// <returns>An awaitable task of an <see cref="ExamData"/> object.</returns>
        public Task<RunResult<ExamData>> GetCourseExamScheduleAsync(BasicCourse course) {
            return GetCourseExamScheduleAsync(course.Subject, course.CatalogNumber);
        }
    }
}
