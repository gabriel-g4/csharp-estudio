using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    internal class Clase8
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Clase 8!");
            Console.WriteLine("Conexión HTTP Método GET");

            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Post> posts = JsonSerializer.Deserialize<List<Post>>(content,
                 new JsonSerializerOptions()
                 {
                     PropertyNameCaseInsensitive = true
                 });
                
                foreach(var post in posts)
                {
                    Console.WriteLine($"{post.Id} - {post.Title} - {post.Body}");
                }

            }
        }
    }
}
