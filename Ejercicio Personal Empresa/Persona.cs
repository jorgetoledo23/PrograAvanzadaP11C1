using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Personal_Empresa
{
    public class Persona
    {
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

        public override string ToString()
        {
            return $"Empleado Rut: {Rut}, Nombre: {Name}, Apellido: {Apellido}, Sueldo: {Sueldo}";
        }
    }
}
