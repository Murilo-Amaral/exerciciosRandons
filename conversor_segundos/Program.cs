using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_segundos
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto, segundo, hr_Seg, min_Seg, segundos_Totais;
            Console.Write("Informe a hora: ");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe os minutos: ");
            minuto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe os segundos: ");
            segundo = Convert.ToInt32(Console.ReadLine());

            hr_Seg = hora * 60 * 60;
            min_Seg = minuto * 60;
            segundos_Totais = hr_Seg + min_Seg + segundo;

            Console.Write("Em " + hora + " horas, " + minuto + " minutos e " + segundo + "segundos."
                + " Tem ao total " + segundos_Totais + " segundos!");
            Console.ReadKey();

        }
    }
}
