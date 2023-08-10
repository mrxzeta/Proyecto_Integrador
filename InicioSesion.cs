using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void jbuton2_Click(object sender, EventArgs e)
        {

        }

        private void btbIniciarSesion_Click(object sender, EventArgs e)
        {
            TextReader inicio = new StreamReader(txtCorreo.Text + ".txt");
            try
            {
                if (inicio.ReadLine() == txtContrasena.Text)
                {
                    MessageBox.Show("Se inicio sesion");

                }
                else
                {
                    MessageBox.Show("Hubo un error al iniciar sesion");
                }
            }
            catch (Exception z) { MessageBox.Show("Hubo un error" + z, "Error"); }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();

        }
    }
    }

