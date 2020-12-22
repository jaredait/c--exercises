using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    public class Persona
    {   
        // Atributos y propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Discapacidad { get; set; }
        public bool terceraEdad;

        // Constructores (sobrecargados)
        public Persona()
        {
            Nombre = "";
            Edad = 0;
            TerceraEdad = false;
            Discapacidad = false;
        }
        public Persona(string nombre, int edad, bool discapacidad)
        {
            Nombre = nombre;
            Edad = edad;
            Discapacidad = discapacidad;
        }

        // Propiedad que define si es que la persona pertenece a la tercera edad en base a su atributo Edad
        public bool TerceraEdad
        {
            get
            {
                if (Edad >= 60)
                    return true;
                else
                    return false;
            }
            set
            {
                terceraEdad = value;
            }
        }
    }
}
