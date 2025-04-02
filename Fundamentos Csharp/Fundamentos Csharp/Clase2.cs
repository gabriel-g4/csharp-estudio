using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fundamentos_Csharp.Models;

namespace Fundamentos_Csharp
{
    internal class Clase2
    {
        public static void Clase()
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Clase 2\n");
            Console.WriteLine("Clases y objetos");

            Bebida bebida = new Bebida("Pepsi", 1000);

            bebida.Beberse(599);

            Console.WriteLine(bebida.Nombre);
            Console.WriteLine(bebida.Cantidad);

            Cerveza cerveza = new Cerveza();

            cerveza.Beberse(300);

            Console.WriteLine(cerveza.Nombre);
            Console.WriteLine(cerveza.Cantidad);


            Cerveza cerveza2 = new Cerveza("lager");

            cerveza2.Beberse(300);

            Console.WriteLine(cerveza2.Nombre);
            Console.WriteLine(cerveza2.Cantidad);


        }

    }
}
