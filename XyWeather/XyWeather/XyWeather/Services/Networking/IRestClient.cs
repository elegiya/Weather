using System;
using System.Threading.Tasks;

namespace XyWeather.Services.Networking
{
    public interface IRestClient
    {
        Task<string> GetAsync(string uri);
    }

}

