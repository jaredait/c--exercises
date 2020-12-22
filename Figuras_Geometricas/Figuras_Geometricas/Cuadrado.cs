using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras_Geometricas
{
    public class Cuadrado : Figura2D
    {
        // Atributos
        private double lado;
        private double diagonal;

        // Constructor
        public Cuadrado(double lado, double diagonal) : base("Cuadrado", 2) 
        {
            this.lado = lado;
            this.diagonal = diagonal;
        }
        public Cuadrado(double lado) : this(lado, 0) { }

        // Propiedades
        public double Lado
        {
            get
            {
                return lado;
            }
        }
        public double Diagonal
        {
            get
            {
                return diagonal;
            }
        }

        // Metodo para calcular el area
        public override double CalcularArea()
        {
            return Lado == 0 ? Math.Pow(Diagonal, 2) / 2 : Math.Pow(Lado, 2);
        }

        // Representacion string
        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        }
    }
}
