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
            var respose = await httpClient.GetAsync(uri);
            var content = await respose.Content.ReadAsStringAsync();
            return content;
        }
    }
}
