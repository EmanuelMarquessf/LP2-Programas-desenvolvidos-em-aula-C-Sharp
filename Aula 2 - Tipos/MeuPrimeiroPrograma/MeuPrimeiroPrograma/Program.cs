using System;

namespace MeuPrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;

            do
            {
                Console.Write("Nota1: ");
                nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota2: ");
                nota2 = double.Parse(Console.ReadLine());
                Console.Write("Nota3: ");
                nota3 = double.Parse(Console.ReadLine());
            } while (nota1 < 0 && nota1 > 10 && nota2 < 0 && nota2 > 10 && nota3 < 0 && nota3 > 10);
        }
    }
}
