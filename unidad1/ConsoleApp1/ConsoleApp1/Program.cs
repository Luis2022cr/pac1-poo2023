using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {        
                //En este punto estamos encapsulando los datos 
                Tipo objAlumno = new Tipo("Jimmy", "Ardon","Santa Rosa de Copan");
                objAlumno.setNumeroCuenta("20182100004");
                //Polimorfismo
                // Y aqui seran guardados los datos para luego mostrarlos.
                objAlumno.mostrarDatos();  
        }
        /* En este punto hacemos uso de Herencia ya que la clase
        alumno esta herendando de la clase personas sus caracteristicas
        */
        public class Tipo
        {
 //Sacamos tambien una abstaccion con el Numero de Cuenta.
        private String NumeroCuenta;
    }
    public String get() { return NumeroCuenta; }
    public void setNumeroCuenta(String NumeroCuenta) 
    { 
        this.NumeroCuenta = NumeroCuenta; 
    }

    public Alumno(String nombre, String apellido, String domicilio)
    {
        super(nombre, apellido, domicilio);
    }

    /*Polimorfismo son metodos que pueden tener un mismo nombre pero que 
    hacen acciones diferentes*/

    public void mostrarDatos()
    {

        Console.WriteLine("ALUMNO \nNombre: "+ getNombre() + " " + getApellido() + "\nDomilicio: " + getDomicilio()
        + "\nEdad: " + getEdad() + "\nMatricula: " + getNumeroCuenta());
    }

}
}
    

