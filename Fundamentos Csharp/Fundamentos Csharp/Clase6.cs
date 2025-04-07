using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp
{
    internal class Clase6
    {
        internal static void Clase()
        {

            Console.WriteLine("Clase 6!");
            Console.WriteLine("CRUD Basico\n");

            // Instanciamos el controlador de la BD
            CervezaBD cervezaBD = new CervezaBD();

            // Creamos y añadimos entrada a la tabla ((CREATE))
            {
                Cerveza cerveza = new Cerveza("Indiana", 500);
                cerveza.Marca = "Salta";
                cerveza.Alcohol = 6;
                cervezaBD.Create(cerveza);
            }

            // Actualizamos el valor de una entrada de la tabla ((UPDATE))

            {
                Cerveza cerveza = new Cerveza("PPP", 1);
                cerveza.Marca = "Strong";
                cerveza.Alcohol = 10;
                cervezaBD.Update(cerveza, 12);
            }

            // Eliminamos una entrada de la tabla ((DELETE))

            {
                cervezaBD.Delete(13);
            }

            // Subimos a memoria los datos de la tabla ((READ))
            var listaCervezas = cervezaBD.Get();

            foreach (var cerveza in listaCervezas)
            {
                Console.WriteLine(cerveza.Nombre 
                    + " - " + cerveza.Marca
                    + " - " + cerveza.Alcohol
                    + " - " + cerveza.Cantidad);
            }

        }
    }
}
