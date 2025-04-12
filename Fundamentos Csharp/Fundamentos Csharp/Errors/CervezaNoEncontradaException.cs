using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Errors
{
    internal class CervezaNoEncontradaException : Exception
    {
        public CervezaNoEncontradaException() : base() { }
        public CervezaNoEncontradaException(string message) : base(message) { }
        public CervezaNoEncontradaException(string message, Exception innerException) : base(message, innerException) { }
    }
}
