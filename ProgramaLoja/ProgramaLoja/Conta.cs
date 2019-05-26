using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLoja
{
    public class Conta
    {

        List<Transacao> transacoes = new List<Transacao>();
        public List<Transacao> Transacoes
        {
            get
            {
                return transacoes;
            }

            set
            {
                transacoes = value;
            }
        }

        public void AddTransacao(string ind, decimal valor)
        {
            Transacao tr = new Transacao(ind, valor);
            transacoes.Add(tr);
        }
        public void AddTransacao(Transacao trans)
        {
            transacoes.Add(trans);
        }

        public List<Transacao> getLista()
        {
           return  transacoes;

        }




        public decimal getSaldo()
        {
            decimal saldo = 0;
            foreach (Transacao item in transacoes)
            {
                saldo = saldo + item.valor;

            }
            return saldo;
        }



        //private decimal saldo;
        //public void credito(decimal valor)
        //{
        //    this.saldo = this.saldo + valor;
        //}
        //public void Debitar(decimal valor)
        //{

        //    this.saldo = this.saldo - valor;
        //}

        //public decimal getSaldo()
        //{
        //    return saldo;

        //}





    }
}
