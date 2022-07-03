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
            Console.WriteLine("Ingrese una hora");
            var hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos");
            var minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos");
            var segundos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el formato que desea obtener AM ó PM");
            var FormatoSelect = Convert.ToString(Console.ReadLine());
            if (FormatoSelect == "AM" || FormatoSelect == "am")
            {
                Verificar(hora, minutos, segundos);
                {
                    Console.WriteLine($"{hora}:{minutos}:{segundos} {FormatoSelect}");
                    Console.WriteLine($"{hora}:{minutos}:{segundos} FORMATO EN 24hs");
                }

            }
            else if (FormatoSelect == "PM" || FormatoSelect == "pm")
            { 
                if (Verificar(hora, minutos, segundos)) ;
                {
                    Console.WriteLine($"{hora}:{minutos}:{segundos} {FormatoSelect}");
                    hora = hora + 12;
                    Console.WriteLine($"{hora}:{minutos}:{segundos} FORMATO EN 24hs");
                }
            }
            Console.ReadLine();

        }

        private static bool Verificar(int hora, int minutos, int segundos)
        {
            if (hora > 0 && hora <= 12 || minutos > 0 && minutos <= 59 || segundos > 0 && segundos <= 59)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
