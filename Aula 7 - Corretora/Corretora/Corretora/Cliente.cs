using System;
using System.Collections.Generic;
using Corretora;

namespace Corretora
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string telefone;
        private string email;
        private bool status;

        public Cliente(string nom, string cp, string tel, string ema)
        {
            nome = nom;
            cpf = cp;
            telefone = tel;
            email = ema;
            status = true;
        }

        public static void exibirCliente(List<Cliente> ListaCliente)
        {
            foreach (var item in ListaCliente)
            {
                Console.WriteLine(item.nome + "\t" + item.cpf + "\t" + item.telefone + "\t" + item.email + "\t" + item.status);
            }

        }
        public bool ConsultarCpf(string cpfDigitado, List<Cliente> ListaCliente)
        {
            foreach (var item in ListaCliente)
            {
                if (item.cpf == cpfDigitado)
                    return true;
            }
            return false;
        }
        public bool AlterarStatus(string cpfDigitado, List<Cliente> ListaCliente)
        {
            foreach (var item in ListaCliente)
            {
                if (item.cpf == cpfDigitado)
                {
                    if (item.status == true)
                        item.status = false;
                    else
                        item.status = true;
                    return true;
                }
            }
            return false;
        }
       

        public string RetornarCPF()
        {
            return cpf;
        }

        public override string ToString()
        {
            return "======================================\nNome: " + nome + "\nCPF: " + cpf + "\nTelefone: " + telefone + "\nEmail: " + email + "\nStatus: " + status;
        }

    }

}
