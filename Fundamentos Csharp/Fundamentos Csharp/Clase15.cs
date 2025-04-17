using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    static internal class Clase15
    {
        // static bool DivisiblePor2(int x) => x % 2 == 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Clase 15");
            Console.WriteLine("Predicate\n");


            // Es como un delegado de condiciones.
            // Permitiría, por ejemplo, tener una lista de condiciones que algo tiene que cumplir.
            // También se podría aplicar en una función que si algo cumple X condición haga otra cosa,
            // pero que esta función se desligue de la lógica de la condición, solo la reciba. 


            // con la firma declarada
            // var predicado = new Predicate<int>(DivisiblePor2);

            // con lambda o función anónima, si se va a usar una o pocas veces
            var predicado = new Predicate<int>(x => x % 2 == 0);


            List<int> numbers = new List<int> { 32, 2, 5, 6, 2, 1, 6, 65, 1, 345, 7, 1 };

            Predicate<int> predicadoNegativo = (x => !predicado(x));

            var result = numbers.FindAll(predicadoNegativo);

            result.ForEach(Console.WriteLine);

            Console.WriteLine("---------------------------------------------");


            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza() {Nombre = "Ipa", Alcohol = 7},
                new Cerveza() {Nombre = "Pale ale", Alcohol = 8},
                new Cerveza() {Nombre = "Stout", Alcohol = 9},
                new Cerveza() {Nombre = "Tripel", Alcohol = 15}

            };

            // sin extension
            CervezasAltasEnAlcohol(cervezas, x => x.Alcohol > 10);

            // con extension
            cervezas.CervezasAltasEnAlcohol(x => x.Alcohol > 10);

        }

        static void CervezasAltasEnAlcohol(this List<Cerveza> cervezas, Predicate<Cerveza> condicion)
        {
            var altas = cervezas.FindAll(condicion);
            altas.ForEach(x => Console.WriteLine(x.Nombre + " " + x.Alcohol));
        }
    }
}
