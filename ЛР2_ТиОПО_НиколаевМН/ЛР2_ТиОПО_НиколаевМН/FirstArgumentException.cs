using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2_ТиОПО_НиколаевМН
{
    internal class FirstArgumentException : Exception
    {
        public FirstArgumentException(string message) : base(message) { }
    }
}
