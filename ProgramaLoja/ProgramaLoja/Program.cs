using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLoja
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco end = new Endereco(12, "rua 1", "bairro 1", "cidade 1");
            Conta conta1 = new Conta();
            Cliente cli = new Cliente(conta1, end, "11111111", "fulano", 20);

            cli.Conta.AddTransacao("Credito 1 ", 1000);
            cli.Conta.AddTransacao("Credito 2 ", 1000);
            cli.Conta.AddTransacao("Credito 3 ", 1000);
            cli.Conta.AddTransacao("Credito 4 ", 1000);
            cli.Conta.AddTransacao("Credito 5 ", 1000);
            cli.Conta.AddTransacao("Pagamento 1 ", -1000);
            cli.Conta.AddTransacao("Pagamento 2 ", -1000);


            //imprimir dados do cliente

            Console.WriteLine("Nome {0} CPF {1} e Idade {2} Endereco {3}{4}{5}{6}", cli.Nome, cli.Cpf, cli.Idade, cli.Endereco.Numero, cli.Endereco.Rua, cli.Endereco.Bairro, cli.Endereco.Cidade);


            cli.Conta.extrato();
            Console.WriteLine("Meu saldo é {0}", cli.Conta.getSaldo());

            Console.ReadKey();



























        }
    }
}
