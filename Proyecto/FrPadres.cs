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
    public partial class FrPadres : Form
    {
        ListaP milistaP = new ListaP();
        public FrPadres()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int dni, nro;
            string cdg, nombre, apaterno, amaterno;

            try
            {
                cdg = txtCodigo.Text;
                dni = int.Parse(txtDNI.Text);
                nombre = txtNombres.Text;
                apaterno = txtApaterno.Text;
                amaterno = txtAmaterno.Text;
                nro = int.Parse(txtNro.Text);

                milistaP.insertar(new Padres(cdg, dni, nombre, apaterno, amaterno, nro));
                milistaP.imprimirDGV(dtgvPadres);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int dni, nro;
            string cdg, nombre, apaterno, amaterno;

            cdg = txtCodigo.Text;
            dni = int.Parse(txtDNI.Text);
            nombre = txtNombres.Text;
            apaterno = txtApaterno.Text;
            amaterno = txtAmaterno.Text;
            nro = int.Parse(txtNro.Text);

            milistaP.modificar(new Padres(cdg, dni, nombre, apaterno, amaterno, nro));

            milistaP.imprimirDGV(dtgvPadres);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigo;

            codigo = txtBuscar.Text;

            Padres encontrado = milistaP.buscarxCodigo(codigo);

            if (encontrado == null)
                MessageBox.Show("No se encontro ningun Apoderado con ese codigo");
            else
                MessageBox.Show("Se encontro al Apoderado: " + encontrado.Nombres + " " + encontrado.Apaterno + " " + encontrado.Amaterno);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            milistaP.eliminarF();
            milistaP.imprimirDGV(dtgvPadres);
        }
    }
}
