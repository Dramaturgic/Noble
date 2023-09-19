using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1
            Console.WriteLine("Atividade 1: Votação");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite sua idade:");
            int i_idade = int.Parse(Console.ReadLine());
            bool b_br = false;

            if (i_idade < 17)
            {
                Console.WriteLine("O cidadão não está apto a votar");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Você é cidadão brasileiro?, (S/N):");
            b_br = Console.ReadLine().ToUpper() == "S";

            if (i_idade > 16 && b_br)
            {
                Console.WriteLine("O cidadão está apto a votar");
            }
            else
            {
                Console.WriteLine("O cidadão não está apto para votar");
            }

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Atividade 2
            Console.WriteLine("Atividade 2: Crie um programa que tenha uma variável  double valorDaNotaFisca  e, de acordo com esse valor, o imposto deve ser calculado.");
            Console.ReadLine();
            Console.Clear();

            double d_vnf = 0;
            double d_imp = 0;

            Console.WriteLine("Digite o Valor da nota física:");
            d_vnf = double.Parse(Console.ReadLine());


            if (d_vnf < 999)
            {
                d_imp = d_vnf * 0.02;
            }
            else
            {
                if (d_vnf >= 1000 && d_vnf <= 2999)
                {
                    d_imp = d_vnf * 0.025;
                }
                else
                {
                    if (d_vnf >= 3000 && d_vnf <= 6999)
                    {
                        d_imp = d_vnf * 0.028;
                    }

                    else
                    {
                        if (d_vnf >= 7000)
                        {
                            d_imp = d_vnf * 0.03;
                        }
                    }
                }

            }

            Console.Clear();

            Console.WriteLine("O valor do imposto é: {0:C} e o valor da nota com imposto é {1:C}", d_imp, d_vnf - d_imp);
            Console.ReadLine();

            Console.Clear();
            #endregion 


        }
    }
}
