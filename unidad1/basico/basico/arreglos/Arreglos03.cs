﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglos03
    {
        public Arreglos03() 
        {
            int[,] numeros = new int[3, 3];

            //numeros[0,0] = 34;
            //numeros[0,1] = 12;
            //numeros[0,2] = 32;

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    numeros[f, c] = f + c;
                    Console.WriteLine(numeros[f, c]);
                }
            }
        }
    }
}
