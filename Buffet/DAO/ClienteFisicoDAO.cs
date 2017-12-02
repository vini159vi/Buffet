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
    class ClienteFisicoDAO
    {
        SQLiteConnection bd = Database.GetInstance().GetConnection();
        public void Create(ClienteFisico cf)
        {
            Database dbCliente = Database.GetInstance();
            string dt = cf.DataCriacao.ToString("yyyy-MM-dd");
            string qry = String.Format("INSERT INTO ClienteFisico(nome, nacionalidade, estadoCivil, profissao, cpf, rg, telefone, cep, rua, bairro, cidade, estado, numeroCasa, celular, dataCriacao, cnpjEmpresa) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", 
                cf.Nome, cf.Nacionalidade, cf.EstadoCivil, cf.Profissao, cf.Cpf, cf.Rg, cf.Telefone, cf.Cep, cf.Rua, cf.Bairro, cf.Cidade, cf.Estado, cf.NumeroCasa, cf.Celular, dt, cf.Empresa.Cnpj);

            SQLiteCommand comm = new SQLiteCommand(qry, bd);
            dbCliente.ExecuteNonQuery(qry);
        }
    
        public ClienteFisico Read(string cpf)
        {
            ClienteFisico cf = new ClienteFisico();
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisico WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);

            DataRow dr = ds.Tables[0].Rows[0];

            cf.Nome = dr["nome"].ToString();
            cf.Nacionalidade = dr["nacionalidade"].ToString();
            cf.EstadoCivil = dr["estadoCivil"].ToString();
            cf.Profissao = dr["profissao"].ToString();
            cf.Cpf = long.Parse(dr["cpf"].ToString());
            cf.Rg = dr["rg"].ToString();
            cf.Telefone = long.Parse(dr["Telefone"].ToString());
            cf.Cep = long.Parse(dr["cep"].ToString());
            cf.Rua = dr["rua"].ToString();
            cf.Bairro = dr["bairro"].ToString();
            cf.Cidade = dr["cidade"].ToString();
            cf.Estado = dr["estado"].ToString();
            cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
            cf.Celular = long.Parse(dr["celular"].ToString());
            cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
            cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

            return cf;
        }

        public void Update(ClienteFisico cf, long cpf)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE ClienteFisico SET nome='{0}', nacionalidade='{1}', estadoCivil='{2}', profissao='{3}', cpf='{4}', rg='{5}', telefone='{6}', cep='{7}', rua='{8}', bairro='{9}', cidade='{10}', estado='{11}', numeroCasa='{12}', celular='{13}', dataCriacao = '{14}', cnpjEmpresa = '{15}'"
            + " WHERE cpf = '{16}'",
            cf.Nome, cf.Nacionalidade, cf.EstadoCivil, cf.Profissao, cf.Cpf, cf.Rg, cf.Telefone, cf.Cep, cf.Rua, cf.Bairro, cf.Cidade, cf.Estado, cf.NumeroCasa, cf.Celular, cf.DataCriacao.Date, cf.Empresa.Cnpj ,cpf);
            SQLiteCommand comm = new SQLiteCommand(qry, bd);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(long cpf)
        {
            Database db = Database.GetInstance();
            string qry = "DELETE FROM ClienteFisico WHERE cpf =" + cpf;

            db.ExecuteNonQuery(qry);
        }

        public List<ClienteFisico> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisico";
            DataSet ds = bd.ExecuteQuery(qry);
            List <ClienteFisico> fisicos = new List<ClienteFisico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ClienteFisico cf = new ClienteFisico();


                cf.Nome = dr["nome"].ToString();
                cf.Nacionalidade = dr["nacionalidade"].ToString();
                cf.EstadoCivil = dr["estadoCivil"].ToString();
                cf.Profissao = dr["profissao"].ToString();
                cf.Cpf = long.Parse(dr["cpf"].ToString());
                cf.Rg = dr["rg"].ToString();
                cf.Telefone = long.Parse(dr["Telefone"].ToString());
                cf.Cep = long.Parse(dr["cep"].ToString());
                cf.Rua = dr["rua"].ToString();
                cf.Bairro = dr["bairro"].ToString();
                cf.Cidade = dr["cidade"].ToString();
                cf.Estado = dr["estado"].ToString();
                cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                cf.Celular = long.Parse(dr["celular"].ToString());
                cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

                fisicos.Add(cf);
            }
            return fisicos;
        }

        public List<ClienteFisico> ListByCPF(long cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisico WHERE cpf LIKE '%" + cpf + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteFisico> fisicos = new List<ClienteFisico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ClienteFisico cf = new ClienteFisico();

                cf.Nome = dr["nome"].ToString();
                cf.Nacionalidade = dr["nacionalidade"].ToString();
                cf.EstadoCivil = dr["estadoCivil"].ToString();
                cf.Profissao = dr["profissao"].ToString();
                cf.Cpf = long.Parse(dr["cpf"].ToString());
                cf.Rg = dr["rg"].ToString();
                cf.Telefone = long.Parse(dr["Telefone"].ToString());
                cf.Cep = long.Parse(dr["cep"].ToString());
                cf.Rua = dr["rua"].ToString();
                cf.Bairro = dr["bairro"].ToString();
                cf.Cidade = dr["cidade"].ToString();
                cf.Estado = dr["estado"].ToString();
                cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                cf.Celular = long.Parse(dr["celular"].ToString());
                cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

                fisicos.Add(cf);
            }
            return fisicos;
        }

        public List<ClienteFisico> ListByName(string nome)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisico WHERE nome LIKE '%" + nome + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteFisico> fisicos = new List<ClienteFisico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ClienteFisico cf = new ClienteFisico();

                cf.Nome = dr["nome"].ToString();
                cf.Nacionalidade = dr["nacionalidade"].ToString();
                cf.EstadoCivil = dr["estadoCivil"].ToString();
                cf.Profissao = dr["profissao"].ToString();
                cf.Cpf = long.Parse(dr["cpf"].ToString());
                cf.Rg = dr["rg"].ToString();
                cf.Telefone = long.Parse(dr["Telefone"].ToString());
                cf.Cep = long.Parse(dr["cep"].ToString());
                cf.Rua = dr["rua"].ToString();
                cf.Bairro = dr["bairro"].ToString();
                cf.Cidade = dr["cidade"].ToString();
                cf.Estado = dr["estado"].ToString();
                cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                cf.Celular = long.Parse(dr["celular"].ToString());
                cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

                fisicos.Add(cf);
            }
            return fisicos;
        }

        public ClienteFisico FindByCPF(long cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisico WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);
            ClienteFisico cf = new ClienteFisico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (long.Parse(dr["cpf"].ToString()) == cpf)
                {
                    cf.Nome = dr["nome"].ToString();
                    cf.Nacionalidade = dr["nacionalidade"].ToString();
                    cf.EstadoCivil = dr["estadoCivil"].ToString();
                    cf.Profissao = dr["profissao"].ToString();
                    cf.Cpf = long.Parse(dr["cpf"].ToString());
                    cf.Rg = dr["rg"].ToString();
                    cf.Telefone = long.Parse(dr["Telefone"].ToString());
                    cf.Cep = long.Parse(dr["cep"].ToString());
                    cf.Rua = dr["rua"].ToString();
                    cf.Bairro = dr["bairro"].ToString();
                    cf.Cidade = dr["cidade"].ToString();
                    cf.Estado = dr["estado"].ToString();
                    cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                    cf.Celular = long.Parse(dr["celular"].ToString());
                    cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                    cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

                }
            }
            return cf;
        }

        public List<ClienteFisico> ListHistorico()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisicoHistorico";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteFisico> fisicos = new List<ClienteFisico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ClienteFisico cf = new ClienteFisico();


                cf.Nome = dr["nome"].ToString();
                cf.Nacionalidade = dr["nacionalidade"].ToString();
                cf.EstadoCivil = dr["estadoCivil"].ToString();
                cf.Profissao = dr["profissao"].ToString();
                cf.Cpf = long.Parse(dr["cpf"].ToString());
                cf.Rg = dr["rg"].ToString();
                cf.Telefone = long.Parse(dr["Telefone"].ToString());
                cf.Cep = long.Parse(dr["cep"].ToString());
                cf.Rua = dr["rua"].ToString();
                cf.Bairro = dr["bairro"].ToString();
                cf.Cidade = dr["cidade"].ToString();
                cf.Estado = dr["estado"].ToString();
                cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                cf.Celular = long.Parse(dr["celular"].ToString());
                cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

                fisicos.Add(cf);
            }
            return fisicos;
        }


        public List<ClienteFisico> ListByCpfHistorico(long cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisicoHistorico WHERE cpf LIKE '%" + cpf + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteFisico> fisicos = new List<ClienteFisico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ClienteFisico cf = new ClienteFisico();

                cf.Nome = dr["nome"].ToString();
                cf.Nacionalidade = dr["nacionalidade"].ToString();
                cf.EstadoCivil = dr["estadoCivil"].ToString();
                cf.Profissao = dr["profissao"].ToString();
                cf.Cpf = long.Parse(dr["cpf"].ToString());
                cf.Rg = dr["rg"].ToString();
                cf.Telefone = long.Parse(dr["Telefone"].ToString());
                cf.Cep = long.Parse(dr["cep"].ToString());
                cf.Rua = dr["rua"].ToString();
                cf.Bairro = dr["bairro"].ToString();
                cf.Cidade = dr["cidade"].ToString();
                cf.Estado = dr["estado"].ToString();
                cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                cf.Celular = long.Parse(dr["celular"].ToString());
                cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

                fisicos.Add(cf);
            }
            return fisicos;
        }

    }
}
