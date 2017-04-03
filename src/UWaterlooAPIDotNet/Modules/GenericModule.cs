using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;

namespace UWaterlooAPIDotNet.Modules
{
    public class GenericModule
    {
        protected string m_apikey;
        protected HttpClient m_client;
        protected string m_baseparam;

        protected GenericModule(string apikey, HttpClient client) {
            m_apikey = apikey;
            m_client = client;
            m_baseparam = $"?key={apikey}";
        }

        protected RunResult<T> Get<T>(string endpoint_name, string parameters = "") {
            try { 
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name) + parameters);
                var result = m_client.SendAsync(message).Result;
                var data = JsonConvert.DeserializeObject<Response<T>>(WebUtility.HtmlDecode(result.Content.ReadAsStringAsync().Result));
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }

        protected RunResult<T> Get<T>(string endpoint_name, string parameters = "", params object[] args) {
            try {
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name, args) + parameters);
                var result = m_client.SendAsync(message).Result;
                var data = JsonConvert.DeserializeObject<Response<T>>(WebUtility.HtmlDecode(result.Content.ReadAsStringAsync().Result));
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }

        protected async Task<RunResult<T>> GetAsync<T>(string endpoint_name, string parameters = "") {
            try {
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name) + parameters);
                var result = await m_client.SendAsync(message).ConfigureAwait(false);
                var data = JsonConvert.DeserializeObject<Response<T>>(WebUtility.HtmlDecode(await result.Content.ReadAsStringAsync().ConfigureAwait(false)));
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }

        protected async Task<RunResult<T>> GetAsync<T>(string endpoint_name, string parameters = "", params object[] args) {
            try {
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name, args) + parameters);
                var result = await m_client.SendAsync(message).ConfigureAwait(false);
                var data = JsonConvert.DeserializeObject<Response<T>>(WebUtility.HtmlDecode(await result.Content.ReadAsStringAsync().ConfigureAwait(false)));
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }
    }
}
