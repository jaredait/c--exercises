using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_window
{
    class Nodo
    {
        // Propiedades
        public Usuario Dato { get; set; }
        public Nodo HijoIzquierdo { get; set; }
        public Nodo HijoDerecho { get; set; }

        // Constructor
        public Nodo(Usuario dato)
        {
            Dato = dato;
            HijoIzquierdo = null;
            HijoDerecho = null;
        }
    }
}
