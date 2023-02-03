using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class Vocales
    {
        public Vocales()
        {
            Console.WriteLine("Nombres segun la vocal");
            Console.WriteLine("----------------------");

            Console.WriteLine("\nIngrese una vocal:");
            char vocal = Console.ReadLine()[0];
            switch (vocal)
            {
                case 'a':
                    Console.WriteLine("Abel, Angel, Andrea, Ana, Antonia");
                    break;
                case 'e':
                    Console.WriteLine("Erik, Esteban, Edgardo, Erika, Esmeralda");
                    break;
                case 'i':
                    Console.WriteLine("Isis, Isabel, Isidoro, Ivan, Iris");
                    break;
                case 'o':
                    Console.WriteLine("Omar, Oscar, Orfilio, Ovidio, Octavio");
                    break;
                case 'u':
                    Console.WriteLine("Ulisis, Ursula, Uriel, Ubaldo, Uriana");
                    break;
                default:
                    Console.WriteLine("La vocal no es valida.");
                    break;
            }
        }
    }
}
