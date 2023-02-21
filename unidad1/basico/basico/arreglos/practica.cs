using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class practica
    {
        public practica()
        {
            int[,] matrixA = new int[3, 3]
            {       { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
            };

            int[,] matrixB = new int[3, 3]
            {       { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
            };

            int[,] matrixC = new int[3, 3];


            //SUMA
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            //Mostrar
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrixC[i, j] + " ");
                }
            }
        }
    }
}
