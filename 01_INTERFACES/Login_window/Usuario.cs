using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_window
{
    class Usuario
    {
        // Atributos
        public string username;

        // Propiedades
        public string Username
        {
            get { return username; }
            set { username = value.ToLower(); }
        }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public byte Edad { get; set; }

        // Constructores sobrecargados
        public Usuario(string nombreUsuario, string contra, string nombre, byte edad)
        {
            Username = nombreUsuario;
            Contrasena = contra;
            Nombre = nombre;
            Edad = edad;
        }
        public Usuario(string nombreUsuario, string contra, string nombre) : this(nombreUsuario, contra, nombre, 0) { }
        public Usuario(string nombreUsuario, string contra) : this(nombreUsuario, contra, "Usuario", 0) { }


    }
}
