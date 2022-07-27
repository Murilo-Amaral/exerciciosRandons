using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal peso, altura;
            Console.Write("Informe seu peso em kilos (Ex: 75,0): ");
            peso = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe sua altura em metros (Ex: 1,80): ");
            altura = Convert.ToDecimal(Console.ReadLine());

            decimal imc = peso / (altura * altura);

            Console.Write("Seu IMC é: " + Math.Round(imc, 2));
            Console.ReadKey();
        }
    }
}
