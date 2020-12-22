using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras_Geometricas
{
    public abstract class Figura2D
    {
        // Atributos
        private string nombre;
        private byte dimensiones;
        private double area;

        // Constructor
        public Figura2D(string nombre, byte dimensiones)
        {
            this.nombre = nombre;
            this.dimensiones = dimensiones;
        }

        // Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public byte Dimensiones
        {
            get
            {
                return dimensiones;
            }
        }

        // Representacion string
        public override string ToString()
        {
            return string.Format("Figura: {0}\nTipo: {1}D", Nombre, Dimensiones);
        }

        // Metodo para calcular el area
        public abstract double CalcularArea();

    }
}
