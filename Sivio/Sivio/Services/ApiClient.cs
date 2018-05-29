using Newtonsoft.Json;
using Sivio.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sivio.Services
{
    class ApiClient
    {
        private string Url = "https://my-json-server.typicode.com/andreld/APISivio/obras";

        public async Task<List<ObrasModel>> GetObras()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var obras = JsonConvert.DeserializeObject<List<ObrasModel>>(json);

            return obras;
        }
    }
}
