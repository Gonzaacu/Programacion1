using EjerciciosDePrueba.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.StereoAuto
{
    //using System;
    internal class StereoAuto 
    {
      
            public bool encendido;
            public string radioEstacion;
            public string bluetoothCancion;
            public int cdPista;

            public ModoEnum Modo;
            public StereoAuto()
            {
                encendido = false;
                Modo = ModoEnum.Apagado;
                radioEstacion = "";
                bluetoothCancion = "";
                cdPista = 0;
            }

        //public void Encender()
        //{
        //    encendido = true;
        //    Modo = ModoEnum.encendido;
        //    Console.WriteLine("El estéreo está encendido.");
        //}

        //public void Apagar()
        //{
        //    encendido = false;
        //    Console.WriteLine("El estéreo está apagado.");
        //}
        public void PrecionarBotonEncendido()
        {

            this.encendido = ! this.encendido;
            Console.WriteLine("El estéreo está encendido.");
        }
        public void CambiarModo(ModoEnum nuevoModo)
            {
                if (this.encendido)
                {
                    Modo = nuevoModo;
                Console.WriteLine("-------------------------------------------------------");
                }
            }
            public void SetRadioEstacion(string estacion)
            {
                if (encendido && Modo == ModoEnum.Radio)
                {
                    radioEstacion = estacion;
                    Console.WriteLine($"La estación de radio ha sido cambiada a {radioEstacion}.");
                }               
            }
            public void SetBluetoothCancion(string cancion)
            {
                if (this.encendido && Modo == ModoEnum.Bluetooth)
                {
                    bluetoothCancion = cancion;
                    Console.WriteLine($"La canción Bluetooth ha sido cambiada a '{bluetoothCancion}'.");
                }
            }
            public void SetCdPista(int pista)
            {
                if (this.encendido && Modo == ModoEnum.CD)
                {
                    cdPista = pista;
                    Console.WriteLine($"La pista del CD ha sido cambiada a {cdPista}.");
                }               
            }

            public void Pantalla()
            {
                if (this.encendido)
                {
                    Console.WriteLine($"El estéreo está encendido. Modo actual: {Modo}.");

                    switch (Modo)
                    {
                        case ModoEnum.Radio:
                            Console.WriteLine($"Estación de radio: {radioEstacion}");
                            break;
                        case ModoEnum.Bluetooth:
                            Console.WriteLine($"Canción Bluetooth: {bluetoothCancion}");
                            break;
                        case ModoEnum.CD:
                            Console.WriteLine($"Pista del CD: {cdPista}");
                            break;
                        default:
                            Console.WriteLine("No hay información adicional disponible.");
                            break;
                    }
                }
                
            }
    }
}
