using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class LonginT : Form
    {
        public void limpiar()
        {
            txt_contraseña.Text = txt_usuario.Text = "";
        }
        public void logeo(string usu, string psswd)
        {
            string nombre = txt_usuario.Text;
            string contra = txt_contraseña.Text; if (nombre == "Kenny" && contra == "12345")
            {
                MessageBox.Show("Bienvenido Trabajor \n" + nombre); this.Hide();
                new Administrador().ShowDialog();
                this.Close();
            }
            //*// else if (nombre == "Kenny" && contra == "12345")
            // {
            //     MessageBox.Show("Bienvenido ADMINISTRADOR \n" + nombre); this.Hide();
            //     new Administrador().ShowDialog();
            //     this.Close();
            // }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }
        public LonginT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text))
            {
                MessageBox.Show("Hay campos vacios...!!!");

            }
            else
            {
                logeo(txt_usuario.Text, txt_contraseña.Text);
                limpiar();
            }
        }
    }
}
