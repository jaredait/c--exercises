using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador_red_social_CONSOLA
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
