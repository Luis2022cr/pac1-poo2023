using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio07
    {
        //Un programa que sume los números del 1 al 10 y muestre el resultado en la consola.(for)

        public Ejercicio07()
        {
            Console.WriteLine("Suma de los numeros del 1 al 10");
            Console.WriteLine("-------------------------------");
            int suma = 0;

            for (int i = 1; i <= 10 ; i++)
            {
                suma = suma + i;
            }
                Console.WriteLine("\nLa suma de los nuemero del 1 al 10 es: " + suma);
        }
    }
}
