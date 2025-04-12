using Fundamentos_Csharp.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class BuscadorCervezas
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza { Nombre = "Corona Extra", Marca = "Grupo Modelo", Alcohol = 4, Cantidad = 355 },
            new Cerveza { Nombre = "Heineken", Marca = "Heineken", Alcohol = 5, Cantidad = 330 },
            new Cerveza { Nombre = "Quilmes", Marca = "Quilmes", Alcohol = 4, Cantidad = 473 }
        };

        public int GetCantidad(string nombre)
        {

            var cerveza = (from c in cervezas
                           where c.Nombre == nombre
                           select c).FirstOrDefault(); // Si usamos First() y no encuentra, directamente tira una excepción
                                                       // y no es la que quiero usar.

            if (cerveza == null)
            {
                throw new CervezaNoEncontradaException("Se acabó esta cerveza");
            }
            return cerveza.Cantidad;
        }
    }
}
