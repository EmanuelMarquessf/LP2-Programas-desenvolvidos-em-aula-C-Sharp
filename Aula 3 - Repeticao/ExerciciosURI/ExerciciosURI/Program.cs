using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

//Emanuel Fonseca - 3005925

namespace ExerciciosURI
{
    class Program
    {
        static void Exercicio1()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1049
            int opcao;
            Console.WriteLine("[1] - Vertebrado \n[2] - Invertebrado");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("[1] - Ave \n[2] - Mamifero");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("[1] - Carnivoro \n[2] - Onivoro");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                        Console.WriteLine("Aguia");
                    else
                        Console.WriteLine("Pombo");
                }
                else
                {
                    Console.WriteLine("[1] - Onivoro \n[2] - Herbivoro");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                        Console.WriteLine("Homem");
                    else
                        Console.WriteLine("Vaca");
                }

            }

            else
            {
                Console.WriteLine("[1] - Inseto \n[2] - Anelideo");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("[1] - Hematofago \n[2] - Herbivoro");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                        Console.WriteLine("Pulga");
                    else
                        Console.WriteLine("Lagarta");
                }
                else
                {
                    Console.WriteLine("[1] - Hematofago \n[2] - Onivoro");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                        Console.WriteLine("Sanguessuga");
                    else
                        Console.WriteLine("Minhoca");
                }
            }
            Console.ReadKey();
        }
        static void Exercicio2()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1059

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();

        }

        static void Exercicio3()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1073

            int numero;
            Console.Write("Digite um numero:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}^2 = {1}", i,Pow(i,2));
            }

        }

        static void Exercicio4()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1079

            int quant;
            float num1, num2, num3, media;

            Console.Write("Quantidade: ");
            quant= int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Numero 1: ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Numero 2: ");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Numero 3: ");
                num3 = float.Parse(Console.ReadLine());

                media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;

                Console.WriteLine("Media: {0:f1}", media);
                Console.WriteLine("\n\n");

            }
        }

        static void Exercicio5()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1133

            int x, y;

            Console.Write("Intervalo entre: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Intervalo entre {0} e: ", x);
            y = int.Parse(Console.ReadLine());

            for (int i = x; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3) 
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("=======================================");
            Console.WriteLine("[1] - Exercicio 1 \n[2] - Exercicio 2 \n[3] - Exercicio 3 \n[4] - Exercicio 4 \n[5] - Exercicio 5 \n[0] - Sair");
            Console.WriteLine("=======================================");
            Console.Write("Opcao: ");
            opcao = int.Parse(Console.ReadLine());
            
            do
            {
                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                       Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;

                }

            } while (opcao != 0);
        }
    }
}
