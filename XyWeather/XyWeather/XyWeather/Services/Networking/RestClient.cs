using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace XyWeather.Services.Networking
{
    public class RestClient : IRestClient
    {
        public async Task<string> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
