using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Alumnos
    {
        public string Codigo;
        public string Nombres, Apaterno, Amaterno;
        public double N1, N2, N3, N4, Promedio;

        public Alumnos(string codigo, string nombres, string apaterno, string amaterno, double n1, double n2, double n3, double n4)
        {
            this.Codigo = codigo;
            this.Nombres = nombres;
            this.Apaterno = apaterno;
            this.Amaterno = amaterno;
            this.N1 = n1;
            this.N2 = n2;
            this.N3 = n3;
            this.N4 = n4;
        }
        public double promedio()
        {
            Promedio = (N1 + N2 + N3 + N4) / 4;
            return Promedio;
        }
        public String final()
        {
            string f = "";
            if(Promedio < 11.50)
            {
                f = "Desaprobado";
            }
            else if (Promedio >= 11.50)
            {
                f = "Aprobado";
            }

            return f;
        }

    }
}
