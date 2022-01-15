using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corretora;

namespace Corretora
{
    public class Conta 
    {
        private Cliente cliente;
        private string numero;
        private float saldo = 0.0f;
        private DateTime dataAbertura;
        private bool status;

        public Conta(Cliente cliente)
        {
            this.cliente = cliente;
            numero = cliente.RetornarCPF();
            dataAbertura = DateTime.Now;
            status = true;
        }
        public Conta(Cliente cli, string num, float sal, DateTime dataAber)
        {
            cliente = cli;
            numero = num;
            saldo = sal;
            dataAbertura = dataAber;
            status = true;
            saldo = 0.0f;
        }
        public float RetornarSaldo()
        {
            return saldo;
        }

        public bool RetornarStatus()
        {
            return status;
        }

        public bool AlterarStatus()
        {
            if (status == true)
                status = false;
            else
                status = true;
            return true;
        }

        public string Depositar(float valor)
        {
            if (valor <= 0.0)
                return "Nao é possivel depositar valor negativo";
            saldo += valor;
            return "Sucesso na operacao!!" + "\nValor depositado: R$" + valor + "\nSaldo Disponivel: R$ " + saldo;
        }

        public string Sacar(float valor)
        {
            if (saldo < valor)
                return "Valor indisponivel";
            saldo -= valor;
            return "Sucesso na operacao!!\nValor sacado: R$" + valor + "\nSaldo disponivel: R$ "+ saldo;
        }

        public string RetornarNumConta()
        {
            return numero;
        }

        public override string ToString()
        {
            return cliente.ToString() +"\nNumero: "+ numero +"\nSaldo disponivel: "+ saldo +"\nData de Abertura: "+ dataAbertura +"\nStatus da conta:"+ status + "\n======================================"; 
        }
    }
}
