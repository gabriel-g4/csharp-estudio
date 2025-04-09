using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Service
{
    public class SendRequest<T>() where T : IRequestable
    {
        private HttpClient httpClient = new HttpClient();

        public async Task<T> Send(T obj)
        {

            string url = "https://jsonplaceholder.typicode.com/posts";


            string data = JsonSerializer.Serialize<T>(obj, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<T>(result, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

                return postResult;
            }

            return default(T);
        }
    }
}
