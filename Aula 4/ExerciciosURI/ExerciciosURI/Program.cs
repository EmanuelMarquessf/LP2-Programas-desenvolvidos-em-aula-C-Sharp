using System;
using System.Threading;

namespace Atividade2_LP2A4
{
    //EMANUEL FONSECA -- CJ3005925
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("[1] - Edição de dados \n[2] - Exibição dos dados");
            return int.Parse(Console.ReadLine());
        }
        static string DefinirClassificacao(float patrimonio, int idade)
        {
            string classificacao;
            if ((patrimonio >= 10000000 && idade < 39) || (patrimonio >= 35000000 && idade >= 39))
                classificacao = "Cliente Diamante";
            else if ((patrimonio > 7000000 && idade < 36) || (patrimonio > 20000000 && patrimonio < 35000000) && (idade >= 36))
                classificacao = "Cliente Ouro";
            else if ((patrimonio > 5000000) && (idade < 33) || (patrimonio > 10000000 && patrimonio < 20000000) && (idade >= 33))
                classificacao = "Cliente Prata";
            else if ((patrimonio > 1000000) && (idade < 30) || (patrimonio > 5000000 && patrimonio < 10000000) && (idade >= 30))
                classificacao = "Cliente Bronze";
            else
                classificacao = "Cliente Safira";

            return classificacao;
        }

        static void Main(string[] args)
        {
            /* Você foi contratado por uma corretora de serviços financeiros e precisa desenvolver
             * uma aplicação que dê suporte às operações da empresa. Portanto, seu primeiro trabalho
             * consiste em criar um sistema de gestão de clientes. Cada cliente ao solicitar um 
             * cadastro, precisará informar os seguintes dados: (Nome, CPF, RG, idade,
             * Renda Bruta Mensal, e-mail, telefone e patrimônio). Além dos dados informados, há um 
             * dado interno (classificação) que precisa ser definido com base nos seguintes critérios: 
             * Cliente diamante : 10MM ou mais de patr. e menos de 39 anos OU 35MM ou mais de patr. e 39 ou mais anos.
             * Cliente ouro     : entre [7MM, 10MM) de patr. e menos de 36 anos OU entre [20MM, 35MM) de patr. e 36 ou mais anos.
             * Cliente prata    : entre [5MM, 7MM) de patr. e menos de 33 anos OU entre [10MM, 20MM) de patr. e 33 ou mais anos.
             * Cliente bronze   : entre [1MM, 5MM) de patr. e menos de 30 anos OU entre [5MM, 10MM) de patr. e 30 ou mais anos.
             * Cliente safira   : entre [0 e 1MM) de patr. e menos de 27 anos OU entre [0, 5MM) e 27 ou mais anos.
             * IMPORTANTE: caso haja sobreposição em relação a idade e patrimônio, escolha sempre a classificação acima.
             *
             * Crie as variáveis necessárias para armazenar os dados a serem informados, além daquela que informa a classificação.
             * Crie um menu com as opções:
             * 1 - Editar dados (pergunte ao usuário se ele quer atualizar um a um os dados. Se houver alteração de idade ou patrimônio deve atualizar a classificação.
             * 2 - Exibir os dados cadastrados para aquele cliente.
             * 
             * Além disso, possibilite que as opções do menu possam ser escolhidas quantas vezes forem necessárias.
             */

            string nome, cpf, rg, rendaBMensal, email, telefone, classificacao;
            int idade, escolha,escolhaDados;
            float patrimonio;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("RG: ");
            rg = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Renda Bruta Mensal: ");
            rendaBMensal = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Telefone: ");
            telefone = Console.ReadLine();
            Console.Write("Patrimonio: ");
            patrimonio = float.Parse(Console.ReadLine());
            classificacao = DefinirClassificacao(patrimonio, idade);

            Console.Clear();

            do
            {
                escolha = Menu();
                Console.Clear();
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("[1] - Nome \n[2] - CPF\n[3] - RG\n[4] - Idade\n[5] - Renda Bruta mensal\n[6] - Email\n[7] - Telefone\n[8] - Patrimonio");
                        escolhaDados = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (escolhaDados)
                        {
                            case 1:
                                Console.Write("Novo Nome: ");
                                nome = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Novo CPF: ");
                                cpf = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Novo RG: ");
                                rg = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Nova Idade: ");
                                idade = int.Parse(Console.ReadLine());
                                break;
                            case 5:
                                Console.Write("Nova Renda Bruta Mensal: ");
                                rendaBMensal = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Novo Email: ");
                                email = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Novo Telefone: ");
                                telefone = Console.ReadLine();
                                break;
                            case 8:
                                Console.Write("Novo Patrimonio: ");
                                patrimonio = float.Parse(Console.ReadLine());
                                break;
                            default:
                                break;
                        }
                        classificacao = DefinirClassificacao(patrimonio, idade);
                        Console.Clear();
                        Console.WriteLine("Dado alterado com sucesso!!!");
                        Thread.Sleep(1000);
                        Console.Clear();

                        break;
                    case 2:
                        Console.WriteLine("DADOS DO CLIENTE");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Nome: {0}\nCPF: {1}\nRG: {2}\nIdade: {3}\nRenda Bruta Mensal: {4}\nEmail: {5}\nTelefone: {6}\nPatrimonio: {7}\nClassificacao: {8}", nome, cpf, rg, idade, rendaBMensal, email, telefone, patrimonio, classificacao);
                        Console.WriteLine("==============================================\n");
                        Thread.Sleep(600);
                        Console.WriteLine("Precione qualquer botao para voltar ao menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while(escolha != 0);
        }
    }
}
