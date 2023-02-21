using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pajaro
    {   
        //Acontinuacion realizamos absgtraccion para sacar las carectiristas de cada objeto
        
        protected String pico;
        private String alas;
        private String patas;

        public Pajaro(String pico, String alas, String patas)
        {
            this.pico = pico;
            this.alas = alas;
            this.patas = patas;
        }

        public void setPico(String pico) { this.pico = pico; }
        public String getPico() { return pico; }
        public void setAlas(String alas) { this.alas = alas; }
        public String getAlas() { return alas; }
        public void setPatas(String patas) { this.patas = patas; }
        public String getPatas() { return patas; }
        }
    }


