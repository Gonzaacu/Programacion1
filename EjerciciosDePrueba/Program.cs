

using EjerciciosDePrueba;
using EjerciciosDePrueba.clase;
using EjerciciosDePrueba.Enum;
using EjerciciosDePrueba.PavaElectrica;
using EjerciciosDePrueba.StereoAuto;



public class ProgramEjercicios

{
    public static void Main()
    {
        //PruebaDeObjetoSplit();
        //PruebaDeObjetoPersona();
        //EjerciciosDePruebaPavaElectrica();
        //EjerciciosDePruebaStereoAuto();
        //PruebaDeClasesAbstractasYHerencias();
        //Console.WriteLine(ControlFechasValidasInvalidas(31, 4, 2023));
        //Console.WriteLine(CalcularDiasDeVida(365, 30, 1));
        //PruebaDeClasesGenericas();



        //Console.Write("Ingrese el día: ");
        //int dia = int.Parse(Console.ReadLine());

        //Console.Write("Ingrese el mes: ");
        //int mes = int.Parse(Console.ReadLine());

        //Console.Write("Ingrese el año: ");
        //int año = int.Parse(Console.ReadLine());

        //if (FechaValida(dia, mes, año))
        //{
        //    Console.WriteLine("La Fecha es Válida.");
        //}
        //else
        //{
        //    Console.WriteLine("No es Fecha Válida.");
        //}
    }
    private static void PruebaDeClasesGenericas() 
    {
        Empresas<Empleado> empresa = new Empresas<Empleado>("Neumaticos Debona");
        Gerente empleado1 = new Gerente("Juan", "Perez");
        Gerente empleado2 = new Gerente("Pedro", "Porro");
        empresa.agregarEmpleado(empleado1);
        empresa.agregarEmpleado(empleado2);
        Console.WriteLine(empresa.listarpersonas());
        empresa.quitarEmpleado(empleado2);
        Console.WriteLine(empresa.listarpersonas());



    }

    private static void PruebaDeObjetoSplit()

    {
        //intanciamos el objeto split
        split miSplit = new split("blanco", 3000, "marshall");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PrecionarBotonEncendido();
        miSplit.CambiarModo("Deshumificador");
        miSplit.SubirTemperatura();
        Console.WriteLine("el modo definido del splte:" + miSplit.modo);
    }


    private static void PruebaDeObjetoPersona()

    {
        persona albert = new persona("Albert Eistein", "9 de Julio 1111", 1879);
        persona robert = new persona("Robert Oppenheider", "Manhattan 2222", 1904);
        robert.Decir("Albert, sabes como se despiden los quimicos?");
        albert.Decir("No, ni idea");
        robert.Decir("Acido un plaser");
    }

    private static void EjerciciosDePruebaPavaElectrica()
    {
        pavaElectrica miPava = new pavaElectrica("negro Mate", "Liliana"); 
        miPava.PrecionarBotonEncendido();
        miPava.Temperatura();
        //miPava.CambiarModo();
        Console.WriteLine("el modo definido de la Pava:" + miPava.modo);

    }

    private static void EjerciciosDePruebaStereoAuto()
    {
        StereoAuto miStereo = new StereoAuto();

        miStereo.PrecionarBotonEncendido();
        miStereo.CambiarModo(ModoEnum.Radio);
        miStereo.SetRadioEstacion("90.7");
        miStereo.Pantalla();
        miStereo.CambiarModo(ModoEnum.Bluetooth);
        miStereo.SetBluetoothCancion("Duki - Modo Diablo");
        miStereo.Pantalla();
        miStereo.CambiarModo(ModoEnum.CD);
        miStereo.SetCdPista(3);
        miStereo.Pantalla();
        miStereo.PrecionarBotonEncendido();
        miStereo.Pantalla();
    }
    
    //public static void fechasValidasInvalidas()

    //{
    //    //definir variables  
    //    int dia, mes, año;

    //    // Pedir Informacion al usuario
    //    Console.WriteLine("Ingrese el día");
    //    dia = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Ingrese el mes");
    //    mes = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Ingrese el año");
    //    año = int.Parse(Console.ReadLine());


    //    if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
    //            mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
    //        Console.WriteLine("Fecha Valida");

    //    else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
    //        Console.WriteLine("Fecha Valida ");

    //    else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

    //        Console.WriteLine("Fecha Valida ");

    //    else
    //        Console.WriteLine("Fecha Invalida");

    //}

    //public static bool ControlFechasValidasInvalidas(int dia, int mes, int año)

    //{
        
      
    //    if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
    //            mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            
    //        return true;

    //    else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
           
    //        return true;
    //    else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

    //        return true;
    //    else
            
    //        return false;

    //}
    //public static int CalcularDiasDeVida(int años, int meses, int dias, int dias)
    //{
    //    int diasDeVida;

    //    diasDeVida = (años * 365) + (meses * 30) + dias;

    //    return = diasDeVida;
    //}
    //private static void Triangulos()
    //{
    //    // Declaramos las variables 
    //    int lado1, lado2, lado3;

    //    Console.Write("Ingrese el 1er Lado del triángulo: ");
    //    lado1 = int.Parse(Console.ReadLine());

    //    Console.Write("Ingrese el 2do Lado del triángulo: ");
    //    lado2 = int.Parse(Console.ReadLine());

    //    Console.Write("Ingrese el 3er Lado del triángulo: ");
    //    lado3 = int.Parse(Console.ReadLine());

    //    if (lado1 == lado2 && lado2 == lado3)
    //    {
    //        Console.WriteLine("El triángulo es equilátero.");
    //    }
    //    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    //    {
    //        Console.WriteLine("El triángulo es isósceles.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("El triángulo es escaleno.");
    //    }
    //}
    ////public static string Triangulos(int lado1, int lado2, int lado3)
    //{
    //    // Declaramos las variables 
    //    int lado1, lado2, lado3;

    //    if (lado1 == lado2 && lado2 == lado3)
    //    {
    //        return = "equilátero";
    //    }
    //    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    //    {
    //        return = "isósceles";
    //    }
    //    else
    //    {
    //        return = "escaleno";
    //    }
    //}
    //private static void PruebaDeClasesAbstractasYHerencias()
    //{
    //    Gerente Juan = new Gerente("Alejandro", "ghdyrjyrj");
    //    Console.WriteLine(Juan.ImprimirDatos());
    //}
    

}
#region otro program
//namespace CuotaAPagar
//{
//    class Program
//    {
//        static void Main(string[] args)
//    {
//        Console.Write("Ingrese el día del mes en que se paga la cuota: ");
//        int dia = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Ingrese el monto de la cuota: ");
//        double monto = Convert.ToDouble(Console.ReadLine());

//        double cuotaAPagar = CalcularCuota(dia, monto);

//        Console.WriteLine($"La cuota a pagar es: {cuotaAPagar:C2}");
//    }

//    static double CalcularCuota(int dia, double monto)
//    {
//        double cuotaAPagar = monto;

//        if (dia <= 2)
//        {
//            cuotaAPagar *= 0.97; // descuento del 3%
//        }
//        else if (dia <= 5)
//        {
//            cuotaAPagar = monto; // no se cobra interés
//        }
//        else if (dia <= 10)
//        {
//            cuotaAPagar *= 1.10; // recargo del 10%
//        }
//        else if (dia <= 20)
//        {
//            cuotaAPagar *= 1.12; // recargo del 12%
//        }
//        else
//        {
//            cuotaAPagar *= 1.15; // recargo del 15%
//        }

//        return cuotaAPagar;
//    }
//}
//}

#endregion
