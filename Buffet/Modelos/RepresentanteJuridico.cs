using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    class RepresentanteJuridico
    {
        private string nome, nacionalidade, estadoCivil, profissao, rua, bairro, cidade, estado;
        private long rg, cpf,cep, telefone;
        private int numeroCasa;

        public RepresentanteJuridico(string nome, string nacionalidade, string estadoCivil, string profissao, string rua, string bairro, string cidade, string estado, long rg, long cpf, long cep, int numeroCasa)
        {
            this.Nome = nome;
            this.Nacionalidade = nacionalidade;
            this.EstadoCivil = estadoCivil;
            this.Profissao = profissao;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Cep = cep;
            this.NumeroCasa = numeroCasa;
            this.Telefone = telefone;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Profissao { get => profissao; set => profissao = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public long Rg { get => rg; set => rg = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public long Cep { get => cep; set => cep = value; }
        public int NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public long Telefone { get => telefone; set => telefone = value; }
    }
}
