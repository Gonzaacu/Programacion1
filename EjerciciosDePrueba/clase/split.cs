using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.clase
{
    internal class split
    {
        //Declarar los campos y prorpiedades
        //Campo: a las variables privadas de la clase

        private string color;
        private int frigorias;
        private string marcas;
        private bool encendido;

        //Preopiedades: las variables publicas de la clase
                              //Forma 1
        public int temperatura = 24;
        public string modo = "Frio";

        //Constructor: metodo que se ejecuta cuando la clase de crea, se intancia en memoria, es decir cuando se construye el objeto 
        public split(string pColor, int pFrigorias, string pMarcas)
        {
            this.color = pColor;
            this.frigorias = pFrigorias;
            this.marcas = pMarcas;
            //otra forma 2
            //this.temperatura = 24;
            //this.modo = "Frio";
            this.encendido = false;

        }
        public void PrecionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }
        public void SubirTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura++;
            }else
            {
                Console.WriteLine("Error: El split esta apagado");
            }
            
        }
        public void BajarTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura--;
            }else
            {
                Console.WriteLine("Error: El splte esta apagado");
            }
            
        }

        public void CambiarModo(string modo)
        {
            if (this.encendido)
            {
                this.modo = modo;
            }
            else
                Console.WriteLine("Error: El split esta encendido");
            }
        }

}

