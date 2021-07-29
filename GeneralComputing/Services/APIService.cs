using System;

namespace GeneralComputing.Services
{
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    internal class APIService
    {
        private static HttpClient _client;

        public APIService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://windows-utillity-app-default-rtdb.europe-west1.firebasedatabase.app/")
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> SendAsync<T>(HttpRequestMessage requestMessage)
        {
            try
            {
                HttpResponseMessage response = await _client.SendAsync(requestMessage);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var model = JsonConvert.DeserializeObject<T>(content);
                    return model;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return default(T);
        }
    }
}