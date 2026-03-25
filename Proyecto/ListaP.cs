using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    class ListaP
    {
        public NodoP ini, fin;
        public ListaP()
        {
            ini = fin = null;
        }
        public void insertar(Padres dato)
        {
            //Nodo huerfano
            NodoP aux = new NodoP(dato);

            if (ini == null)
            {
                ini = fin = aux;
            }
            else
            {
                fin.siguiente = aux;
                fin = aux;
            }
        }

        public void imprimirDGV(DataGridView dgv)
        {
            dgv.Rows.Clear();

            NodoP p = ini;

            while (p != null)
            {
                dgv.Rows.Add(p.dato.Codigo,
                    p.dato.DNI,
                    p.dato.Nombres,
                    p.dato.Apaterno,
                    p.dato.Amaterno,
                    p.dato.Nro
                    );
                p = p.siguiente; //permite recorrer secuencialmente la lista
            }
        }

        public string DatosNombre()
        {
            NodoP D = ini;
            string nom = "";

            while (D != null)
            {
                nom = D.dato.Nombres;
                D = D.siguiente;
                return nom;
            }
            return nom;
        }

        public void eliminarF()
        {
            if (ini != null)
            {
                if (ini == fin) //cuando es un solo elemento
                {
                    ini = fin = null;
                }
                else
                {
                    NodoP p, ant;
                    p = ant = ini;

                    while (p.siguiente != null)
                    {
                        ant = p;
                        p = p.siguiente;
                    }
                    ant.siguiente = null;
                    fin = ant;

                }

            }
        }
        public bool modificar(Padres dato)
        {
            bool rpta = false;
            for (NodoP p = ini; p != null; p = p.siguiente)
                if (p.dato.Codigo == dato.Codigo)
                {
                    p.dato = dato;
                    rpta = true;
                }
            return rpta;
        }
        public Padres buscarxCodigo(String codigo)
        {
            NodoP p = ini;

            //para recorrer secuencialmente nuestra LES
            while (p != null)
            {
                if (p.dato.Codigo == codigo) return p.dato;
                p = p.siguiente;
            }

            return null;
        }

    }
}
