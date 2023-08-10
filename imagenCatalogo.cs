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
    public partial class imagenCatalogo : UserControl
    {

        private string titulo;


        public string Titulo
        {
            get { return lbtitulo.Text; }
            set { lbtitulo.Text = value; } 
        }

        public Image Imagen
        { get { return pictureBox1.Image; }
            set {pictureBox1.Image = value; }            
        }


        public imagenCatalogo()
        {
            InitializeComponent();
        }

        private void imagenCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
