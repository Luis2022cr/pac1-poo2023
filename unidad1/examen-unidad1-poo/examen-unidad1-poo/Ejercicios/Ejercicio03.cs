using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_unidad1_poo.Ejercicios
{
    internal class Ejercicio03
    { 
        public Ejercicio03() 
        {
            Console.WriteLine("Ejercicio 3 ");
            Console.WriteLine("------------\n");

            Console.WriteLine("Ingrese el tamaño de la matriz: ");
            int num = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[,] Matriz = new int[num, num];
            

            for (int i = 0; i < num; i++)
            {
                Console.Write ("\n");
                for (int j = 0; j < num; j++)
                {
                    Matriz[i, j] = random.Next(0, 100);

                    Console.Write(Matriz[i, j] + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
