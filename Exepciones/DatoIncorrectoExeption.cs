using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class DatoIncorrectoExeption : Exception
    {
        public DatoIncorrectoExeption(string campo,string tipo) : base($"el campo {campo} debe ser de tipo {tipo}")
        {
        }
    }
}
