using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    internal class Clase12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase 12");
            Console.WriteLine("LINQ con objetos avanzados\n");

            List<Bar> bares = new List<Bar>()
            {
                new Bar("El bar")
                {
                    Cervezas =
                    {
                        new Cerveza { Nombre = "Corona Extra", Marca = "Grupo Modelo", Alcohol = 4, Cantidad = 355 },
                        new Cerveza { Nombre = "Heineken", Marca = "Heineken", Alcohol = 5, Cantidad = 330 },
                        new Cerveza { Nombre = "Quilmes", Marca = "Quilmes", Alcohol = 4, Cantidad = 473 }
                    }
                },
                new Bar("El bar 2")
                {
                    Cervezas =
                    {
                        new Cerveza { Nombre = "Quilmes", Marca = "Quilmes", Alcohol = 4, Cantidad = 473 },
                        new Cerveza { Nombre = "Stella Artois", Marca = "AB InBev", Alcohol = 5, Cantidad = 330 }
                    }
                },
                new Bar("El nuevo")
            };


            // Búsqueda compleja

            var baresEspeciales = from bar in bares
                              where bar.Cervezas.Where(c => c.Nombre == "Heineken").Count() > 0 // retorna 1 bar
                              // where bar.cervezas.Where(c => c.Nombre == "Quilmes").Count() > 0 // retorna los 2
                              select bar;

            string baresJson = JsonSerializer.Serialize<List<Bar>>(bares);
            Console.WriteLine(baresJson);

            
            Console.WriteLine("\n\n\n");


            // Misma búsqueda pero solo seleccionando los valores que nos interesan (Nombre y Cantidad)
            // usando clase auxiliar BarData.

            var baresDatos = (from bar in bares
                             where bar.Cervezas.Where(c => c.Nombre == "Heineken").Count() > 0
                             select new BarData(bar.Nombre)
                             {
                                 Bebidas = (from c in bar.Cervezas
                                            select new Bebida(c.Nombre, c.Cantidad)).ToList()
                             }).ToList();


            string baresDatosJSON = JsonSerializer.Serialize<List<BarData>>(baresDatos, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            Console.WriteLine(baresDatosJSON);


        }
    }
}
