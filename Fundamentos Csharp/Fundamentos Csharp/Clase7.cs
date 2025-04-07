using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fundamentos_Csharp
{
    internal class Clase7
    {
        internal static void Clase()
        {
            Console.WriteLine("Clase 7!");
            Console.WriteLine("Serialización y Deserialización con JSON\n");

            // Serialización.
            { 
                Cerveza cerveza = new Cerveza("Ipa", 100);
                string miJson = JsonSerializer.Serialize(cerveza);
                File.WriteAllText("archivo.txt", miJson);
            }

            // Deserialización 

            {
                string miJson = File.ReadAllText("archivo.txt");
                Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);
                Console.WriteLine($"{cerveza.Nombre} - {cerveza.Cantidad}");
            }
        }
    }
}
