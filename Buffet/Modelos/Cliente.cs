using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet
{
    class Cliente
    {
        private string nome, endereco;
        private long cpf, telefone, celular;
        private DateTime dataNasc;
        private int numeroCasa;

        public Cliente(string nome, string endereco, long cpf, long telefone, DateTime dataNasc,long celular, int numeroCasa)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.DataNasc = dataNasc;
            this.Celular = celular;
            this.NumeroCasa = numeroCasa;
        }

        public Cliente()
        {

        }

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
    }
}
