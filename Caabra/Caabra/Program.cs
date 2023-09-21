using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caabra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1
            int i_nm1 = 0;

            Console.WriteLine("Atividade 1: Ler um numero e descubra se um número é par ou impar em C# ");
            Console.ReadLine();

            Console.Clear();


            Console.Write("Digite algum número inteiro: ");
            i_nm1 = int.Parse(Console.ReadLine());

            if (i_nm1 % 2 == 0)
            {
                Console.WriteLine("Seu número é par");
            }
            else
            {
                Console.WriteLine("Seu número é impar");
            }
            Console.ReadLine();

            Console.Clear();
            #endregion
            #region Atividade 2
            int i_nm3 = 0, i_nm2 = 0;


            Console.WriteLine("Atividade 2: Ler dois números e descubra se o primeiro é maior ou menor que o segundo ou se o segundo é maior que o primeiro ou ainda se são iguais. Após isso Escreva a frase que melhor descreve o resultado");
            Console.ReadLine();

            Console.Clear();


            Console.Write("Digite o primeiro número inteiro: ");
            i_nm3 = int.Parse(Console.ReadLine());


            Console.Write("Digite o segundo número inteiro: ");
            i_nm2 = int.Parse(Console.ReadLine());


            if (i_nm3 == i_nm2)
            {
                Console.Write("Os números são iguais");
            }
            else
            {

                if (i_nm3 > i_nm2)
                {
                    Console.WriteLine("O número ({0}) é maior que o número ({1})", i_nm3, i_nm2);
                }



                else
                {
                    Console.WriteLine("O número ({1}) é maior que o número ({0})", i_nm3, i_nm2);
                }

            }
            Console.ReadLine();

            #endregion
        }
    }
}
