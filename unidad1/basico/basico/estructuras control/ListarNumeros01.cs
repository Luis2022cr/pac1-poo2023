using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros01
    {
        public ListarNumeros01()
        {

            /*
             * while (cond) {...}
             */

            /*Console.WriteLine("Listar numeros hasta: ");
            int limite = int.Parse(Console.ReadLine());
            */
            int i = 1;

            /*while (i <= limite) 
            {
                Console.WriteLine(i);
                i++; // se ejecuta despues de la iteracion
                // ++i; se ejecuta antes de la iteracion
                // i = i + 1;
                // i--,
                // --i;
                // i = i - 1;
            }*/

            char cond = 's';
            while (cond == 's')
            {
                Console.WriteLine("Listar numeros hasta: ");
                int limite1 = int.Parse(Console.ReadLine());

                while (i <= limite1)
                {
                    Console.WriteLine(i);
                    i++;
                }
                i = i - limite1;

                Console.WriteLine("\nDesea continuar");
                cond = Console.ReadLine()[0];

                if (cond != 's')
                {
                    Console.WriteLine("FIN DEL PROGRAMA");
                }
            }

        }    
    }
}
