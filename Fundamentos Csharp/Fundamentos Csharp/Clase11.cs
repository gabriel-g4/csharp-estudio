using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Fundamentos_Csharp.Models;

namespace Fundamentos_Csharp
{
    internal class Clase11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase 11");
            Console.WriteLine("LINQ\n");

            List<int> list = new List<int>() { 1, 7, 55, 3, 2, 3, 46, 7, 9 };

            // Filtrar por valor con funciones Lambda

            var numeroElegido = list.Where(x => x == 7).FirstOrDefault();
            // var numeroElegido = list.Where(x => x == 900).FirstOrDefault();

            Console.WriteLine(numeroElegido);


            // Ordenar por valor

            var listaOrdenada = list.OrderBy(x => x);

            foreach (var numero in listaOrdenada)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine();

            // Funciones de agregado, como sumar

            var sumaTotal = list.Sum(x => x);

            Console.WriteLine(sumaTotal);

            var promedio = list.Average(x => x);

            Console.WriteLine(promedio);


            ////////////////////////////////////
            ////////////////////////////////////

            // Uso de declaraciones tipo SQL con LINQ

            List<Cerveza> cervezas = new List<Cerveza>
            {
                new Cerveza { Nombre = "Corona Extra", Marca = "Grupo Modelo", Alcohol = 4, Cantidad = 355 },
                new Cerveza { Nombre = "Heineken", Marca = "Heineken", Alcohol = 5, Cantidad = 330 },
                new Cerveza { Nombre = "Quilmes", Marca = "Quilmes", Alcohol = 4, Cantidad = 473 },
                new Cerveza { Nombre = "Stella Artois", Marca = "AB InBev", Alcohol = 5, Cantidad = 330 }
            };

            var cervezasOrdenadas = from c in cervezas
                                    where c.Nombre == c.Marca && c.Nombre == "Heineken"
                                    orderby c.Marca
                                    select c;

            foreach (var c in cervezasOrdenadas)
            {
                Console.WriteLine($"{c.Nombre} - {c.Marca}");
            }
        }
    }
}
