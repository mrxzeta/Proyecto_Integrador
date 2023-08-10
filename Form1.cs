using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch; //Se ajusta la iamgen al tamaño de la pnatalla
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jbuton1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
           
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
          
        }
    }
}
