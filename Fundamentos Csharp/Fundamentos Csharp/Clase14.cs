using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    internal class Clase14
    {
        // delegate int Mostrar(string mensaje);
        internal static void Clase()
        {
            Console.WriteLine("Clase 14");
            Console.WriteLine("Delegados, Func, Action\n");


            // Con delegado:
            // Mostrar mostrar = Show;

            // Con Func
            //Func<string, int> mostrar = Show;

            // Action es como Func, pero sin retorno
            // Action<string, string> mostrar = Show;

            // Ejemplo con función anónima
            Action<string, string> mostrar = (a, b) => { Console.WriteLine(a + b); };


            HacerAlgo(mostrar);



        }

        static void HacerAlgo(Action<string, string> funcion)
        {
            Console.WriteLine("Hacer Algo");
            funcion("Se envio desde otra funcion", " parametro 2");
            Console.WriteLine("Hacer otra cosa");
        }

        //public static int Show(string mensaje)
        //{
        //    return mensaje.Length;
        //}

        //public static void Show(string mensaje, string mensaje2)
        //{
        //    Console.WriteLine(mensaje + mensaje2);
        //}
    }
}
