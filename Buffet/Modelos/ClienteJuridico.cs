using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    public class ClienteJuridico
    {
        private string nomeEmpresa, cidade, rua, bairro, estado;
        private long cep, cnpj;
        private int numeroEmpresa, tipo;

        public string NomeEmpresa
        {
            get
            {
                return nomeEmpresa;
            }

            set
            {
                nomeEmpresa = value;
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

        public long Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public int NumeroEmpresa
        {
            get
            {
                return numeroEmpresa;
            }

            set
            {
                numeroEmpresa = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;

            }
        }


        public ClienteJuridico(string nomeEmpresa, string cidade, string rua, string bairro, string estado, long cep, long cnpj, int numeroEmpresa, int tipo)
        {
            this.NomeEmpresa = nomeEmpresa;
            this.Cidade = cidade;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Estado = estado;
            this.Cep = cep;
            this.Cnpj = cnpj;
            this.NumeroEmpresa = numeroEmpresa;
            this.Tipo = tipo;
        }

        public ClienteJuridico()
        {
        }
    }
}
