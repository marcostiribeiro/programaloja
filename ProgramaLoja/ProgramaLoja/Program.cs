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
            Transacao tt = new Transacao("tesate", 500);

            Conta conta = new Conta();
            conta.AddTransacao("Debito", 10000);
            conta.AddTransacao("Debito", 20000);
            conta.AddTransacao("Debito", 30000);
            conta.AddTransacao("Debito", 40000);
            conta.AddTransacao("Debito", 50000);
            conta.AddTransacao(tt);
            
            foreach (Transacao item in conta.Transacoes)
            {
                Console.WriteLine("Identificação {0} e valor {1}",item.identificacao,item.valor );
            }
            Console.WriteLine(conta.getSaldo());

            Console.ReadKey();

            



            //Endereco endereco = new Endereco(12, "rua tal", "Bairro", "Cidade TAl");

            //Cliente cliente1 = new Cliente(conta, endereco, "11111111", "Joao", 20);

            //cliente1.Conta.credito(10000);
            //Cliente cll1 = new Cliente("mm");
            //Cliente cll2  = new Cliente("nn");
            //Cliente cll3 = new Cliente("oo");
            //Cliente cll4 = new Cliente("pp");

            //List<Cliente> listaClientes = new List<Cliente>();
            //listaClientes.Add(cll2);
            //listaClientes.Add(cll1);
            //listaClientes.Add(cll3);
            //listaClientes.Add(cll4);


            //foreach (Cliente cli in listaClientes)
            //{
            //    Console.WriteLine(cli.Nome);
            //    Console.ReadKey();
            //}


















        }
    }
}
