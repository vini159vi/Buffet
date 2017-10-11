using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    class ClienteJuridico
    {
        private string nomeEmpresa, cidade, rua, bairro, estado;
        private long cep, cnpj;
        private int numeroEmpresa;

        public ClienteJuridico(string nomeEmpresa, string cidade, string rua, string bairro, string estado, long cep, long cnpj, int numeroEmpresa)
        {
            this.NomeEmpresa = nomeEmpresa;
            this.Cidade = cidade;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Estado = estado;
            this.Cep = cep;
            this.Cnpj = cnpj;
            this.NumeroEmpresa = numeroEmpresa;
        }

        public string NomeEmpresa { get => nomeEmpresa; set => nomeEmpresa = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Estado { get => estado; set => estado = value; }
        public long Cep { get => cep; set => cep = value; }
        public long Cnpj { get => cnpj; set => cnpj = value; }
        public int NumeroEmpresa { get => numeroEmpresa; set => numeroEmpresa = value; }
    }
}
