using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda.Model
{
    public class Client
    {
        public int _id;
        public string _name;
        public string _cpf;
        public string _email;
        public string _fone;

        public Client(string name, string cpf, string email, string fone)
        {
            Name = name;
            Cpf = cpf;
            Email = email;
            Fone = fone;
        }

        public Client(int id, string name, string cpf, string email, string fone)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
            Fone = fone;
        }

        public int Id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Nome nao pode ser nulo ou vazio!!");
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public string Cpf
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("CPF nao pode ser nulo ou vazio!!");

                if(value.Length < 11)
                    throw new Exception("CPF deve conter 11 digitos!!");

                //if(!Validation.ValidateCpf(value))
                //    throw new Exception("CPF inválido");

                _cpf = value;
            }
            get
            {
                return _cpf;
            }
        }
        public string Email
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Email nao pode ser nulo ou vazio!!");
                if (!value.Contains('@'))
                    throw new Exception("Email Invalido!!");
                _email = value;
            }
            get
            {
                return _email;
            }
        }
        public string Fone
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Telefone nao pode ser nulo ou vazio!!");
                if (value.Length > 20)
                    throw new Exception("Telefone deve ter 11 digitos!!");
                _fone = value;
            }
            get
            {
                return _fone;
            }
        }
    }
}
