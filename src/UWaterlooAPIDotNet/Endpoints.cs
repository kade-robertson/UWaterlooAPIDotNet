using System.Collections.Generic;

namespace UWaterlooAPIDotNet
{
    public static class Endpoints
    {
        private static readonly Dictionary<string, string> m_endpoints = new Dictionary<string, string>() {
            { "FS_MENU",                  "/foodservices/menu" },
            { "FS_NOTES",                 "/foodservices/notes" },
            { "FS_DIETS",                 "/foodservices/diets" },
            { "FS_OUTLETS",               "/foodservices/outlets" },
            { "FS_LOCATIONS",             "/foodservices/locations" },
            { "FS_WATCARD",               "/foodservices/watcard" },
            { "FS_ANNOUNCEMENTS",         "/foodservices/announcements" },
            { "FS_PRODUCT_BYSPEC",        "/foodservices/products/{0}" },
            { "FS_MENU_BYSPEC",           "/foodservices/{0}/{1}/menu" },
            { "FS_NOTE_BYSPEC",           "/foodservices/{0}/{1}/notes" },
            { "FS_ANNOUNCEMENT_BYSPEC",   "/foodservices/{0}/{1}/announcements" },
            { "FEDS_EVENTS",              "/feds/events" },
            { "FEDS_EVENTS_BYID",         "/feds/events/{0}" },
            { "FEDS_LOCATIONS",           "/feds/locations" },
            { "CR_COURSES",               "/courses" },
            { "CR_COURSES_BYSUB",         "/courses/{0}" },
            { "CR_COURSES_BYID",          "/courses/{0}" },
            { "CR_COURSES_SCHED_BYCN",    "/courses/{0}/schedule" },
            { "CR_COURSE_BYSPEC",         "/courses/{0}/{1}" },
            { "CR_COURSE_SCHED_BYSPEC",   "/courses/{0}/{1}/schedule" },
            { "CR_COURSE_PREQ_BYSPEC",    "/courses/{0}/{1}/prerequisites" },
            { "CR_COURSE_EXAMS_BYSPEC",   "/courses/{0}/{1}/examschedule" },
            { "AWARDS_GRADUATE",          "/awards/graduate" },
            { "AWARDS_UNDERGRADUATE",     "/awards/undergraduate" },
            { "EVENTS_ALL",               "/events" },                                 // Not Implemented
            { "EVENTS_BYSITE",            "/events/{0}" },                             // Not Implemented
            { "EVENTS_BYSPEC",            "/events/{0}/{1}" },                         // Not Implemented
            { "EVENTS_HOLIDAYS",          "/events/holidays" },                        // Not Implemented
            { "BLOGS_BYSITE",             "/blogs/{0}" },                              // Not Implemented
            { "BLOGS_BYSPEC",             "/blogs/{0}/{1}" },                          // Not Implemented
            { "NEWS_ALL",                 "/news" },                                   // Not Implemented
            { "NEWS_BYSITE",              "/news/{0}" },                               // Not Implemented
            { "NEWS_BYSPEC",              "/news/{0}/{1}" },                           // Not Implemented
            { "OPPORTUNITIES_ALL",        "/opportunities" },                          // Not Implemented
            { "OPPORTUNITIES_BYSITE",     "/opportunities/{0}" },                      // Not Implemented
            { "OPPORTUNITIES_BYSPEC",     "/opportunities/{0}/{1}" },                  // Not Implemented
            { "SERVICES_BYSITE",          "/services/{0}" },                           // Not Implemented
            { "WEATHER_CURRENT",          "/weather/current" },
            { "TERMS_LIST",               "/terms/list" },
            { "TERM_COURSES_BYTERM",      "/terms/{0}/courses" },
            { "TERM_EXSCHED_BYTERM",      "/terms/{0}/examschedule" },
            { "TERM_SCHEDULE_ALL_BYSPEC", "/terms/{0}/{1}/schedule" },
            { "TERM_SCHEDULE_CN_BYSPEC",  "/terms/{0}/{1}/{2}/schedule" },
            { "TERM_ENROLLMENT_BYTERM",   "/terms/{0}/enrollment" },
            { "TERM_ENROLLMENT_BYSPEC",   "/terms/{0}/{1}/enrollment" },
            { "TERM_INFOSESS_BYTERM",     "/terms/{0}/infosessions" },
            { "RS_TUTORS",                "/resources/tutors" },
            { "RS_INFOSESSIONS",          "/resources/infosessions" },
            { "RS_GOOSEWATCH",            "/resources/goosewatch" },
            { "RS_SUNSHINELIST",          "/resources/sunshinelist" },
            { "CODES_UNITS",              "/codes/units" },
            { "CODES_TERMS",              "/codes/terms" },
            { "CODES_GROUPS",             "/codes/groups" },
            { "CODES_SUBJECTS",           "/codes/subjects" },
            { "CODES_INSTRUCTIONS",       "/codes/instructions" },
            { "BLDNG_LIST",               "/buildings/list" },
            { "BLDNG_BYCODE",             "/buildings/{0}" },
            { "BLDNG_COURSES_BYSPEC",     "/buildings/{0}/{1}/courses" },
            { "BLDNG_ACCESSPT_BYCODE",    "/buildings/{0}/accesspoints" },
            { "BLDNG_VENDING_BYCODE",     "/buildings/{0}/vendingmachines" },
            { "POI_ATMS",                 "/poi/atms" },
            { "POI_GREYHOUND",            "/poi/greyhound" },
            { "POI_HELPLINES",            "/poi/helplines" },
            { "POI_LIBRARIES",            "/poi/libraries" },
            { "POI_PHOTOSPHERES",         "/poi/photospheres" },
            { "POI_DEFIBRILLATORS",       "/poi/defibrillators" },
            { "POI_CONSTRUCTION",         "/poi/constructionsites" },
            { "POI_ACCESSIBLE_ENT",       "/poi/accessibleentrances" },
            { "POI_VISITORINFO",          "/poi/visitorinformation" },
            { "PRKNG_WATPARK",            "/parking/watpark" },
            { "PRKNG_METERS",             "/parking/lots/meter" },
            { "PRKNG_PERMITS",            "/parking/lots/permit" },
            { "PRKNG_VISITORS",           "/parking/lots/visitor" },
            { "PRKNG_SHORTTERM",          "/parking/lots/shortterm" },
            { "PRKNG_ACCESSIBLE",         "/parking/lots/accessible" },
            { "PRKNG_MOTORCYCLE",         "/parking/lots/motorcycle" },
            { "TRANSIT_GRT",              "/transit/grt" },
            { "TRANSIT_GRT_STOPS",        "/transit/grt/stops" },
            { "DIRECTORY_USERINFO",       "/directory/{0}" },
            { "API_USAGE",                "/api/usage" },
            { "API_SERVICES",             "/api/services" },
            { "API_METHODS",              "/api/methods" },
            { "API_VERSIONS",             "/api/versions" },
            { "API_CHANGELOG",            "/api/changelog" },
            { "SERVER_TIME",              "/server/time" },
            { "SERVER_CODES",             "/server/codes" },
        };

        /// <summary>
        /// Return the endpoint of a specified name.
        /// </summary>
        /// <param name="name">The name of the endpoint.</param>
        /// <returns>The requested endpoint.</returns>
        public static string GetEndpoint(string name) {
            return $"/v2{m_endpoints[name]}.json";
        }

        /// <summary>
        /// Returns the endpoint of a specified name, with parameters as required.
        /// </summary>
        /// <param name="name">The name of the endpoint.</param>
        /// <param name="args">The parameters to format with.</param>
        /// <returns>The requested endpoint, formatted appropriately.</returns>
        public static string GetEndpoint(string name, params object[] args) {
            return string.Format(GetEndpoint(name), args);
        }
    }
}
