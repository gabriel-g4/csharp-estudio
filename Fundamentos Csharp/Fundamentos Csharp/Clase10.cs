using Fundamentos_Csharp.Models;
using Fundamentos_Csharp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    internal class Clase10
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Clase 10");
            Console.WriteLine("Generics\n");


            // Funciona para cerveza

            Cerveza cerveza = new Cerveza("Iguana", 100);
            SendRequest<Cerveza> cervezaSender = new SendRequest<Cerveza>();
            var result = await cervezaSender.Send(cerveza);


            Console.WriteLine($"Tipo: {result}\n" +
                $"Id que retornó método POST: {result.Id}");


            // Funciona para post

            Post post = new Post()
            {
                Id = 1000,
                UserId = 100,
                Title = "Soy un titulo generico",
                Body = "Soy un cuerpo generico"
            };
            SendRequest<Post> postSender = new SendRequest<Post>();

            Post postResult = await postSender.Send(post);


            Console.WriteLine($"Tipo: {postResult}\n" +
                $"Id que retornó método POST: {postResult.Id}");


        }
    }
}
