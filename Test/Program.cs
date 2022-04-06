using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            List<Persona> listaPersonal = new List<Persona>();


            do
            {
                Console.Clear();
                Console.WriteLine("1 - Ingreso de Empleados ");
                Console.WriteLine("2 - Listar Empleados ");
                Console.WriteLine("3 - Salir del Sistema ");

                Console.Write("Selecciona una Opcion: ");
                opcion = Convert.ToChar(Console.Read());

                if (opcion.Equals('1'))
                {
                    //Ingresar Empleados
                    Console.Clear();

                    Console.WriteLine("Rut: ");
                    string? rut = Console.ReadLine();

                    Console.WriteLine("Nombre: ");
                    string? nombre = Console.ReadLine();

                    Console.WriteLine("Apellido: ");
                    string? ape = Console.ReadLine();

                    Console.WriteLine("Sueldo: ");
                    int sueldo = Convert.ToInt32(Console.ReadLine());

                    Persona P = new Persona(rut, nombre, ape, sueldo);
                    listaPersonal.Add(P);

                    Console.WriteLine("Presiona una Tecla para Continuar!");
                    Console.ReadLine();
                }
                if (opcion.Equals('2'))
                {
                    //Listar Empleados
                    listaPersonal.ForEach(p => Console.WriteLine(p.ToString()));
                    Console.ReadLine();
                }






            } while (opcion != '3');
        }
    }

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
