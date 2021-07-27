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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_administrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Ingrese su usuario Administrador..!!");
            new Login().ShowDialog();
            this.Close();
        }

        private void btn_trabajador_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Ingrese su usuario Trabajador..!!");
            new LonginT().ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_fechahora.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_fechahora.Text = DateTime.Now.ToString();
        }
    }
}
