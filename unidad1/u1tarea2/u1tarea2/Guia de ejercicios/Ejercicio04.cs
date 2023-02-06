using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio04
    {
        /*Un programa que pregunte al usuario un número del 1 al 7
          y muestre el día de la semana correspondiente. (switch)*/

        public Ejercicio04()
        {
            Console.WriteLine("Ejercicio 4: Dias de la semana");
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nIngrese un numero");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("El dia es Lunes");
                    break;
                case 2:
                    Console.WriteLine("El dia es Martes");
                    break;
                case 3:
                    Console.WriteLine("El dia es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("El dia es Jueves");
                    break;
                case 5:
                    Console.WriteLine("El dia es Viernes");
                    break;
                case 6:
                    Console.WriteLine("El dia es Sabado");
                    break;
                case 7:
                    Console.WriteLine("El dia es Domingo");
                    break;
                default:
                    Console.WriteLine("El dia no existe");
                    break;
            }
        }
    }
}
