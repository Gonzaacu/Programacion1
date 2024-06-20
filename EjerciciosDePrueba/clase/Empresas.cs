using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.clase
{
    public class Empresas<T> where T : Empleado
    {
        List<T> empleados = new List<T>();
        string nombre;
        public Empresas(string nombre) 
        {
            this.nombre = nombre;
        }

        public void agregarEmpleado(T empleado) {
            empleados.Add(empleado);
        }
        public bool quitarEmpleado(T empleado) {
             if (empleados.Contains(empleado))
            {
                empleados.Remove(empleado);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string listarpersonas() 
        {
            string retorno= $"Lista de empleados de {this.nombre}" + Environment.NewLine;
            foreach (var trabajador in empleados) 
            {
                retorno += trabajador.ImprimirDatos()+Environment.NewLine;

            }
            return retorno;
        }
    }

}
