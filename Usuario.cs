using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Integrador
{
    internal class Usuario


    {

        //Atributo
        private string Nombre;
        private DateTime FechaNacimiento;
        private string Correo;
        private int Telefono;
        private string Contraseña;
        private string imagen;

   


        //Encapsulamiento
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public DateTime _FechaNacimiento { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string _Correo { get => Correo; set => Correo = value; }
        public int _Telefono { get => Telefono; set => Telefono = value; }
        public string _Contraseña { get => Contraseña; set => Contraseña = value; }
        public string _Imagen { get => imagen; set => imagen = value; }


        //Constructores
     public Usuario(string nombre, DateTime fechaNacimiento, string correo, int telefono, string contraseña, string imagen)
        {
            _Nombre = nombre;
            _FechaNacimiento = fechaNacimiento;
            _Correo = correo;
            _Telefono = telefono;
            _Contraseña = contraseña;
            _Imagen = imagen;
        }

        public Usuario()
        {
        }


        //Metodos



    }
}
