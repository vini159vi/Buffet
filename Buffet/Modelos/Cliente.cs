using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet
{
    public class Cliente
    {
        private string nome, endereco, bairro;
        private long cep;
        private int numero;

        public Cliente(string nome, string endereco, string bairro, long cep, int numero)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Numero = numero;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public long Cep { get => cep; set => cep = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
