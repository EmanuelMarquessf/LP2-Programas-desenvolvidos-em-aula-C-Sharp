using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor=2;                   //Numero inteiro
            float valorQuebrado=1.2f;    // Poe o f pra diferenciar o double // usa 4 bits de memoria
            double valorQuebrado2 = 1.2; // usa 8 bits de memoria
            bool teste = true;          // recebe apenas true ou false 
            char caracter = 'r';        //ASCII
            string nome = "Nome";       //Uniao de caracteres;
            // "\n" - quebrar linha
            Console.WriteLine("Entre com um nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome e:" + nome);
            Console.WriteLine("Seu nome e: {0} e sua idade e: {1}", nome, valor);

            // variavel int.parse converte string para int -- se possivel
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(valorQuebrado + " " + valorQuebrado2); //Escrever na tela
            Console.ReadKey(); // Pausar programa ate precionar um botão
        }
    }
}
