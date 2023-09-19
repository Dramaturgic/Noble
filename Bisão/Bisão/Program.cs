using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 1: Aprovado, Reprovado e Prova");
            Console.ReadLine();
            Console.Clear();

            double d_prova = 0;

            Console.WriteLine("Digite a nota que quer evaluar:");
            d_prova = double.Parse(Console.ReadLine());

            Console.Clear();

            if (d_prova >= 7 && d_prova <= 10) 
            {
                Console.WriteLine("Você esta aprovado!!!!");
                Console.ReadLine();
            }
            else 
            {
                if (d_prova >= 4 && d_prova < 7)
                {
                    Console.WriteLine("Quase lá!!!, Realize o exame de recuperação para aprovar.");
                    Console.ReadLine();
                }

                else 
                {
                    if (d_prova >= 0 && d_prova < 4)
                    {
                        Console.WriteLine("Você foi Reprovado :(");
                        Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("O número que você inseriu é um número invalido por favor insira um número entre 0 e 10");
                        Console.ReadLine();
                    }

                }

            }


        }
    }
}
