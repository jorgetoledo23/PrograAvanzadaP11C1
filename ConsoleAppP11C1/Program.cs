using System;
using System.Collections.Generic;

namespace ConsoleAppP11C1
{
    public class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("Jorge", "Toledo");
            Console.Write("Ingresa tu Nombre: ");
            var nombrePersona = Console.ReadLine();
            Console.WriteLine(Saludar(nombrePersona));  

            // Declaracion de Variables
            //tipoVariable nombreVariable = valorVariable
            //tipoVariable nombreVariable;

            int i = 0;
            string nombre = "Jorge";
            double PI = 3.1416;
            bool bandera = false;
            char caracter = 'C';

            //inferir tipo
            var apellido = "Toledo";
            var j = 1;

            var bandera2 = true;

            //Tipado
            //i = "Hola";

            //Metodo Convert.
            i = Convert.ToInt32(PI);
            //Casting
            i = (int)PI;
            //Error de ejecucion
            i = Convert.ToInt32(nombre);

            /* Operadores
            + Suma
            - Resta
            * Multiplicacion
            / Division
            % Module
            ++ Incrementar
            -- Decrementar
            */

            /* Operadores de Asignacion
             
            = | x = 5 | x = 5
            += | x += 5 | x = x + 3
            -= | x -= 5 | x = x - 3
            *= | x *= 5 | x = x * 3
            /= | x /= 5 | x = x / 3
            %= | x %= 5 | x = x % 3
            
             */
            /* Operadores de Comparacion
             == Igual A
            != No igual A
            > Mayor que
            < Menor que
            >= Mayor o Igual que
            <= Menor o Igual que
            */

            /* Operadores Logicos
             && Logico Y
             || Logico OR
             !  Logico NOT
            */

            /* If */
            if (true)
            {
                Console.Write(1);
            }
            else if (true)
            {
                Console.Write(2);
            }
            else
            {
                Console.Write(3);
            }

            int hora = 10;
            string resultado = 
                (hora < 12) ? "Buenos Dias" : "Buenas Tardes";

            if (hora < 12) Console.WriteLine("Buenos Dias");


            // While
            while (true)
            {
                Console.WriteLine("Ciclo While");
            }
            // Do While
            do
            {
                Console.WriteLine("Ciclo Do While");
            } while (true);

            // For
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
            }

            string mes = "Marzo";
            switch (mes)
            {
                case "enero":
                    Console.WriteLine("Vacaciones!");
                    break;
                case "febrero":
                    Console.WriteLine("Vacaciones!");
                    break;
                default:
                    Console.WriteLine("Vacaciones!");
                    break;
            }

            List<string> paises = new List<string>();
            paises.Add("Chile");
            paises.Add("Brasil");
            paises.Add("Argentina");

            foreach (var pais in paises)
            {
                Console.WriteLine(pais);
            }

            paises.ForEach(x => Console.WriteLine(x));

            paises.Find(x => x == "Chile");


            

        }

        public string Saludar(string nombre)
        {
            return $"Hola {nombre}";
        }
        public string Saludar(string nombre, string apellido)
        {
            return $"Hola {nombre} {apellido}";
        }

        




    }
}


















