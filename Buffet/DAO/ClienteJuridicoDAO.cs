
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

            string qry = string.Format("INSERT INTO ClienteJuridico(nomeEmpresa, cnpj, cep, cidade, rua, bairro, estado, numeroEmpresa, tipo) "+
                "VALUES(@NomeEmpresa, @CNPJ, @Cep, @Cidade, @Rua, @Bairro, @Estado, @NumeroEmpresa, @Tipo)");


            SQLiteCommand comm = new SQLiteCommand(qry, bd);

            /*comm.Parameters.Add(new SQLiteParameter("@NomeEmpresa",cj.NomeEmpresa));
            comm.Parameters.Add(new SQLiteParameter("@CNPJ", cj.Cnpj));
            comm.Parameters.Add(new SQLiteParameter("@Cep", cj.Cep));
            comm.Parameters.Add(new SQLiteParameter("@Cidade", cj.Cidade));
            comm.Parameters.Add(new SQLiteParameter("@Rua", cj.Rua));
            comm.Parameters.Add(new SQLiteParameter("@Bairro", cj.Bairro));
            comm.Parameters.Add(new SQLiteParameter("@Estado", cj.Estado));
            comm.Parameters.Add(new SQLiteParameter("@NumeroEmpresa", cj.NumeroEmpresa));
            comm.Parameters.Add(new SQLiteParameter("@Tipo", cj.Tipo));*/

            comm.Parameters.AddWithValue("@NomeEmpresa", cj.NomeEmpresa);
            comm.Parameters.AddWithValue("@CNPJ", cj.Cnpj);
            comm.Parameters.AddWithValue("@Cep", cj.Cep);
            comm.Parameters.AddWithValue("@Cidade", cj.Cidade);
            comm.Parameters.AddWithValue("@Rua", cj.Rua);
            comm.Parameters.AddWithValue("@Bairro", cj.Bairro);
            comm.Parameters.AddWithValue("@Estado", cj.Estado);
            comm.Parameters.AddWithValue("@NumeroEmpresa", cj.NumeroEmpresa);
            comm.Parameters.AddWithValue("@Tipo", cj.Tipo);

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
            cj.Tipo = int.Parse(dr["tipo"].ToString());

            return cj;
        }

        public void Update(ClienteJuridico cj)
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
                cj.Tipo = int.Parse(dr["tipo"].ToString());

                clientes.Add(cj);
            }
            return clientes;
        }

        public List<ClienteJuridico> ListByCNPJ(long cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico WHERE cnpj=" + cnpj;
            DataSet ds = bd.ExecuteQuery(qry);
            List<ClienteJuridico> clientes = new List<ClienteJuridico>();
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
                    cj.Tipo = int.Parse(dr["tipo"].ToString());
                }
            }
            clientes.Add(cj);
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
                    cj.Tipo = int.Parse(dr["tipo"].ToString());
                }
            }
            clientes.Add(cj);
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
                    cj.Tipo = int.Parse(dr["tipo"].ToString());
                }
            }
            return cj;
        }
    }
}
