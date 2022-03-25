using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un Numero de MAX 3 Cifras: ");
            var num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Centenas: {num / 100}");
            Console.WriteLine($"Decenas: {(num % 100) / 10}");
            Console.WriteLine($"Unidades: {(num % 10)}");

            Persona persona1 = new Persona("1-1","Aa", "Bb");

            List<Persona> listaPersonal = new List<Persona>();
            listaPersonal.Add(persona1);
            Persona pBuscada = listaPersonal.Find(p => p.Rut == "1-2");

        }
    }
}
