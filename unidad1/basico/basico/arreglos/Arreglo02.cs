using basico.estructuras_control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo02
    {
        public Arreglo02()
        {
            Random random = new Random();

            char con = 's';
            while (con == 's')
            {
                Console.WriteLine("Ingrese el limite de numeros:");
                int num = int.Parse(Console.ReadLine());

                int[] numeros = new int[num];

                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = random.Next(1, 100);
                    Console.WriteLine("numeros[" + i + "] = " + numeros[i]);
                }
                
                Console.WriteLine("Desea continuar [s/n]");
                con = char.Parse(Console.ReadLine());

                if (con != 's')
                {
                    Console.WriteLine("Saliendo ......");
                }
            }
        }
    }
}
