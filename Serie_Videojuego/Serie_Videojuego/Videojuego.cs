using System;
using System.Collections.Generic;
using System.Text;
/*Crearemos una clase Videojuego con las siguientes características:

Sus atributos son titulo, horas estimadas, entregado, genero y compañia.
Por defecto, las horas estimadas serán de 10 horas y entregado false. El resto de atributos serán 
valores por defecto según el tipo del atributo.
Los constructores que se implementaran serán:
Un constructor por defecto.
Un constructor con el titulo y horas estimadas. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Sobrescribe los métodos toString.
 * 
 * */
namespace Serie_Videojuego
{
    class Videojuego
    {
        // Atributos
        private string titulo;
        private byte horasEstimadas;
        private bool entregado;
        private string genero;
        private string compania;

        // Valores por defecto
        private const byte HORAS_DEFAULT = 10;
        private const bool ENTREGADO = false;
        private const string EMPTY = "empty";

        // Constructores
        public Videojuego(string tilulo, byte horasEstimadas, string genero, string compania)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Genero = genero;
            Compania = compania;
        }
        public Videojuego(string titulo, byte horasEstimadas) : this(titulo, horasEstimadas, EMPTY, EMPTY) { }
        public Videojuego() : this(EMPTY, HORAS_DEFAULT) { }

        // Propiedades
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public byte HorasEstimadas
        {
            get
            {
                return horasEstimadas;
            }
            set
            {
                horasEstimadas = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public string Compania
        {
            get
            {
                return compania;
            }
            set
            {
                compania = value;
            }
        }

    }
}
