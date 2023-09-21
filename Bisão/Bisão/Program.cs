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
            Console.WriteLine("Atividade 1: Media com Números Reais.");
            Console.ReadLine();

            Console.Clear();
            double d_nta = 0;

            Console.WriteLine("Digite a nota média da prova: ");
            d_nta = double.Parse(Console.ReadLine());

            if (d_nta >= 7 && d_nta <= 10)
            {
                Console.WriteLine("Aprovado");
            }
            else if (d_nta >= 4 && d_nta <= 6.99)
            {
                Console.WriteLine("Exame");
            }
            else if (d_nta >= 0 && d_nta <= 3.99)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Nota inválida");
            }

            Console.ReadLine();
            Console.Clear();

            
            Console.WriteLine("Atividade 2: Crie uma calculadora que execute as quatro operações matemáticas.");
            Console.ReadLine();

            Console.Clear();

            while (true)
            {

                int i_escolha = 0;

                Console.Clear();
               
                Console.WriteLine("Escolha uma operação:");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Adição");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("2 - Subtração");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("3 - Divisão");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4 - Multiplicação");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("5 - Sair do programa");
                Console.ResetColor();

                i_escolha = int.Parse(Console.ReadLine());

                if (i_escolha == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("O programa foi encerrado.");
                    break;
                }

                double d_nm_1, d_nm_2 = 0;

                if (i_escolha >= 1 && i_escolha <= 4)
                {
                    Console.WriteLine("Digite o primeiro número:");
                    d_nm_1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número:");
                    d_nm_2 = double.Parse(Console.ReadLine());

                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Escolha uma operação válida.");
                    Console.ReadLine();
                    continue; // Volta ao início do loop se a opção for inválida
                }

                switch (i_escolha)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Resultado da adição: {0}", d_nm_1 + d_nm_2);
                    break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Resultado da subtração: {0}", d_nm_1 - d_nm_2);
                    break;

                    case 3:
                        if (d_nm_2 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Resultado da divisão: {0}", d_nm_1 / d_nm_2);
                        }
                        else
                        {
                            Console.WriteLine("Divisão por zero não é permitida.");
                        }
                    break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Resultado da multiplicação: {0}", d_nm_1 * d_nm_2);
                    break;

                    default:
                        Console.WriteLine("Opção inválida. Escolha uma operação válida.");
                    break;
                }

                Console.ResetColor();

                string s_rpta = "";
                Console.WriteLine("\n\nDeseja fazer outra operação? (S/N)");
                s_rpta = Console.ReadLine();

                if (s_rpta.ToUpper() != "S")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("O programa foi encerrado.");
                    break;
                }
            }

            Console.ReadLine();

        }
        
    }
}
