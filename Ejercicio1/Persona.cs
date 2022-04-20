using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Persona
    {
        int contador;
        private string v1;
        private string v2;
        private string v3;

        public string Rut { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Sueldo { get; set; }

        //public DateTime fechaNacimiento { get; set; }

        public Persona(string rut, string nombre, string apellido, int sueldo)
        {
            Rut = rut;
            Name = nombre;  
            Apellido = apellido;
        }

        public Persona(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
