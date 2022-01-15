using System;
using System.Collections.Generic;

namespace Corretora
{
    public class Corretora
    {
        public static List<Conta> contas = new List<Conta>();
        public static bool CadastrarConta()
        {
            Conta conta = new Conta(CadastroCliente());
            contas.Add(conta);

            return true;
        }

        static int Menu()
        {
            Console.WriteLine("======================================\n[1] - Cadastro de conta\n[2] - Listar contas ativas\n[3] - Listar contas inativas\n[4] - Deposito\n[5] - Saque\n[6] - Desativar conta\n======================================");
            return int.Parse(Console.ReadLine());
        }
        static void GerirCorretora()
        {
            int opcao;
            List<Conta> corretora = new List<Conta>();

            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("CADASTRO DE CONTA");
                        if (CadastrarConta())
                        {
                            Console.WriteLine("Cadastrado com sucesso!!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("CONTAS ATIVAS");
                        foreach (var item in contas)
                        {
                            if (item.RetornarStatus() == true)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("CONTAS INATIVAS");
                        foreach (var item in contas)
                        {
                            if (item.RetornarStatus() == false)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("DEPOSITO");
                        RealizarDeposito();
                        break;

                    case 5:
                        Console.WriteLine("SACAR");
                        Sacar();
                        break;

                    case 6:
                        Console.WriteLine("ALTERAR STATUS");
                        AlterarStatus();
                        Console.WriteLine("Status alterado com sucesso!!");
                        break;
                }

            } while (opcao != 0);
        }

        static void Sacar()
        {
            Console.WriteLine("Numero da Conta: ");
            string numeroConta = Console.ReadLine();

            foreach (Conta item in contas)
            {
                if (item.RetornarNumConta() == numeroConta)
                {
                    Console.WriteLine("Valor a ser sacado: ");
                    float valor = float.Parse(Console.ReadLine());
                    Console.WriteLine(item.Sacar(valor));
                    return;
                }

            }
        }
        static void RealizarDeposito()
        {
            Console.WriteLine("Numero da Conta: ");
            string numeroConta = Console.ReadLine();

            foreach (Conta item in contas)
            {
                if (item.RetornarNumConta() == numeroConta)
                {
                    Console.WriteLine("Valor a ser depositado: ");
                    float valor = float.Parse(Console.ReadLine());
                    Console.WriteLine(item.Depositar(valor));
                    return;
                }
            }
        }

        static void AlterarStatus()
        {
            Console.WriteLine("Numero da Conta: ");
            string numeroConta = Console.ReadLine();

            foreach (Conta item in contas)
            {
                if (item.RetornarNumConta() == numeroConta)
                {
                    item.AlterarStatus();
                    return;
                }
            }
        }

        public static Cliente CadastroCliente()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new Cliente(nome, cpf, telefone, email);

        }

        static void Main(string[] args)
        {
            GerirCorretora();
        }



    }


}
