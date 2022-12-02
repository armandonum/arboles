using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles_binarios
{
    class NodoABB
    {
        public string dato { get; set; }
        public NodoABB izquierdo { get; set; }
        public NodoABB derecho { get; set; }

        public NodoABB(string dato)
        {
            this.dato = dato;
            this.izquierdo = null;
            this.derecho = null;
        }
    }
}
