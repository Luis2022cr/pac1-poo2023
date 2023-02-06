using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio11
    {
        /*Un programa que muestre la tabla de multiplicar 
          del número dado por el usuario hasta el 10. (while)*/

        public Ejercicio11() 
        {
            Console.WriteLine("Tabla de multiplicacion");
            Console.WriteLine("-----------------------");

            Console.WriteLine("\nIngrese la tabla que quiera ver");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("------ Tabla del " + num + " ------");

            int i = 1;
            int multi = 1;
            while (i <= 10)
            {
                multi = i * num;

                Console.WriteLine(num + " * " + i + " = " + multi);

                i++;
            }
        }
    }
}
