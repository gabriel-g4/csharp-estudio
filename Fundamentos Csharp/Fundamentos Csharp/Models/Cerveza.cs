using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica, IRequestable
    {
        public int Alcohol { get; set; }

        public string Marca { get; set; }

        public int Id { get; set; }

        public string Nombre { get; set; }
        public Cerveza () : base ("Cerveza", 500)
        {

        }

        public Cerveza(string nombre, int cantidad = 5000) : base(nombre, cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado es 10 cervezas");
        }
    }
}
