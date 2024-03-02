using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class CampoVacioexeption : Exception 
    {
        public string campo {  get; set; }
        public CampoVacioexeption(string campo=""):base($"campo {campo} vacio") 
        {
            this.campo = campo;
        }
    }
}
