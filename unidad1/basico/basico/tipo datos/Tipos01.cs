using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.tipo_datos
{
    internal class Tipos01
    {
        public String saludo { get; set; }
        
        public Tipos01(String v1)
        {
            this.saludo = v1;                  //set
            String sNombre = this.saludo + ", juan Perez";     //get

            Console.WriteLine(sNombre);
            
        }
    } 

}
