using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class NodoP
    {
        public Padres dato;
        public NodoP siguiente;

        public NodoP(Padres dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}
