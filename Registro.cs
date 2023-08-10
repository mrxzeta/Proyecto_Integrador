using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_Integrador
{
    public partial class Registro : Form
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""|DataDirectory|\Base RoomRent.accdb""");
        OleDbCommand cmd = new OleDbCommand();

        public Registro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jbuton1_Click(object sender, EventArgs e)
        {
            int i= 0;
            conexion.Open();
            
            Usuario user = new Usuario
            {
                _Nombre = txtNombreRegistro.Text,
                _FechaNacimiento = FechaNacimiento.Value,
                _Correo = txtCorreoRegistro.Text,
                _Contraseña = txtContrasenaRegistro.Text,                                       
                //_Telefono = txtTelefono.DataBindings.ToString(),
                //_Imagen =
            };
           cmd.Connection = conexion;
            cmd.CommandText = "INSERT INTO BaseRegistro(Nombre, Fecha de Nacimiento, Correo,Contraseña ) VALUES (@nombre, @fechanacimiento, @correo, @contraseña, )";
           

            cmd.Parameters.AddWithValue("@nombre", user._Nombre);
            cmd.Parameters.AddWithValue("@fechanacimiento", user._FechaNacimiento);
            cmd.Parameters.AddWithValue("@correo", user._Correo);
            cmd.Parameters.AddWithValue("@contraseña", user._Contraseña);
            i = cmd.ExecuteNonQuery();
        }
    }
}
