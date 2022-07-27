using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diametro
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal diametro, raio, circunferencia;
            decimal pi = 3.14M;
            raio = 4M;
            diametro = raio * 2;
            circunferencia = (2 * pi) * raio;

            Console.Write("Com um raio de 4 cm, o diâmetro é: " + diametro + " e a circunferência é:" +
                " " + circunferencia);
            Console.ReadKey();
        }
    }
}
