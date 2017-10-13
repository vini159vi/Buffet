using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    public class ClienteFisico
    {
        private string nome, endereco, bairro;
        private long cpf, rg, telefone, celular, cep;
        private DateTime dataNasc;
        private int numeroCasa;

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

        public string Endereco
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

        public long Rg
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

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
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

        public ClienteFisico(string nome, string endereco, string bairro, long cpf, long rg, long telefone, long celular, DateTime dataNasc, int numeroCasa, long cep)
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
            this.Cep = cep;
        }

        public ClienteFisico()
        {
        }
    }
}
