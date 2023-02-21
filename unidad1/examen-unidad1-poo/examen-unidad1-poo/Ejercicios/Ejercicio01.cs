using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_unidad1_poo.Ejercicios
{
    internal class Ejercicio01
    {
        public Ejercicio01()
        {
            Random random = new Random();

            int[] MatrizA = new int[3];

            MatrizA[0] = random.Next(1, 100); ;
            MatrizA[1] = random.Next(1, 100); ;
            MatrizA[2] = random.Next(1, 100); ;

            if (MatrizA[0] < MatrizA[1] && MatrizA[1] > MatrizA[2])
            {
                Console.WriteLine("El numero menor es " + MatrizA[0]);
                Console.WriteLine("El numero mayor es " + MatrizA[2]);
            }
            if (MatrizA[1] < MatrizA[2] && MatrizA[2] < MatrizA[0])
            {
                Console.WriteLine("El numero mayor es " + MatrizA[0]);
                Console.WriteLine("El numero menor es " + MatrizA[1]);

            }
            if (MatrizA[2] < MatrizA[0] && MatrizA[0] < MatrizA[1]) 
            {
                Console.WriteLine("El numero mayor es " + MatrizA[1]);
                Console.WriteLine("El numero menor es " + MatrizA[2]);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + MatrizA[1]);
                Console.WriteLine("El numero menor es " + MatrizA[0]);
            }


        }
    }
}
