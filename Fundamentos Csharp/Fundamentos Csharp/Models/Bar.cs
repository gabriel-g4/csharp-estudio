using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class Bar
    {
        public string Nombre { get; set; }
        public List<Cerveza> Cervezas { get; set; } = new();


        public Bar(string nombre)
        {
            Nombre = nombre;
        }
    }
}
