using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio09
    {
        /*Un programa que pregunte al usuario si quiere continuar 
          y muestre un mensaje en la consola hasta que responda "no". (while)*/

        public Ejercicio09() 
        {
            Console.WriteLine("pregunra si o no");
            Console.WriteLine("----------------");

            Console.WriteLine("HOLA BUENAS TARDES");
            String pre = "si";

            while (pre == "si") 
            {
                Console.WriteLine("\nDesea continuar");
                pre= Console.ReadLine();

                if (pre == "si")
                {
                    Console.WriteLine("continuamos ..........");
                }else
                {
                    Console.WriteLine("Adios .......");
                }
            }
        }
    }
}
