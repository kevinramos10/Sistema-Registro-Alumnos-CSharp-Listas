using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Padres
    {
        public int DNI, Nro;
        public string Codigo, Nombres, Apaterno, Amaterno;

        public Padres(string codigo, int dni, string nombres, string apaterno, string amaterno, int nro)
        {
            this.Codigo = codigo;
            this.DNI = dni;
            this.Nombres = nombres;
            this.Apaterno = apaterno;
            this.Amaterno = amaterno;
            this.Nro = nro;
        }
    }
}
