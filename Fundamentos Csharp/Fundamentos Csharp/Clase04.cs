using Fundamentos_Csharp.Models;

namespace Fundamentos_Csharp
{
    class Clase04
    {
        internal static void Clase()
        {
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