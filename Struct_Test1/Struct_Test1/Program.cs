using System;

namespace Struct_Test1
{


    class Program
    {
        /*
        static void Main(string[] args)
        {
            Persona per1;
            per1.nombre = "Jared";
            per1.edad = 22;

            Console.WriteLine("Persona sin inicializar:\nNombre: {0}\nEdad: {1}", per1.nombre, per1.edad);
        }
        */
    }
    public struct Persona
    {
        public string nombre;
        public int edad;

        public Persona(string personaNombre, int personaEdad)
        {
            this.nombre = personaNombre;
            this.edad = personaEdad;
        }

    }
}
