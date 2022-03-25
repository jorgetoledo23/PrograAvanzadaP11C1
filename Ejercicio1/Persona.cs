using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Persona
    {
        int contador;
        public string Rut { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public Persona(string rut, string nombre, string apellido)
        {
            this.Rut = rut;
            Name = nombre;  
            Apellido = apellido;
        }


    }
}
