using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2_ТиОПО_НиколаевМН
{
    internal class NegativeDiscriminantException : Exception
    {
        public NegativeDiscriminantException(string message) : base(message) { }
    }
}
