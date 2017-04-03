using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Blogs;

namespace UWaterlooAPIDotNet.Modules
{
    public class Blogs : GenericModule 
    {
        public Blogs(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<BlogEntry>> GetBlogEntries(string site_id) {
            return Get<List<BlogEntry>>("BLOGS_BYSITE", m_baseparam, site_id);
        }

        public Task<RunResult<List<BlogEntry>>> GetBlogEntriesAsync(string site_id) {
            return GetAsync<List<BlogEntry>>("BLOGS_BYSITE", m_baseparam, site_id);
        }

        public RunResult<DetailedBlogEntry> GetBlogEntry(string site_id, int blog_id) {
            return Get<DetailedBlogEntry>("BLOGS_BYSPEC", m_baseparam, site_id, blog_id.ToString());
        }

        public Task<RunResult<DetailedBlogEntry>> GetBlogEntryAsync(string site_id, int blog_id) {
            return GetAsync<DetailedBlogEntry>("BLOGS_BYSPEC", m_baseparam, site_id, blog_id.ToString());
        }

        public RunResult<DetailedBlogEntry> GetBlogEntry(string site_id, BlogEntry entry) {
            return GetBlogEntry(site_id, (int)entry.ID);
        }

        public Task<RunResult<DetailedBlogEntry>> GetBlogEntryAsync(string site_id, BlogEntry entry) {
            return GetBlogEntryAsync(site_id, (int)entry.ID);
        }
    }
}
