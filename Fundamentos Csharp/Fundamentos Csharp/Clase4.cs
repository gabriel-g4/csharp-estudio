using Fundamentos_Csharp.Models;

namespace Fundamentos_Csharp
{
    class Clase4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Clase 4");
            Console.WriteLine("Interfaces");

            var bebida = new Vino();
            MostrarRecomendacion(bebida);

            var refrigerio = new Cerveza();
            MostrarRecomendacion(refrigerio);

        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}