using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    public class ClienteFisico
    {
        private string nome, nacionalidade, estadoCivil, profissao, rua, bairro, cidade, estado, rg;
        private long cpf, cep, telefone, celular;
        private int numeroCasa;
        private DateTime dataCriacao;

        ClienteJuridico empresa = new ClienteJuridico();

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

        public string Nacionalidade
        {
            get
            {
                return nacionalidade;
            }

            set
            {
                nacionalidade = value;
            }
        }

        public string EstadoCivil
        {
            get
            {
                return estadoCivil;
            }

            set
            {
                estadoCivil = value;
            }
        }

        public string Profissao
        {
            get
            {
                return profissao;
            }

            set
            {
                profissao = value;
            }
        }

        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                rua = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public long Cpf
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

        public long Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public long Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public int NumeroCasa
        {
            get
            {
                return numeroCasa;
            }

            set
            {
                numeroCasa = value;
            }
        }

        public long Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public DateTime DataCriacao
        {
            get
            {
                return dataCriacao;
            }
            set
            {
                dataCriacao = value;
            }
        }
        public ClienteJuridico Empresa
        {
            get
            {
                return empresa;
            }
            set
            {
                empresa = value;
            }
        }

        public ClienteFisico(string nome, string nacionalidade, string estadoCivil, string profissao, string rua, string bairro, string cidade, string estado, string rg, long cpf, long cep, long telefone, int numeroCasa, long celular, DateTime dataCriacao, ClienteJuridico empresa)
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
            this.Telefone = telefone;
            this.NumeroCasa = numeroCasa;
            this.Celular = celular;
            this.DataCriacao = dataCriacao;
            this.Empresa = empresa;
        }

        public ClienteFisico()
        {

        }
    }

}
