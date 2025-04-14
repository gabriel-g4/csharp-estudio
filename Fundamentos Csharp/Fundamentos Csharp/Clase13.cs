using Fundamentos_Csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Fundamentos_Csharp.Errors;

namespace Fundamentos_Csharp
{
    internal class Clase13
    {
        public static void Clase()
        {
            Console.WriteLine("Clase 13");
            Console.WriteLine("Excepciones\n");


            try
            {
                BuscadorCervezas buscador = new BuscadorCervezas();
                
                Console.WriteLine(buscador.GetCantidad("Heineken"));
            }
            catch (CervezaNoEncontradaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);

                // Acá puede ir código de corrección, mandar aviso de error, etc.
            }
            catch (InvalidOperationException e)
            {
                
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepción generica");
            }
            finally
            {
                Console.WriteLine("Esto siempre se ejecuta");
            }
        }
    }
}
