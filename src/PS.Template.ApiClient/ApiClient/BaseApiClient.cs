using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PS.Template.ApiClient.ApiClient
{
    public class BaseApiClient
    {
        public async Task<TResponse> GetAsync<TResponse>(string Url) where TResponse : class
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, Url);
            var responseMessage = await client.SendAsync(request);
            var stringContentAsync = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.IsSuccessStatusCode)
            {
                return Deserializer<TResponse>(stringContentAsync);
            }
            return null;

        }
        public virtual async Task<TResponse> ApiPost<T, TResponse>(string url, T bodyRequest)
            where T : class
            where TResponse : class
        {
            using var client = new HttpClient();
            var stringBody = JsonConvert.SerializeObject(bodyRequest);
            var httpContent = new StringContent(stringBody, Encoding.UTF8);
            var responseMessage = await client.PostAsync(url, httpContent);
            var stringContentAsync = await responseMessage.Content.ReadAsStringAsync();

            if (responseMessage.IsSuccessStatusCode)
            {
                return Deserializer<TResponse>(stringContentAsync);
            }
            return null;
        }
        private T Deserializer<T>(string content) where T : class
        {
            if (string.IsNullOrWhiteSpace(content))
                return (T)Convert.ChangeType(true, typeof(T));
            var jss = new JsonSerializerSettings
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateParseHandling = DateParseHandling.None
            };
            try
            {
                return JsonConvert.DeserializeObject<T>(content, jss);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
