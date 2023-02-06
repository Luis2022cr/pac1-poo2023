using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio10
    {
        /*Un programa que sume los números pares del 1 al 100
          y muestre el resultado en la consola. (while)*/

        public Ejercicio10() 
        {
            Console.WriteLine("Suma de numero pares entre el 1 y 100");
            Console.WriteLine("-------------------------------------");
            int i = 0;
            int suma = 0;

            while (i < 100)
            {
                i = i + 2;
                suma = suma + i;
            }
            Console.WriteLine("\nLa suma de todos los pares es: " + suma);
        }
    }
}
