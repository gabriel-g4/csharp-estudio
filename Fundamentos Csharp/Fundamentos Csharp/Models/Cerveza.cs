using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class Cerveza : Bebida
    {
        public Cerveza () : base ("Cerveza", 500)
        {

        }

        public Cerveza(string nombre, int cantidad = 5000) : base(nombre, cantidad)
        {

        }
    }
}
