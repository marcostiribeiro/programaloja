using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLoja
{
    public class Cliente
    {
        private Conta conta = new Conta();
        private Endereco endereco = new Endereco();
        private string cpf;
        private string nome;
        private int idade;


        public Cliente(string nome)
        {
            this.nome = nome;
        }
        public Conta Conta
        {
            get
            {
                return conta;
            }

            set
            {
                conta = value;
            }
        }

        public Endereco Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public Cliente(Conta conta, Endereco endereco, string cpf, string nome, int idade)
        {
            this.Conta = conta;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
