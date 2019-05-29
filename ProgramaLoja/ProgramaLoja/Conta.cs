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

        public void AddTransacao(string ident, decimal valor)
        {
            Transacao trans = new Transacao(ident, valor);
            transacoes.Add(trans);
        }

        public void AddTransacao(Transacao trans)
        {
            Transacoes.Add(trans);
       }


        public List<Transacao> getLista()
        {
           return  transacoes;

        }
        /// <summary>
        /// Lista as transacoes realizadas
        /// </summary>
        public void extrato()
        {
            foreach (Transacao itemTrans in Transacoes)
            {
                Console.WriteLine("{0} {1} {2} ", itemTrans.idTransacao,itemTrans.identificacao,itemTrans.valor);
            }
        }


        
        /// <summary>
        /// Realiza busca por id na classe
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Transacao</returns>

        public Transacao buscaPorId(string id)
        {
            foreach (Transacao trans in Transacoes)
            {
              
                if (trans.identificacao == id)
                {
                    return trans;
                }
            }
            return null;
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



     





    }
}
