using Microsoft.Extensions.Configuration;
using Services.Interfaces;

namespace Services.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> Delete<T>(string url, int Id)
        {
            var response = await _httpClient.DeleteAsync($"{url}/{Id}");
            var result = await response.Content.ReadAsAsync<T>();
            return result;
        }

        public async Task<T> Get<T>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsAsync<T>();
            return result;
        }

        public async Task<T> Get<T>(string url, int Id)
        {
            var response = await _httpClient.GetAsync($"{url}/{Id}");
            var result = await response.Content.ReadAsAsync<T>();
            return result;
        }

        public async Task<T> Post<T>(string url, T obj)
        {
            var response = await _httpClient.PostAsJsonAsync(url, obj);
            var result = await response.Content.ReadAsAsync<T>();
            return result;
        }

        public async Task<T> Put<T>(string url, T obj)
        {
            var response = await _httpClient.PutAsJsonAsync(url, obj);
            var result = await response.Content.ReadAsAsync<T>();
            return result;
        }
    }
}
