using System;
using System.Threading;

namespace Atividade4_LP2A4
{
    //EMANUEL FONSECA -- CJ3005925
    class Program
    {
        static void PosOperacao()
        {
            Thread.Sleep(100);
            Console.WriteLine("=======================================");
            Console.WriteLine("Pressione qualquer botão para voltar ao menu...");
            Console.ReadKey();
            Console.WriteLine("=======================================");
            Console.Clear();
        }
        static void PreencherCPF(out string cpf)
        {
            int calc = 0, calc2=0;
            Console.Write("CPF: ");
            cpf = Console.ReadLine();

            cpf = cpf.Replace(".", String.Empty);
            cpf = cpf.Replace("-", String.Empty);

            int[] cpfFinal = new int[cpf.Length];
            if (cpf.Length == 11)
            {
                for (int i = 0; i < cpf.Length; i++)
                {
                    cpfFinal[i] = Convert.ToInt32(cpf[i] % 48);
                }

                for (int i = 0; i < 9; i++)
                {
                    calc = calc + (cpfFinal[i] * (10 - i));
                }
                calc = (calc * 10) % 11;

                for (int i = 0; i < 10; i++)
                {
                    calc2 = calc2 + (cpfFinal[i] * (11 - i));
                }
                calc2 = (calc2 * 10) % 11;

                if (cpfFinal[9] == calc && cpfFinal[10] == calc2)
                    Console.WriteLine("CPF VALIDO!!");
                else
                    Console.WriteLine("CPF INVALIDO :C");
            }
            else
                Console.WriteLine("CPF INVALIDO");
            PosOperacao();
        }

       
        static void Main(string[] args)
        {
            int opcao;
            string cpf;
            do
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("[1] - Validar CPF\n[0] - Sair");
                Console.Write("Opcao: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("=======================================");
                switch (opcao)
                {
                    case 1:
                        PreencherCPF(out cpf);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("OPCAO INVALIDA!!");
                        break;
                }
                
            } while (opcao != 0);
            
        }
    }
}
