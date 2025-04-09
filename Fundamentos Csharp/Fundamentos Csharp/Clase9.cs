using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    internal class Clase9
    {
        static async Task Clase()
        {
            Console.WriteLine("Clase 9");
            Console.WriteLine("POST, PUT, DELETE\n");

            // POST
            string url = "https://jsonplaceholder.typicode.com/posts";

            // PUT
            // string url = "https://jsonplaceholder.typicode.com/posts/{id}";

            // DELETE
            // string url = "https://jsonplaceholder.typicode.com/posts/{id}";

            HttpClient httpClient = new HttpClient();

            Post post = new Post()
            {
                UserId = 10,
                Title = "Soy un tituloo",
                Body = "El cuerpo del mensaje"
            };

            string data = JsonSerializer.Serialize<Post>(post, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive= true
            });

            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

            // POST
            var response = await httpClient.PostAsync(url, content);

            // PUT
            // var response = await httpClient.PutAsync(url, content);

            // DELETE
            // var response = await httpClient.DeleteAsync(url);


            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();

                // Porción de código innecesaria en DELETE

                var postResult = JsonSerializer.Deserialize<Post>(result, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

                Console.WriteLine($"{postResult.Id} {postResult.UserId} {postResult.Title} {postResult.Body}");
            }
        }
    }
}
