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
    public partial class FrMenú : Form
    {
        ListaA lis = new ListaA();
        public FrMenú()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrAlumnos datss = new FrAlumnos();
            datss.Visible = true;
            this.Hide();

            string nom;
            nom = lis.DatosNombre();

        }

        private void btnRPadres_Click(object sender, EventArgs e)
        {
            FrPadres datss = new FrPadres();
            datss.Visible = true;
            this.Hide();
        }

        private void btnRhijos_Click(object sender, EventArgs e)
        {
            FrAlumnos datss = new FrAlumnos();
            datss.Visible = true;
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrLogin datss = new FrLogin();
            datss.Visible = true;
            this.Hide();
        }
    }
}
