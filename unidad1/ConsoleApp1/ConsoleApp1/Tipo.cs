using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Tipo
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Encapsulamos los datos 
                Tipo TipoAve = new Tipo("Largo y delgado", "pequeñas", "Cortas y débiles");
                TipoAve.setTipoa("Colibri");

                TipoAve.imprimir(); //polimorfismo  
            }

            //Herencia (se hereda de la clase Pajaro)

            public class Tipo
            {
                private String Tipoa;
            }
            public String getTipoa() { return Tipoa; }

            public void setTipoa(String Tipoa) { this.Tipoa = Tipoa; }

            public Tipo(String pico, String alas, String patas)
            {
                objeto(pico, alas, patas);
            }

            public void imprimir()
            {
                Console.WriteLine("Tipo de Ave");
                Console.WriteLine("***********";)
            Console.Write("\nNombre: " + getTipoa());
                Console.Write("Pico: " + getPico());
                Console.Write("Alas: " + getAlas());
                Console.Write("Patas: " + getPatas());
            }
        }
    }
}
