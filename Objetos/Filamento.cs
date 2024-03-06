using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Filamento
    {
        public int precio;
        public string tipo;
        public Filamento(int precio, string tipo) 
        {
            this.precio = precio;
            this.tipo = tipo;
        }
    }
}
