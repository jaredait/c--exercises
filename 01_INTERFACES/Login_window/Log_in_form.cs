using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_window; // Para acceder a las variables y metodos de la solucion

namespace Login_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Boton iniciar sesion. Validacion del nombre de usuario y contrasena
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            Arbol arbolCargado = new Arbol();
            Usuario temp = null;
            Program.CargarUsuarios(arbolCargado);

            // Si es que el nombre de usuario se encuentra en el arbol se procede a verificar la contraseña, esta debe corresponder con la contrasena
            // del objeto Usuario.
            if (arbolCargado.Existe(txt_username.Text))
            {
                temp = arbolCargado.GetUsuario(txt_username.Text);
                if (txt_username.Text == temp.Username && txt_password.Text == temp.Contrasena)
                {
                    Search_form searchWindow = new Search_form();
                    this.Hide();
                    searchWindow.Show();
                }
                else
                {
                    MessageBox.Show("The username or password are incorrect");
                    txt_username.Text = string.Empty;
                    txt_password.Text = string.Empty;
                    txt_username.Focus();
                }
            }
            else
            {
                MessageBox.Show("The username or password are incorrect");
                txt_username.Text = string.Empty;
                txt_password.Text = string.Empty;
                txt_username.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
