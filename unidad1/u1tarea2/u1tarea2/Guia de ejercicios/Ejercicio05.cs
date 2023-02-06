using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1tarea2.Guia_de_ejercicios
{
    internal class Ejercicio05
    {
        /*Un programa que pregunte al usuario si quiere comprar una hamburguesa, 
          una ensalada o una pizza y muestre el precio correspondiente. (switch)*/

        public Ejercicio05()
        {
            Console.WriteLine("Ejercicio 5: Precio del producto");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("\n-----Menu-----");
            Console.WriteLine("1. Hamburguesa");
            Console.WriteLine("2. Ensalada");
            Console.WriteLine("3. Pizza");
            Console.WriteLine("\nIngrese su compra:");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("El precio de la hamburguesa es: 80 lps.");
                    break;
                case 2:
                    Console.WriteLine("El precio de la ensalada es: 50 lps.");
                    break;
                case 3:
                    Console.WriteLine("El precio de la pizza es: 120 lps.");
                    break;
                default:
                    Console.WriteLine("El producto no existe");
                    break;
            }

        }
    }
}
