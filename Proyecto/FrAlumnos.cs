using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrAlumnos : Form
    {
        ListaA milistaA = new ListaA();

        public FrAlumnos()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string cdg, nombres, apaterno, amaterno;
            double n1, n2, n3, n4;
            try
            {
                cdg = txtCodigo.Text;
                nombres = txtNombres.Text;
                apaterno = txtApaterno.Text;
                amaterno = txtAmaterno.Text;
                n1 = double.Parse(txtNota1.Text);
                n2 = double.Parse(txtNota2.Text);
                n3 = double.Parse(txtNota3.Text);
                n4 = double.Parse(txtNota4.Text);

                milistaA.insertar(new Alumnos(cdg, nombres, apaterno, amaterno, n1, n2, n3, n4));
                milistaA.imprimirDGV(dtgvAlumnos);
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos!!");
            }
        }

        private void btnRmenu_Click(object sender, EventArgs e)
        {
            FrMenú datss = new FrMenú();
            datss.Visible = true;
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrLogin datss = new FrLogin();
            datss.Visible = true;
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            milistaA.eliminarF();
            milistaA.imprimirDGV(dtgvAlumnos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cdg, nombres, apaterno, amaterno;
            double n1, n2, n3, n4;

            cdg = txtCodigo.Text;
            nombres = txtNombres.Text;
            apaterno = txtApaterno.Text;
            amaterno = txtAmaterno.Text;
            n1 = double.Parse(txtNota1.Text);
            n2 = double.Parse(txtNota2.Text);
            n3 = double.Parse(txtNota3.Text);
            n4 = double.Parse(txtNota4.Text);

            milistaA.modificar(new Alumnos(cdg, nombres, apaterno, amaterno, n1, n2, n3, n4));

            //salida
            milistaA.imprimirDGV(dtgvAlumnos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigo;

            codigo = txtBuscar.Text;

            Alumnos encontrado = milistaA.buscarxCodigo(codigo);

            if (encontrado == null)
                MessageBox.Show("No se encontro al Alumno");
            else
                MessageBox.Show("Se encontro al Alumno: " + encontrado.Nombres +" "+ encontrado.Apaterno + " " + encontrado.Amaterno);
        }
    }
}
