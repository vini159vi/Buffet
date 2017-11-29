
using Buffet.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO
{
    class ClienteJuridicoDAO
    {
        SQLiteConnection bd = Database.GetInstance().GetConnection();
        public void Create(ClienteJuridico cj)
        { 
            Database dbCliente = Database.GetInstance();

            string qry = string.Format("INSERT INTO ClienteJuridico(nomeEmpresa, cnpj, cep, cidade, rua, bairro, estado, numeroEmpresa, dataCriacao) "+
                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                cj.NomeEmpresa, cj.Cnpj, cj.Cep, cj.Cidade, cj.Rua, cj.Bairro, cj.Estado, cj.NumeroEmpresa, cj.DataCriacao.Date);

            dbCliente.ExecuteNonQuery(qry);
        }

        public ClienteJuridico Read(string cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico WHERE cnpj=" + cnpj;
            DataSet ds = bd.ExecuteQuery(qry);
            ClienteJuridico cj = new ClienteJuridico();
            DataRow dr = ds.Tables[0].Rows[0];

            cj.NomeEmpresa = dr["nomeEmpresa"].ToString();
            cj.Cnpj = long.Parse(dr["cnpj"].ToString());
            cj.Cep = long.Parse(dr["cep"].ToString());
            cj.Cidade = dr["cidade"].ToString();
            cj.Rua = dr["rua"].ToString();
            cj.Bairro = dr["bairro"].ToString();
            cj.Estado = dr["estado"].ToString();
            cj.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
            cj.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
            return cj;
        }

        public void Update(ClienteJuridico cj, long cnpj)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE ClienteJuridico SET nomeEmpresa='{0}', cnpj = '{1}', cep = '{2}', cidade = '{3}',  rua = '{4}', bairro= '{5}', estado = '{6}', numeroEmpresa = '{7}', dataCriacao = '{8}'"
            + " WHERE cnpj = '{9}'",
            cj.NomeEmpresa, cj.Cnpj, cj.Cep, cj.Cidade, cj.Rua, cj.Bairro, cj.Estado, cj.NumeroEmpresa, cj.DataCriacao, cnpj);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(long cnpj)
        {
            Database db = Database.GetInstance();
            string qry = "DELETE FROM ClienteJuridico WHERE cnpj =" + cnpj;

            db.ExecuteNonQuery(qry);
        }

        public List<ClienteJuridico> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteJuridico> clientes = new List<ClienteJuridico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ClienteJuridico cj = new ClienteJuridico();


                cj.NomeEmpresa = dr["nomeEmpresa"].ToString();
                cj.Cnpj = long.Parse(dr["cnpj"].ToString());
                cj.Cep = long.Parse(dr["cep"].ToString());
                cj.Cidade = dr["cidade"].ToString();
                cj.Rua = dr["rua"].ToString();
                cj.Bairro = dr["bairro"].ToString();
                cj.Estado = dr["estado"].ToString();
                cj.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
                cj.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;

                clientes.Add(cj);
            }
            return clientes;
        }

        public List<ClienteJuridico> ListByCNPJ(long cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico WHERE cnpj LIKE '%" + cnpj + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteJuridico> clientes = new List<ClienteJuridico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                ClienteJuridico cj = new ClienteJuridico();

                cj.NomeEmpresa = dr["nomeEmpresa"].ToString();
                cj.Cnpj = long.Parse(dr["cnpj"].ToString());
                cj.Cep = long.Parse(dr["cep"].ToString());
                cj.Cidade = dr["cidade"].ToString();
                cj.Rua = dr["rua"].ToString();
                cj.Bairro = dr["bairro"].ToString();
                cj.Estado = dr["estado"].ToString();
                cj.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
                cj.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;

                clientes.Add(cj);
                
            }
            return clientes;
        }

        public List<ClienteJuridico> ListByName(string nomeEmpresa)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico WHERE nomeEmpresa LIKE '%" + nomeEmpresa + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteJuridico> clientes = new List<ClienteJuridico>();
            ClienteJuridico cj = new ClienteJuridico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr["nomeEmpresa"].ToString() == nomeEmpresa)
                {
                    cj.NomeEmpresa = dr["nomeEmpresa"].ToString();
                    cj.Cnpj = long.Parse(dr["cnpj"].ToString());
                    cj.Cep = long.Parse(dr["cep"].ToString());
                    cj.Cidade = dr["cidade"].ToString();
                    cj.Rua = dr["rua"].ToString();
                    cj.Bairro = dr["bairro"].ToString();
                    cj.Estado = dr["estado"].ToString();
                    cj.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
                    cj.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;

                    clientes.Add(cj);
                }
            }
            return clientes;
        }

        public ClienteJuridico FindByCNPJ(long cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico WHERE cnpj=" + cnpj;
            DataSet ds = bd.ExecuteQuery(qry);
            ClienteJuridico cj = new ClienteJuridico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (long.Parse(dr["cnpj"].ToString()) == cnpj)
                {
                    cj.NomeEmpresa = dr["nomeEmpresa"].ToString();
                    cj.Cnpj = long.Parse(dr["cnpj"].ToString());
                    cj.Cep = long.Parse(dr["cep"].ToString());
                    cj.Cidade = dr["cidade"].ToString();
                    cj.Rua = dr["rua"].ToString();
                    cj.Bairro = dr["bairro"].ToString();
                    cj.Estado = dr["estado"].ToString();
                    cj.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
                    cj.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                }
            }
            return cj;
        }

        
        public List<RepresentanteJuridico> ListByRepresentante(long cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM RepresentanteJuridico rj " +
                "JOIN ClienteJuridico cj ON cj.Cnpj=rj.EmpresaCnpj WHERE cnpj=" + cnpj;
            DataSet ds = bd.ExecuteQuery(qry);
            RepresentanteJuridico rj = new RepresentanteJuridico();
            List<RepresentanteJuridico> listrj =  new List<RepresentanteJuridico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rj.Nome = dr["nome"].ToString();
                rj.Nacionalidade = dr["nacionalidade"].ToString();
                rj.EstadoCivil = dr["estadoCivil"].ToString();
                rj.Profissao = dr["profissao"].ToString();
                rj.Cpf = long.Parse(dr["cpf"].ToString());
                rj.Rg = long.Parse(dr["rg"].ToString());
                rj.Telefone = long.Parse(dr["Telefone"].ToString());
                rj.Cep = long.Parse(dr["cep"].ToString());
                rj.Rua = dr["rua"].ToString();
                rj.Bairro = dr["bairro"].ToString();
                rj.Cidade = dr["cidade"].ToString();
                rj.Estado = dr["estado"].ToString();
                rj.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                rj.Celular = long.Parse(dr["celular"].ToString());
                rj.Empresa.Cnpj = long.Parse(dr["empresaCnpj"].ToString());

                listrj.Add(rj);
            }
            return listrj;

        }
        
        public RepresentanteJuridico FindByRepresentante(long cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM RepresentanteJuridico rj " +
                "JOIN ClienteJuridico cj ON cj.Cnpj=rj.EmpresaCnpj WHERE cnpj=" + cnpj;
            DataSet ds = bd.ExecuteQuery(qry);
            RepresentanteJuridico rj = new RepresentanteJuridico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rj.Nome = dr["nome"].ToString();
                rj.Nacionalidade = dr["nacionalidade"].ToString();
                rj.EstadoCivil = dr["estadoCivil"].ToString();
                rj.Profissao = dr["profissao"].ToString();
                rj.Cpf = long.Parse(dr["cpf"].ToString());
                rj.Rg = long.Parse(dr["rg"].ToString());
                rj.Telefone = long.Parse(dr["Telefone"].ToString());
                rj.Cep = long.Parse(dr["cep"].ToString());
                rj.Rua = dr["rua"].ToString();
                rj.Bairro = dr["bairro"].ToString();
                rj.Cidade = dr["cidade"].ToString();
                rj.Estado = dr["estado"].ToString();
                rj.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                rj.Celular = long.Parse(dr["celular"].ToString());
                rj.Empresa.Cnpj = long.Parse(dr["empresaCnpj"].ToString());

            }
            return rj;

        }
        
    }
}
