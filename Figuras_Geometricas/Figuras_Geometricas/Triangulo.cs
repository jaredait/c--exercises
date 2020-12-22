using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras_Geometricas
{
    class Triangulo : Figura2D
    {
        // Atributos
        private double laBase;
        private double altura;

        // Constructor
        public Triangulo(double laBase, double altura) : base("Triangulo", 2)
        {
            this.laBase = laBase;
            this.altura = altura;
        }

        // Propiedades
        public double LaBase
        {
            get
            {
                return laBase;
            }
        }
        public double Altura
        {
            get
            {
                return altura;
            }
        }

        // Calcular el area
        public override double CalcularArea()
        {
            return LaBase * Altura / 2;
        }

        // Representacion string
        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        }
    }
}
