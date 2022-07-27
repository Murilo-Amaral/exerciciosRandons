using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiçao_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int meta, vendas;
            Console.Write("Informe sua meta: ");
            meta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe suas vendas: ");
            vendas = Convert.ToInt32(Console.ReadLine());

            if (vendas >= meta)
            {
                Console.Write("Ganhou o bonus!");
            }

            if (vendas < meta)
            { Console.Write("Suas vendas não passou a meta. Não GANHOU!"); }
            
            Console.ReadKey();
        }
    }
}
