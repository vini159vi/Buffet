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
    {   /*
        SQLiteConnection bd = Database.GetInstance().GetConnection();
        public void Create(ClienteFisico cf)
        {
            Database dbCliente = Database.GetInstance();

            string qry = string.Format("INSERT INTO ClienteFisico(nome, cpf, rg, telefone, celular, dataNasc, endereco, bairro, numeroCasa, tipo) VALUES("
               + "@Nome,@CPF,@RG,@Telefone,@Celular,@DataNasc,@Endereco,@Bairro,@NumeroCasa,@Tipo)");

            SQLiteCommand comm = new SQLiteCommand(qry, bd);

            comm.Parameters.AddWithValue("@Nome", cf.Nome);
            comm.Parameters.AddWithValue("@CPF", cf.Cpf);
            comm.Parameters.AddWithValue("@RG", cf.Rg);
            comm.Parameters.AddWithValue("@Telefone", cf.Telefone);
            comm.Parameters.AddWithValue("@Celular", cf.Celular);
            comm.Parameters.AddWithValue("@DataNasc", cf.DataNasc);
            comm.Parameters.AddWithValue("@Endereco", cf.Endereco);
            comm.Parameters.AddWithValue("@Bairro", cf.Bairro);
            comm.Parameters.AddWithValue("@NumeroCasa", cf.NumeroCasa);
            comm.Parameters.AddWithValue("@Tipo", cf.Tipo);

            dbCliente.ExecuteNonQuery(qry);
        }

        public ClienteFisico Read(string cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisico WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);
            ClienteFisico cf = new ClienteFisico();
            DataRow dr = ds.Tables[0].Rows[0];

            cf.Nome = dr["nome"].ToString();
            cf.Cpf = long.Parse(dr["cpf"].ToString());
            cf.Cep = long.Parse(dr["cep"].ToString());
            cf.Cidade = dr["cidade"].ToString();
            cf.Rua = dr["rua"].ToString();
            cf.Bairro = dr["bairro"].ToString();
            cf.Estado = dr["estado"].ToString();
            cf.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
            cf.Tipo = int.Parse(dr["tipo"].ToString());

            return cf;
        }

        public void Update(ClienteFisico cj)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE ClienteJuridico SET nomeEmpresa=@NomeEmpresa, cnpj = @CNPJ, cep = @Cep, cidade = @Cidade,  rua = @Rua, bairro= @Bairro, estado = @Estado, numeroEmpresa = @NumeroEmpresa, tipo = @Tipo"
            + " WHERE cnpj = @CNPJ");
            SQLiteCommand comm = new SQLiteCommand(qry, bd);

            comm.Parameters.AddWithValue("@NomeEmpresa", cj.NomeEmpresa);
            comm.Parameters.AddWithValue("@CNPJ", cj.Cnpj);
            comm.Parameters.AddWithValue("@Cep", cj.Cep);
            comm.Parameters.AddWithValue("@Cidade", cj.Cidade);
            comm.Parameters.AddWithValue("@Rua", cj.Rua);
            comm.Parameters.AddWithValue("@Bairro", cj.Bairro);
            comm.Parameters.AddWithValue("@Estado", cj.Estado);
            comm.Parameters.AddWithValue("@NumeroEmpresa", cj.NumeroEmpresa);
            comm.Parameters.AddWithValue("@Tipo", cj.Tipo);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(long cnpj)
        {
            Database db = Database.GetInstance();
            string qry = "DELETE FROM ClienteJuridico WHERE cnpj =" + cnpj;

            db.ExecuteNonQuery(qry);
        }

        public List<ClienteFisico> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteFisico> clientes = new List<ClienteFisico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ClienteFisico cj = new ClienteFisico();


                cj.NomeEmpresa = dr["nomeEmpresa"].ToString();
                cj.Cnpj = long.Parse(dr["cnpj"].ToString());
                cj.Cep = long.Parse(dr["cep"].ToString());
                cj.Cidade = dr["cidade"].ToString();
                cj.Rua = dr["rua"].ToString();
                cj.Bairro = dr["bairro"].ToString();
                cj.Estado = dr["estado"].ToString();
                cj.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
                cj.Tipo = int.Parse(dr["tipo"].ToString());

                clientes.Add(cj);
            }
            return clientes;
        }

        public List<ClienteFisico> ListByCNPJ(long cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico WHERE cnpj=" + cnpj;
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteFisico> clientes = new List<ClienteFisico>();
            ClienteFisico cj = new ClienteFisico();

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
                    cj.Tipo = int.Parse(dr["tipo"].ToString());
                }
            }
            clientes.Add(cj);
            return clientes;
        }

        public List<ClienteFisico> ListByName(string nomeEmpresa)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico WHERE nomeEmpresa LIKE '%" + nomeEmpresa + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteFisico> clientes = new List<ClienteFisico>();
            ClienteFisico cj = new ClienteFisico();

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
                    cj.Tipo = int.Parse(dr["tipo"].ToString());
                }
            }
            clientes.Add(cj);
            return clientes;
        }*/
    }
}
