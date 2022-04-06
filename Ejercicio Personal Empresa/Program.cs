﻿/* Crear una APP de Consola, que pueda ingresar X cantidad 
 * de empleados de una empresa,
 * y tener la Opcion de mostrarlos por pantalla 
 * de manera ordenada!
 * Los atributos para la clase Empleado son:
 * Rut,
 * Nombre,
 * Apellido,
 * Sueldo
 */
using Ejercicio_Personal_Empresa;

char opcion;
List<Persona> listaPersonal = new List<Persona>();


do
{
    //Console.Clear();
    Console.WriteLine("1 - Ingreso de Empleados ");
    Console.WriteLine("2 - Listar Empleados ");
    Console.WriteLine("3 - Salir del Sistema ");

    Console.Write("Selecciona una Opcion: ");
    opcion = Convert.ToChar(Console.ReadLine());

    if (opcion.Equals('1'))
    {
        //Ingresar Empleados
        Console.Clear();
        Console.Write("Rut: ");
        string? rut = Console.ReadLine();

        Console.Write("Nombre: ");
        string? nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        string? ape = Console.ReadLine();

        Console.Write("Sueldo: ");
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
