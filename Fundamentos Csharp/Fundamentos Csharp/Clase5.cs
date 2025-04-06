using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    internal class Clase5
    {
        internal static void Clase()
        {
            Console.WriteLine("Clase 5!");
            Console.WriteLine("Conexion a BD y mostrar objetos!\n");


            CervezaBD cervezaBD = new CervezaBD();

            var listaCervezas = cervezaBD.Get();

            foreach (var cerveza in listaCervezas)
            {
                Console.WriteLine(cerveza.Nombre + " - " + cerveza.Marca);
            }
        }
    }
}
