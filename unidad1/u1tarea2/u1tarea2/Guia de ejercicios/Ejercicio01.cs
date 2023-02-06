using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio01
    {
        /*Ejercicio: Escribir un programa que pregunte al usuario por un número
        y determine si es positivo, negativo o cero. (if)*/

        public Ejercicio01() 
        {
            Console.WriteLine("Ejercicio 1: Positivo,Negativo o Cero");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nIngrese un numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("\nEl numero es positivo");
            }
            if (num < 0)
            {
                Console.WriteLine("\nEl numero es negativo");
            }
            if (num == 0) 
            {
                Console.WriteLine("\nEl numero es Cero");
            }
        }
    }
}
