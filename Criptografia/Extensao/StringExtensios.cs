using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Extensao
{
    public static class StringExtensios
    {
        public static byte[] ObterStringEmBytes(this string texto)
        {
            return Encoding.UTF8.GetBytes(texto);
        }
    }
}
