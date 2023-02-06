using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio06
    {
        //Un programa que muestre los números del 1 al 100 en la consola. (for)

        public Ejercicio06() 
        {
            Console.WriteLine("Numeros del 1 al 100");
            Console.WriteLine("--------------------");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
