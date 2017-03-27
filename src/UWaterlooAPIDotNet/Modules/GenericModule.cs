using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;

namespace UWaterlooAPIDotNet.Modules
{
    public class GenericModule 
    {
        private string m_apikey;
        private HttpClient m_client;

        protected GenericModule(string apikey, HttpClient client) {
            m_apikey = apikey;
            m_client = client;
        }

        protected RunResult<T> Get<T>(string endpoint_name, HttpContent parameters = null) {
            try {
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name));
                message.Content = parameters;
                var result = m_client.SendAsync(message).Result;
                var data = JsonConvert.DeserializeObject<Response<T>>(result.Content.ReadAsStringAsync().Result);
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }

        protected RunResult<T> Get<T>(string endpoint_name, HttpContent parameters = null, params object[] args) {
            try {
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name, args));
                message.Content = parameters;
                var result = m_client.SendAsync(message).Result;
                var data = JsonConvert.DeserializeObject<Response<T>>(result.Content.ReadAsStringAsync().Result);
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }

        protected async Task<RunResult<T>> GetAsync<T>(string endpoint_name, HttpContent parameters = null) {
            try {
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name));
                message.Content = parameters;
                var result = await m_client.SendAsync(message).ConfigureAwait(false);
                var data = JsonConvert.DeserializeObject<Response<T>>(await result.Content.ReadAsStringAsync().ConfigureAwait(false));
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }

        protected async Task<RunResult<T>> GetAsync<T>(string endpoint_name, HttpContent parameters = null, params object[] args) {
            try {
                var message = new HttpRequestMessage(HttpMethod.Get, Endpoints.GetEndpoint(endpoint_name, args));
                message.Content = parameters;
                var result = await m_client.SendAsync(message).ConfigureAwait(false);
                var data = JsonConvert.DeserializeObject<Response<T>>(await result.Content.ReadAsStringAsync().ConfigureAwait(false));
                return new RunResult<T>(data);
            } catch (Exception ex) {
                return new RunResult<T>(ex);
            }
        }
    }
}
