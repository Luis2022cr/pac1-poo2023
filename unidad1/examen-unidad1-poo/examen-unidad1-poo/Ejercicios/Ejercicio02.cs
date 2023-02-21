using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_unidad1_poo.Ejercicios
{
    internal class Ejercicio02
    {
        public Ejercicio02() 
        {
            Console.WriteLine("Ejericio 2");
            Console.WriteLine("----------\n");
            int i = 1;


            Console.WriteLine(" Ingrese el tamaño de la lista: ");
            int num = int.Parse(Console.ReadLine());
            int nume = 0;
            int final = 0;
            int final1 = 0;

            int[] array = new int[num];

            while (i <= num)
            {
                Console.WriteLine("\nIngrese numero " + i + " de la lista: ");
                nume = int.Parse(Console.ReadLine());

                if(final == nume)
                {
                    final1 = final;
                }

                final = nume;

                i++;
            }
            Console.WriteLine("El numero mas comun es: " + final1);

        }
    }
}
