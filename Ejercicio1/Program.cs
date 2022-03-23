using System;

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
        }
    }
}
