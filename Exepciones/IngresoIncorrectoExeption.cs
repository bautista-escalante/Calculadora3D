using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class IngresoIncorrectoExeption :Exception
    {
        public IngresoIncorrectoExeption(string ingrerso) : base($"{ingrerso} incorrecto")
        {

        }
    }
}
