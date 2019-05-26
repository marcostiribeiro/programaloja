using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLoja
{
    public class Endereco
    {
        public int Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Endereco() {}

        public Endereco(int numero, string rua, string bairro, string cidade)
        {
            Numero = numero;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
