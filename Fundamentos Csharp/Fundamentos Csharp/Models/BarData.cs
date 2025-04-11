using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class BarData
    {

        public string Nombre { get; set; }

        public List<Bebida> Bebidas { get; set; } = new();


        public BarData(string Nombre)
        {
            this.Nombre = Nombre;
        }
        
    }
}
