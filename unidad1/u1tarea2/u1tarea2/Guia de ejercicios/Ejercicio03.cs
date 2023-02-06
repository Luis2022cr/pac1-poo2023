using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio03
    {
        /*Un programa que pregunte al usuario su género y muestre un mensaje 
          en la consola si es hombre o mujer. (if)*/

        public Ejercicio03() 
        {
            Console.WriteLine("Ejercicio 3: Genero, Hombre o Mujer");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\nIngrese su genero (m/f):");
            char genero = Console.ReadLine()[0];

            if (genero == 'm')
            {
                Console.WriteLine("Usted es hombre");
            }
            if (genero == 'f')
            {
                Console.WriteLine("Usted es mujer");
            }
            if (genero != 'm' && genero != 'f')
            {
                Console.WriteLine("Genero no encontrado");
            }
        }
    }
}
