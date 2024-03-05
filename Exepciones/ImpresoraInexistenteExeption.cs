using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class ImpresoraInexistenteExeption : Exception
    {
        public ImpresoraInexistenteExeption() : base("impresora no encontrada")
        {

        }
    }
}
