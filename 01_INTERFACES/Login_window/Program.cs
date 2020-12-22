using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_window
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Instanciar arbol
            Arbol arbolUsuarios = new Arbol();
            CargarUsuarios(arbolUsuarios);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // METODOS ESTATICOS
        public static void CargarUsuarios(Arbol arbol)
        {
            Usuario user1 = new Usuario("A", "a");
            Usuario user2 = new Usuario("b", "a");
            Usuario user3 = new Usuario("c", "a");
            Usuario user4 = new Usuario("z", "a");
            Usuario user5 = new Usuario("e", "a");
            Usuario user6 = new Usuario("jaredait", "f");
            Usuario user7 = new Usuario("g", "a");
            Usuario user8 = new Usuario("dd", "a");
            Usuario user9 = new Usuario("dAd", "a");
            Usuario user10 = new Usuario("ded", "a");


            arbol.AddNodo(user4);
            arbol.AddNodo(user3);
            arbol.AddNodo(user2);
            arbol.AddNodo(user1);
            arbol.AddNodo(user5);
            arbol.AddNodo(user6);
            arbol.AddNodo(user7);
            arbol.AddNodo(user8);
            arbol.AddNodo(user9);
            arbol.AddNodo(user10);
        }
    }
}
