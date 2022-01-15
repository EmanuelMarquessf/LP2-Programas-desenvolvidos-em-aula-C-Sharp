using System;
using System.Threading;

namespace Atividade2_LP2A4
{
    //EMANUEL FONSECA -- CJ3005925
    class Program
    {

        static void Load()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Preenchendo a Matriz.");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine("Preenchendo a Matriz..");
                Thread.Sleep(250);
                Console.Clear();
                Console.WriteLine("Preenchendo a Matriz...");
                Thread.Sleep(250);
                Console.Clear();
            }
            Console.WriteLine("Matriz Preenchida!!!");
            Thread.Sleep(700);
            Console.Clear();
        }
        static void PosOperacao()
        {
            Thread.Sleep(100);
            Console.WriteLine("=======================================");
            Console.WriteLine("Pressione qualquer botão para voltar ao menu...");
            Console.ReadKey();
            Console.WriteLine("=======================================");
            Console.Clear();
        }
        static void PreencherMatriz(int[,] matriz)
        {
            Random numAle = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    matriz[i, i2] = numAle.Next(1, 10);
                }
            }
        }
        static void ExibirMatriz(int[,] matriz)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("MATRIZ:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t {0}",matriz[i, j]);
                }
                Console.WriteLine();
            }
            PosOperacao();
        }
        static void MatrizInversa(int[,] matriz)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("MATRIZ INVERSA:\n");
            float determinante;
            float[,] adjunta = new float[3, 3];
            float[,] inversa = new float[3, 3];
            determinante = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) + (matriz[0, 1] * matriz[1, 2] * matriz[2, 0]) + (matriz[0, 2] * matriz[1, 0] * matriz[2, 1])) - ((matriz[2,0] * matriz[1,1] * matriz[0,2]) + (matriz[2,1] * matriz[1,2] * matriz[0,0]) + (matriz[2,2] * matriz[1,0] * matriz[0,1]));

            adjunta[0, 0] = (matriz[1, 1] * matriz[2, 2]) - (matriz[2, 1] * matriz[1, 2]);
            adjunta[0, 1] = (matriz[2, 1] * matriz[0, 2]) - (matriz[2, 2] * matriz[0, 1]);
            adjunta[0, 2] = (matriz[0, 1] * matriz[1, 2]) - (matriz[1, 1] * matriz[0, 2]);

            adjunta[1, 0] = (matriz[1, 2] * matriz[2, 0]) - (matriz[2, 2] * matriz[1, 0]);
            adjunta[1, 1] = (matriz[2, 2] * matriz[0, 0]) - (matriz[0, 2] * matriz[2, 0]);
            adjunta[1, 2] = (matriz[0, 2] * matriz[1, 0]) - (matriz[1, 2] * matriz[0, 0]);

            adjunta[2, 0] = (matriz[1, 0] * matriz[2, 1]) - (matriz[2, 0] * matriz[1, 1]);
            adjunta[2, 1] = (matriz[2, 0] * matriz[0, 1]) - (matriz[0, 0] * matriz[2, 1]);
            adjunta[2, 2] = (matriz[0, 0] * matriz[1, 1]) - (matriz[1, 0] * matriz[0, 1]);

            for (int i = 0; i < 3; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    inversa[i, i2] = adjunta[i, i2] / determinante;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    Console.Write("\t {0:f2}", inversa[i, i2]);
                }
                Console.WriteLine();
            }
            PosOperacao();
        }

        static void Main(string[] args)
        {
            int opcao;
            int[,] matriz = new int[3, 3];
            Load();
            PreencherMatriz(matriz);
            do
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("[1] - Exibir Matriz \n[2] - Matriz Inversa\n[0] - Sair");
                Console.WriteLine("=======================================");
                Console.Write("Opcao: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        ExibirMatriz(matriz);
                        break;
                    case 2:
                        MatrizInversa(matriz);
                        break;
                    default:
                        Console.WriteLine("OPCAO INVALIDA!!!");
                        Thread.Sleep(1300);
                        Console.Clear();
                        break;
                }

            } while (opcao != 0);
        }
    }
}
