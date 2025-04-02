namespace Fundamentos_Csharp
{
    internal class Clase1
    {
        public static void Clase()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Clase 1");
            Console.WriteLine("Tipos de datos");

            byte numero = 255;
            sbyte signed = 127;

            int entero = 20000000;
            uint enteroMasGrande = 40000000;

            float flotante = 10.2f;
            double doble = 3000.00d;
            decimal decimales = 100000.000m;


            char caracter = 'a';
            string cadena = "Cadenon";

            DateTime date = DateTime.Now;

            bool booleano = true;

            int queValor;

            int? nullable = null;

            var apellido = "Jo";
            apellido = "Bo";

            var persona =  new { tipo = "objeto Anonimo", apellido = apellido, edad = 12 };

            Console.WriteLine($"byte {numero}, signed byte {signed}");
            Console.WriteLine($"entero {entero}, entero sin signo {enteroMasGrande}");
            Console.WriteLine($"flotante 4b {flotante}, double 8b {doble}, decimal 16b {decimales}");
            Console.WriteLine($"caracter {caracter}, cadena {cadena}");
            Console.WriteLine($"fecha {date}");
            Console.WriteLine($"boleano {booleano}");
            Console.WriteLine($"Nullable {nullable}");
            Console.WriteLine($"Apellido {apellido}");
            Console.WriteLine($"Persona {persona}");


        }
    }
}
