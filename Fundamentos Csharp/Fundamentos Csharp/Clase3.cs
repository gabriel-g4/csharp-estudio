using Fundamentos_Csharp.Models;

namespace Fundamentos_Csharp
{
    internal class Clase3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase 3!\n");
            Console.WriteLine("Arrays y listas");

            int[] array = new int[10] { 1, 2, 3, 4, 54, 6, 3, 1, 2, 3 };
            array =  [1, 2, 3, 4, 54, 6, 3, 1, 2, 3 ];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Foreach");
            foreach (var numero in array)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Listas");

            List<int> list = new List<int>() {1,2,3,4,5,6,7,8 };
            list.Add(9);
            list.Add(10);
            list.Remove(2);
            foreach (var numero in list)
            {
                Console.WriteLine(numero);
            }


            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza("Premium") };

            cervezas.Add(new Cerveza("Chingona"));

            Cerveza erdinger = new Cerveza("Cerveza de trigo", 1000);

            cervezas.Add(erdinger);

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }



        }
    }
}