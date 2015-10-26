using System.Net.Http;
using System.Threading.Tasks;

namespace XyWeather.Services.Networking
{
    /// <summary>
    /// Service for getting data on server side.
    /// </summary>
    public class RestClient : IRestClient
    {
        /// <summary>
        /// All content from server about the weather.
        /// </summary>
        /// <param name="uri">Link to get a data.</param>
        /// <returns>Row server data.</returns>
        public async Task<string> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
