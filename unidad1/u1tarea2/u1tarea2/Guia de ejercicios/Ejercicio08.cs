using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio08
    {
        //Un programa que calcule el factorial de un número dado por el usuario. (for)
        public Ejercicio08()
        {
            Console.WriteLine("Factorial de un numero");
            Console.WriteLine("----------------------");

            Console.WriteLine("\nIngrese un numero:");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial = factorial * i;
            }
                Console.WriteLine("El factorial de " + num + " es: " + factorial);
        }
    }
}
