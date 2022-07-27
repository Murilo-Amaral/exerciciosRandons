using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_URNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidato1=0, candidato2=0, candidato3=0, branco=0, nulo=0, enc=0;
            string x, y, ct1, ct2, ct3;
            ct1 = "Candidato Jair Inácio Messsias Lulonaro [1]";
            ct2 = "Candidato Arthur Kataguiri [2]";
            ct3 = "Candidato Kim do Val [3]";
            y = "===================";
            x = "Voto CONFIRMADO!";
            while (enc != 6)
            {
                Console.WriteLine(y);
                Console.Write("[1] Candidato Jair Inácio Messsias Lulonaro\n" +
                      "[2] Candidato Arthur Kataguiri\n" +
                      "[3] Candidato Kim do Val\n" +
                      "[4] Nulo\n" +
                      "[5] Branco\n" +
                      "Entre com seu voto: ");
                enc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(y);
                Console.Clear();
                if (enc == 1)
                {
                    candidato1 += 1;
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
                else if (enc == 2)
                {
                    candidato2 += 1;
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
                else if (enc == 3)
                {
                    candidato3 += 1;
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
                else if (enc == 4)
                {
                    nulo += 1;
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
                else if (enc == 5)
                {
                    branco += 1;
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine(y);
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                }
            }

            Console.Clear();

            if (candidato1 > candidato2 && candidato1 > candidato3)
            {
                Console.WriteLine($"O vencedor foi o candidato 1 {ct1}");
            }
            else if (candidato2 > candidato1 && candidato2 > candidato3)
            {
                Console.WriteLine($"O vencedor foi o candidato 2 {ct2}");
            }
            else if (candidato3 > candidato1 && candidato3 > candidato2)
            {
                Console.WriteLine($"O vencedor foi o candidato 3 {ct3}");
            }
            else if (candidato1 == candidato2 && candidato1 > candidato3)
            {
                Console.WriteLine($"Empate entre candidato 1 e candidato 2!");
            }
            else if (candidato1 == candidato3 && candidato1 > candidato2)
            {
                Console.WriteLine($"Empate entre candidato 1 e candidato 3!");
            }
            else if (candidato2 == candidato3 && candidato2 > candidato1)
            {
                Console.WriteLine($"Empate entre candidato 2 e candidato 3!");
            }
            else
            {
                Console.WriteLine($"Empate entre TODOS, VAMOS VOLTAR A MONARKIA!");
            }
            Console.WriteLine(y);
            Console.WriteLine($"Candidato 1 recebeu {candidato1} votos! \n{y}\n" +
                $"Candidato 2 recebeu {candidato2} votos! \n{y}\n" +
                $"Candidato 3 recebeu {candidato3} votos! \n{y}\n" +
                $"Votos brancos e nulos somam {branco + nulo} votos, sendo {nulo} votos nulos e {branco} votos brancos!");
            Console.ReadKey();
        }
    }
}
