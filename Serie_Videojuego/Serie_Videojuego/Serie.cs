using System;
using System.Collections.Generic;
using System.Text;

/*Crearemos una clase llamada Serie con las siguientes características:
Sus atributos son titulo, numero de temporadas, entregado, genero y creador.
Por defecto, el numero de temporadas es de 3 temporadas y entregado false. El resto de atributos serán 
valores por defecto según el tipo del atributo.
Los constructores que se implementaran serán:
Un constructor por defecto.
Un constructor con el titulo y creador. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Sobrescribe los métodos toString.
 * 
 * */
namespace Serie_Videojuego
{
    class Serie
    {
        // Atributos
        private string titulo;
        private byte nTemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        // Valores por defecto
        private const byte TEMPORADAS_DEFAULT = 3;
        private const bool ENTREGADO_DEFAULT = false;
        private const string EMPTY = "empty";

        // Constructor
        public Serie(string titulo, byte nTemporadas, string genero, string creador)
        {
            Titulo = titulo;
            NTemporadas = nTemporadas;
            Genero = genero;
            Creador = creador;
        }
        public Serie(string titulo, string creador) : this(titulo, TEMPORADAS_DEFAULT, EMPTY, creador) { }
        public Serie() : this(EMPTY, EMPTY) { }


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
        public byte NTemporadas
        {
            get
            {
                return nTemporadas;
            }
            set
            {
                nTemporadas = value;
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
        public string Creador
        {
            get
            {
                return creador;
            }
            set
            {
                creador = value;
            }
        }

        public override string ToString()
        {
            return string.Format($"Titulo: {Titulo}\nNumero de temporadas: {NTemporadas}" +
                $"\nGenero: {Genero}\nCreador: {Creador}");
        }
    }
}
