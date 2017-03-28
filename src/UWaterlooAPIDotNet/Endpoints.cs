using System.Collections.Generic;

namespace UWaterlooAPIDotNet
{
    public static class Endpoints
    {
        private static readonly Dictionary<string, string> m_endpoints = new Dictionary<string, string>() {
            { "FS_MENU",                  "/foodservices/menu" },                      // Not Implemented
            { "FS_NOTES",                 "/foodservices/notes" },                     // Not Implemented
            { "FS_DIETS",                 "/foodservices/diets" },                     // Not Implemented
            { "FS_OUTLETS",               "/foodservices/outlets" },                   // Not Implemented
            { "FS_LOCATIONS",             "/foodservices/locations" },                 // Not Implemented
            { "FS_WATCARD",               "/foodservices/watcard" },                   // Not Implemented
            { "FS_ANNOUNCEMENTS",         "/foodservices/announcements" },             // Not Implemented
            { "FS_PRODUCT_BYSPEC",        "/foodservices/products/{0}" },              // Not Implemented
            { "FS_MENU_BYSPEC",           "/foodservices/{0}/{1}/menu" },              // Not Implemented
            { "FS_NOTE_BYSPEC",           "/foodservices/{0}/{1}/notes" },             // Not Implemented
            { "FS_ANNOUNCEMENT_BYSPEC",   "/foodservices/{0}/{1}/announcements" },     // Not Implemented
            { "FEDS_EVENTS",              "/feds/events" },                            // Not Implemented
            { "FEDS_EVENTS_BYID",         "/feds/events/{0}" },                        // Not Implemented
            { "FEDS_LOCATIONS",           "/feds/locations" },                         // Not Implemented
            { "CR_COURSES",               "/courses" },                                // Not Implemented
            { "CR_COURSES_BYSUB",         "/courses/{0}" },                            // Not Implemented
            { "CR_COURSES_BYID",          "/courses/{0}" },                            // Not Implemented
            { "CR_COURSES_SCHED_BYCN",    "/courses/{0}/schedule" },                   // Not Implemented
            { "CR_COURSE_BYSPEC",         "/courses/{0}/{1}" },                        // Not Implemented
            { "CR_COURSE_SCHED_BYSPEC",   "/courses/{0}/{1}/schedule" },               // Not Implemented
            { "CR_COURSE_PREQ_BYSPEC",    "/courses/{0}/{1}/prerequisites" },          // Not Implemented
            { "CR_COURSE_EXAMS_BYSPEC",   "/courses/{0}/{1}/examschedule" },           // Not Implemented
            { "AWARDS_GRADUATE",          "/awards/graduate" },                        // Not Implemented
            { "AWARDS_UNDERGRADUATE",     "/awards/undergraduate" },                   // Not Implemented
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
            { "WEATHER_CURRENT",          "/weather/current" },                        // Not Implemented
            { "TERMS_LIST",               "/terms/list" },                             // Not Implemented
            { "TERM_COURSES_BYTERM",      "/terms/{0}/courses" },                      // Not Implemented
            { "TERM_EXSCHED_BYTERM",      "/terms/{0}/examschedule" },                 // Not Implemented
            { "TERM_SCHEDULE_ALL_BYSPEC", "/terms/{0}/{1}/schedule" },                 // Not Implemented
            { "TERM_SCHEDULE_CN_BYSPEC",  "/terms/{0}/{1}/{2}/schedule" },             // Not Implemented
            { "TERM_ENROLLMENT_BYTERM",   "/terms/{0}/enrollment" },                   // Not Implemented
            { "TERM_ENROLLMENT_BYSPEC",   "/terms/{0}/{1}/enrollment" },               // Not Implemented
            { "TERM_INFOSESS_BYTERM",     "/terms/{0}/infosessions" },                 // Not Implemented
            { "RS_TUTORS",                "/resources/tutors" },                       // Not Implemented
            { "RS_INFOSESSIONS",          "/resources/infosessions" },                 // Not Implemented
            { "RS_GOOSEWATCH",            "/resources/goosewatch" },                   // Not Implemented
            { "RS_SUNSHINELIST",          "/resources/sunshinelist" },                 // Not Implemented
            { "CODES_UNITS",              "/codes/units" },                            // Not Implemented
            { "CODES_TERMS",              "/codes/terms" },                            // Not Implemented
            { "CODES_GROUPS",             "/codes/groups" },                           // Not Implemented
            { "CODES_SUBJECTS",           "/codes/subjects" },                         // Not Implemented
            { "CODES_INSTRUCTIONS",       "/codes/instructions" },                     // Not Implemented
            { "BLDNG_LIST",               "/buildings/list" },                         // Not Implemented
            { "BLDNG_BYCODE",             "/buildings/{0}" },                          // Not Implemented
            { "BLDNG_COURSES_BYSPEC",     "/buildings/{0}/{1}/courses" },              // Not Implemented
            { "BLDNG_ACCESSPT_BYCODE",    "/buildings/{0}/accesspoints" },             // Not Implemented
            { "BLDNG_VENDING_BYCODE",     "/buildings/{0}/vendingmachines" },          // Not Implemented
            { "POI_ATMS",                 "/poi/atms" },                               // Not Implemented
            { "POI_GREYHOUND",            "/poi/greyhound" },                          // Not Implemented
            { "POI_HELPLINES",            "/poi/helplines" },                          // Not Implemented
            { "POI_LIBRARIES",            "/poi/libraries" },                          // Not Implemented
            { "POI_PHOTOSPHERES",         "/poi/photospheres" },                       // Not Implemented
            { "POI_DEFIBRILLATORS",       "/poi/defibrillators" },                     // Not Implemented
            { "POI_CONSTRUCTION",         "/poi/constructionsites" },                  // Not Implemented
            { "POI_ACCESSIBLE_ENT",       "/poi/accessibleentrances" },                // Not Implemented
            { "POI_VISITORINFO",          "/poi/visitorinformation" },                 // Not Implemented
            { "PRKNG_WATPARK",            "/parking/watpark" },                        // Implemented
            { "PRKNG_METERS",             "/parking/lots/meter" },                     // Implemented
            { "PRKNG_PERMITS",            "/parking/lots/permit" },                    // Implemented
            { "PRKNG_VISITORS",           "/parking/lots/visitor" },                   // Implemented
            { "PRKNG_SHORTTERM",          "/parking/lots/shortterm" },                 // Implemented
            { "PRKNG_ACCESSIBLE",         "/parking/lots/accessible" },                // Implemented
            { "PRKNG_MOTORCYCLE",         "/parking/lots/motorcycle" },                // Implemented
            { "TRANSIT_GRT",              "/transit/grt" },                            // Implemented
            { "TRANSIT_GRT_STOPS",        "/transit/grt/stops" },                      // Implemented
            { "DIRECTORY_USERINFO",       "/directory/{0}" },                          // Implemented
            { "API_USAGE",                "/api/usage" },                              // Implemented
            { "API_SERVICES",             "/api/services" },                           // Implemented
            { "API_METHODS",              "/api/methods" },                            // Implemented
            { "API_VERSIONS",             "/api/versions" },                           // Implemented
            { "API_CHANGELOG",            "/api/changelog" },                          // Implemented
            { "SERVER_TIME",              "/server/time" },                            // Implemented
            { "SERVER_CODES",             "/server/codes" },                           // Implemented
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
