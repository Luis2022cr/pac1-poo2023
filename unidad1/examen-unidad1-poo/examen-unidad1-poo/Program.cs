using examen_unidad1_poo.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_unidad1_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            Console.WriteLine("Examen 1, Unidad 1, POO, Jose Luis Contreras");
            Console.WriteLine("--------------------------------------------");

            while (continuar == 's') 
            {
                Console.WriteLine("1. EjERCICIO 1.");
                Console.WriteLine("2. EjERCICIO 2.");
                Console.WriteLine("3. EjERCICIO 3.");
                Console.Write("\nIngrese el ejercicio a vizualizar: ");
                int ejercicio = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (ejercicio) 
                {
                    case 1:
                        Ejercicio01 ejercicio01 = new Ejercicio01();                   
                        break;
                    case 2:
                        Ejercicio02 ejercicio02 = new Ejercicio02();
                        break;
                    case 3:
                        Ejercicio03 ejercicio03 = new Ejercicio03();
                        break;
                    default:
                        Console.WriteLine("Ejercicio no encontrado.");
                        break;
                }
                Console.Write("Desea continuar s/n:");
                continuar = char.Parse(Console.ReadLine());
            }
        }
    }
}
