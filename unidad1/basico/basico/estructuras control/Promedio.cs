using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class Promedio
    {
        /*
         * menos de 70 puntos => reprobado
         * mas de 70 puntos => aprobado
         * mas de 80 puntos => bueno
         * mas de 90 puntos => sobresaliente
         */
        public Promedio() 
        {
            Console.WriteLine("Promedio");
            Console.WriteLine("--------");

            Console.WriteLine("Ingrese 3 notas");
            Console.WriteLine("Nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());

            int promedio = (nota1 + nota2 + nota3)/3;


            if (promedio < 70)
            {
                Console.WriteLine("Su promedio es" + promedio + " Usted reprobo");
            }

            if (promedio >= 70 && promedio < 80)
            {
                Console.WriteLine("Su promedio es: " + promedio + " Usted aprobo");
            }

            if (promedio >= 80 && promedio < 90)
            {
                Console.WriteLine("Su promedio es: " + promedio + " Su calificacion es buena");
            }

            if (promedio >= 90 && promedio <= 100)
            {
                Console.WriteLine("Su promedio es: " + promedio + " Su calificacion es Sobresaliente");
            } else
            {
                Console.WriteLine("Error, no puede sacar mas de 100");
            }
        }
    }
}
