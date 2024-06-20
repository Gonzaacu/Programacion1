using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.PavaElectrica
{
    internal class pavaElectrica
    {
        private string color;
        private string marcas;
        

        public int temperatura = 100;
        public string modo = "Mate";
        public bool encendido;

        public pavaElectrica(string pColor, string pMarcas)
        {
            this.color = pColor;
            this.marcas = pMarcas;
            this.encendido = false;
        }

        public void PrecionarBotonEncendido()
        {
            
            this.encendido = !this.encendido;
            Console.WriteLine("La pava esta encendida");
        }
        //string modo
        public void Temperatura()
        {
            if (!this.encendido)
            {
                
                this.temperatura++;
            }
            else
            {
                
                Console.WriteLine("Temperatura al 100 ºC");
            }

        }
        
    }
}

