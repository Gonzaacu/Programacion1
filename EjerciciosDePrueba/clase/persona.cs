using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.clase
{
    public class persona
    {
        private string nombre;
        private string direccion;
        private int año_nac;

        public string Apellido { get; set; }
        private int dni;
        public int Dni 
        {
            get { return dni;  }
            set { dni = value; } 
        }


        public persona(string nombre, string direccion, int año_nac)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.año_nac = año_nac;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($"{nombre} dice: {texto}");
        }

    }
}
