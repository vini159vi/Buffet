using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Buffet
{
    class Database
    {
        private static MySqlConnection connection;
        private static Database instance;
        private const string URL = "Server = localhost;Database = buffet;Uid = root;Pwd = ifsp;";
        MySqlConnection bd = new MySqlConnection();

        private Database()
        {
            connection = new MySqlConnection(URL);
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void ExecuteNonQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            comm.ExecuteNonQuery();
            connection.Close();
        }

        public DataSet ExecuteQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            connection.Close();
            return ds;
        }

    public void Delete(long cpf)
        {
            bd.ConnectionString = SetupMySql();
            if (bd.State != System.Data.ConnectionState.Open)
                bd.Open();
            Console.Write("Lá");
            string qry = string.Format("DELETE FROM Cliente WHERE cpf = '{0}';", cpf);
            MySqlCommand cmd = new MySqlCommand(qry, bd);
            cmd.ExecuteNonQuery();
            bd.Close();
        }

        public List<Cliente> ListAll()
        {
            List<Cliente> c = new List<Cliente>();
            bd.ConnectionString = SetupMySql();
            if (bd.State != System.Data.ConnectionState.Open)
                bd.Open();

            string qry = "SELECT * FROM Cliente";
            MySqlCommand cmd = new MySqlCommand(qry, bd);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente cl = new Cliente();
                cl.Cpf = dr.GetInt64(2);
                cl.Nome = dr.GetString(0);
                cl.Telefone = dr.GetInt64(3);
                cl.DataNasc = dr.GetDateTime(4);
                cl.Endereco = dr.GetString(1);

                c.Add(cl);
            }
            dr.Close();
            return c;
        }

        public List<Cliente> ListByCPF(long cpf)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListByName(string nome)
        {
            throw new NotImplementedException();
        }

        public Cliente Read(long cpf)
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente c)
        {
            bd.ConnectionString = SetupMySql();

            if (bd.State != System.Data.ConnectionState.Open)
                bd.Open();

            string sql = String.Format("INSERT INTO Cliente (nome, endereco, cpf, telefone, dataNasc) VALUES('{0}','{1}','{2}','{3}','{4}')", c.Nome, c.Endereco, c.Cpf, c.Telefone, c.DataNasc.ToString("yyyy-MM-dd"));

            MySqlCommand cmd = new MySqlCommand(sql, bd);
            cmd.ExecuteNonQuery();

            bd.Close();
        }

        public void Update(Cliente c)
        {
            throw new NotImplementedException();
        }

        private string SetupMySql()
        {
            return "Server = localhost;Database = buffet;Uid = root;Pwd = ifsp;";
        }
    }
}
}
