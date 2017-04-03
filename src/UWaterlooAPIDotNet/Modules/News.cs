using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.News;

namespace UWaterlooAPIDotNet.Modules
{
    public class News : GenericModule 
    {
        public News(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<SiteNews>> GetAllNewsArticles() {
            return Get<List<SiteNews>>("NEWS_ALL", m_baseparam);
        }

        public Task<RunResult<List<SiteNews>>> GetAllNewsArticlesAsync() {
            return GetAsync<List<SiteNews>>("NEWS_ALL", m_baseparam);
        }

        public RunResult<List<GenericNews>> GetNewsArticles(string site_id) {
            return Get<List<GenericNews>>("NEWS_BYSITE", m_baseparam, site_id);
        }

        public Task<RunResult<List<GenericNews>>> GetNewsArticlesAsync(string site_id) {
            return GetAsync<List<GenericNews>>("NEWS_BYSITE", m_baseparam, site_id);
        }

        public RunResult<DetailedNews> GetNewsArticleDetails(string site_id, int news_id) {
            return Get<DetailedNews>("NEWS_BYSPEC", m_baseparam, site_id, news_id.ToString());
        }

        public Task<RunResult<DetailedNews>> GetNewsArticleDetailsAsync(string site_id, int news_id) {
            return GetAsync<DetailedNews>("NEWS_BYSPEC", m_baseparam, site_id, news_id.ToString());
        }

        public RunResult<DetailedNews> GetNewsArticleDetails(string site_id, GenericNews news) {
            return GetNewsArticleDetails(site_id, (int)news.ID);
        }

        public Task<RunResult<DetailedNews>> GetNewsArticleDetailsAsync(string site_id, GenericNews news) {
            return GetNewsArticleDetailsAsync(site_id, (int)news.ID);
        }

        public RunResult<DetailedNews> GetNewsArticleDetails(SiteNews news) {
            return GetNewsArticleDetails(news.SiteID, (int)news.ID);
        }

        public Task<RunResult<DetailedNews>> GetNewsArticleDetailsAsync(SiteNews news) {
            return GetNewsArticleDetailsAsync(news.SiteID, (int)news.ID);
        }
    }
}
