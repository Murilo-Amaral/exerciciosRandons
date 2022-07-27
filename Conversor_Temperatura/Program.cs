using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Celsius, Faren;
            Console.Write("Informe a temperatura em F°: ");
            Faren = Convert.ToDecimal(Console.ReadLine());

            Celsius = (Faren - 32) * 5 / 9;

            if (Celsius > 38)
            {
                Console.Write("Sua temperatura é " + Celsius + " Voce esta com febre! Procure um médico!");
            }
            else
            {
                Console.Write("Sua temperatura é " + Celsius + " Voce esta bem!");
            }
                

            Console.ReadKey();

        }
    }
}
