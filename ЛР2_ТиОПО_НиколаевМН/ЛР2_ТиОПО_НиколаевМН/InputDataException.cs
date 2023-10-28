using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2_ТиОПО_НиколаевМН
{
    internal class InputDataException : Exception
    {
        public InputDataException(string message) : base(message) { }
    }
}
