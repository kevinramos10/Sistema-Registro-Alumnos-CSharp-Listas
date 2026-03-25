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
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usurio = "SApro";
            String Clave = "sa589"; 
            
            try
            {
                if (txtUsuario.Text == usurio && txtContraseña.Text == Clave)
                {
                    MessageBox.Show("Bienvenido al registro.");
                    FrMenú men = new FrMenú();
                    men.Visible = true;
                    //this.Dispose(); para cerrar
                    //dats.ShowDialog(); para no tocar
                    //this.Close(); para cerrar
                    this.Hide();
                }
                else if (txtUsuario.Text != usurio)
                {
                    MessageBox.Show("Usuario incorrecto !!!");
                }
                else if (txtContraseña.Text != Clave)
                {
                    MessageBox.Show("Contraseña incorrecta !!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos!!");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
