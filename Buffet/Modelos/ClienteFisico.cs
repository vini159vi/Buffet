using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    class ClienteFisico
    {
        private string nome, endereco, bairro;
        private long cpf, rg, telefone, celular;
        private DateTime dataNasc;
        private int numeroCasa;

        public ClienteFisico(string nome, string endereco, string bairro, long cpf, long rg, long telefone, long celular, DateTime dataNasc, int numeroCasa)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Telefone = telefone;
            this.Celular = celular;
            this.DataNasc = dataNasc;
            this.NumeroCasa = numeroCasa;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public long Rg { get => rg; set => rg = value; }
        public long Telefone { get => telefone; set => telefone = value; }
        public long Celular { get => celular; set => celular = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public int NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
    }
}
