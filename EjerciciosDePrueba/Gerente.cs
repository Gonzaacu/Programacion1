﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba
{
    internal class Gerente : Empleado
    {
        public Gerente(string nombre, string apellido) : base(nombre, apellido)
        {
            
        }
        public override string ImprimirDatos()
        {
            return "Gerente: "+ base.ImprimirDatos();
        }
    }

}
