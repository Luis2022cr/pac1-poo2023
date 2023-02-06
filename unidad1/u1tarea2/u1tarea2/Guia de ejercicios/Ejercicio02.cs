using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio02
    {
        /*Ejercicio: Escribir un programa que pregunte al usuario por dos números 
         y determine cuál es el mayor.*/

        public Ejercicio02 () 
        {
            Console.WriteLine("Ejercicio 2: Numero mayor");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\nIngrese un numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese otro numero:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("\nEl numero mayor es: " + num1);
            }
            if (num2 > num1) 
            { 
                Console.WriteLine("\nEl numero mayor es: " + num2);
            }
            if (num1 == num2) 
            {
                Console.WriteLine("\nLos numero son iguales");
            }
        }

    }
}
