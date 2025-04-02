using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public Vino() : base("Vino", 500)
        {

        }

        public Vino(string nombre, int cantidad = 5000) : base(nombre, cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado es 3 copas.");
        }
    }
}
