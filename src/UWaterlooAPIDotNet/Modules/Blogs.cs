﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Blogs;

namespace UWaterlooAPIDotNet.Modules
{
    public class Blogs : GenericModule 
    {
        public Blogs(string apikey, HttpClient client) : base(apikey, client) { }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all blog entries under a particular site.
        /// </summary>
        /// <param name="site_id">The ID of the site in question.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="BlogEntry"/> objects, if applicable.</returns>
        public RunResult<List<BlogEntry>> GetBlogEntries(string site_id) {
            return Get<List<BlogEntry>>("BLOGS_BYSITE", m_baseparam, site_id);
        }

        /// <summary>
        /// Obtain a <see cref="List{T}"/> of all blog entries under a particular site.
        /// </summary>
        /// <param name="site_id">The ID of the site in question.</param>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="BlogEntry"/>, if applicable.</returns>
        public Task<RunResult<List<BlogEntry>>> GetBlogEntriesAsync(string site_id) {
            return GetAsync<List<BlogEntry>>("BLOGS_BYSITE", m_baseparam, site_id);
        }

        /// <summary>
        /// Obtain detailed information of a specific blog entry.
        /// </summary>
        /// <param name="site_id">The ID of the site the blog entry belongs to.</param>
        /// <param name="blog_id">The ID of the specific blog entry.</param>
        /// <returns>A <see cref="DetailedBlogEntry"/>, if applicable.</returns>
        public RunResult<DetailedBlogEntry> GetBlogEntry(string site_id, int blog_id) {
            return Get<DetailedBlogEntry>("BLOGS_BYSPEC", m_baseparam, site_id, blog_id.ToString());
        }

        /// <summary>
        /// Obtain detailed information of a specific blog entry.
        /// </summary>
        /// <param name="site_id">The ID of the site the blog entry belongs to.</param>
        /// <param name="blog_id">The ID of the specific blog entry.</param>
        /// <returns>An awaitable task of a <see cref="DetailedBlogEntry"/>, if applicable.</returns>
        public Task<RunResult<DetailedBlogEntry>> GetBlogEntryAsync(string site_id, int blog_id) {
            return GetAsync<DetailedBlogEntry>("BLOGS_BYSPEC", m_baseparam, site_id, blog_id.ToString());
        }

        /// <summary>
        /// Obtain detailed information of a specific <see cref="BlogEntry"/>.
        /// </summary>
        /// <param name="site_id">The ID of the site the blog entry belongs to.</param>
        /// <param name="entry">A <see cref="BlogEntry"/>, from which the entry ID is obtained.</param>
        /// <returns>A <see cref="DetailedBlogEntry"/>, if applicable.</returns>
        public RunResult<DetailedBlogEntry> GetBlogEntry(string site_id, BlogEntry entry) {
            return GetBlogEntry(site_id, (int)entry.ID);
        }

        /// <summary>
        /// Obtain detailed information of a specific <see cref="BlogEntry"/>.
        /// </summary>
        /// <param name="site_id">The ID of the site the blog entry belongs to.</param>
        /// <param name="entry">A <see cref="BlogEntry"/>, from which the entry ID is obtained.</param>
        /// <returns>An awaitable task of a <see cref="DetailedBlogEntry"/>, if applicable.</returns>
        public Task<RunResult<DetailedBlogEntry>> GetBlogEntryAsync(string site_id, BlogEntry entry) {
            return GetBlogEntryAsync(site_id, (int)entry.ID);
        }
    }
}
