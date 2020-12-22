using System;

namespace Cola_Test00
{
    class Persona
    {
        // Atributos
        private string nombre;
        private short edad;
        private const string NOMBRE_DEFAULT = "*sin_nombre*";
        private const short EDAD_DEFAULT = -1;

        // Constructores sobrecargados
        public Persona(string elNombre, short laEdad)
        {
            Nombre = elNombre;
            Edad = laEdad;
        }
        public Persona(string elNombre) : this(elNombre, EDAD_DEFAULT) { }
        public Persona() : this(NOMBRE_DEFAULT, EDAD_DEFAULT) { }

        public override string ToString()
        {
            return String.Format("{0}, {1} años.", Nombre, Edad);
        }

        // Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public short Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public static void Main(string[] args)
        {
            Persona JC = new Persona("Juan Carlos", 54);
            Persona Jared = new Persona("Jared", 22);
            Persona Shamel = new Persona("Shamel", 23);
            Persona Paty = new Persona("Paty", 47);
            Persona Benja = new Persona("Benja", 15);
            Persona vacio = new Persona();

            ColaPQ pq = new ColaPQ();

            pq.Insertar(Shamel);
            pq.Insertar(Jared);
            pq.Insertar(Paty);
            pq.Insertar(Benja);
            pq.Insertar(vacio);
            pq.Insertar(JC);


            pq.Imprimir();

            pq.Remover();

            pq.Imprimir();

            Console.WriteLine(pq.EstaVacia());
        }
    }
}
