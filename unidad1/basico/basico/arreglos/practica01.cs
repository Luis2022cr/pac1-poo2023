using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class practica01
    {
        public practica01()
        {
            int[,] MatrizA = new int[3, 3];
            int[,] MatrizB = new int[3, 3];
            int[,] MatrizC = new int[3, 3];

            Console.WriteLine("\nIngresando datos al matriz A");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    MatrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nIngresando datos al matriz B");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    MatrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Sumamos la matrizA y la MatrizB
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }

            Console.WriteLine("\nLa suma de la MatrizA y MatrizB es :");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(MatrizC[i, j] + "  ");
                }

            }
            Console.WriteLine("\n");
        }   
    }
}
    
