using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSimuladorDeYagoTorres
{
    class Program
    {
        static void Main(string[] args)
        {
            String Hora12, Hora24;
            Console.WriteLine("Ingrese una hora");
            var hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos");
            var minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos");
            var segundos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el formato que desea obtener AM ó PM");
            string FormatoSelect = Console.ReadLine();
            if (VerificarHora(hora) && VerificarMinutos(minutos) && VerificarSegundos(segundos) && VerificarFormato(FormatoSelect))
            {
                Hora12 = CrearHora12(hora, minutos, segundos, FormatoSelect);
                Console.WriteLine($"La hora ingresada es {Hora12}");
                Hora24 = CrearHora24(hora, minutos, segundos, FormatoSelect);
                Console.WriteLine($"La hora en formato 24 es {Hora24}");

            }
            else
            {
                Console.WriteLine("Alguno de los datos fueron mal ingresados");
            }

            Console.ReadLine();
        }

        private static bool VerificarHora(int hora)
        {
            return hora >=1 && hora <= 12;
        }
        private static bool VerificarMinutos(int minutos)
        {
            return minutos >= 0 && minutos <= 59;
        }
        private static bool VerificarSegundos(int segundos)
        {
            return segundos >= 0 && segundos <= 12;
        }
        private static bool VerificarFormato(String FormatoSelect)
        {
            return FormatoSelect.ToUpper() == "AM" || FormatoSelect.ToUpper() == "PM";
        }
        private static string CrearHora12(int hora, int minutos, int segundos, string FormatoSelect)
        { 
          return  $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')} {FormatoSelect.ToUpper()}";
        }
        private static string CrearHora24(int hora, int minutos, int segundos, string FormatoSelect)
        {
            if (FormatoSelect.ToUpper() == "AM")
            {
                if (hora == 12)
                {
                    hora = hora - 12;
                }
                else
                {
                    if (hora <= 1 && hora <= 11)
                    {
                        hora = hora + 12;
                    }
;
                }                           
            }
            return $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')} {FormatoSelect.ToUpper()}";
        }
    }
}
