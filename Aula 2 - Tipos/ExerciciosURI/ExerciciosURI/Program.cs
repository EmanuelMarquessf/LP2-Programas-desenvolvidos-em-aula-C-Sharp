using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ExerciciosURI
{
    class Program
    {

        static void Exercicio1()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1015
            double x1, y1;
            double x2, y2;
            double distancia;

            Console.Write("X1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("X2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Y2: ");
            y2 = double.Parse(Console.ReadLine());

            distancia = Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));

            Console.WriteLine("Distancia: {0:f2}", distancia);

            Console.ReadKey();
        }

        static void Exercicio2()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1002
            double area, raio;
            double pi = 3.14159;
            Console.Write("Raio: ");
            raio = double.Parse(Console.ReadLine());

            area = pi * Pow(raio, 2);

            Console.Write("Area: {0:f2}", area);
            Console.ReadKey();
        }

        static void Exercicio3()
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1006
            float nota1, nota2, nota3, media;
            Console.Write("Nota1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Nota2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Nota3: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

            Console.Write("Media {0:f2}", media);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("[1] - Exercicio 1 \n[2] - Exercicio 2 \n[3] - Exercicio 3");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 0);

            if (opcao == 1)
                Exercicio1();
            else if (opcao == 2)
                Exercicio2();
            else
                Exercicio3();

        }
    }
}
