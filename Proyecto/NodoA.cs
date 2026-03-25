using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class NodoA
    {
        public Alumnos dato;
        public NodoA siguiente;

        public NodoA(Alumnos dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}
