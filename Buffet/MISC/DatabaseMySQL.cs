using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Buffet
{
    class DatabaseMySQL : IDatabase
    {
        MySqlConnection bd = new MySqlConnection();

        public void Delete(long cpf)
        {
            bd.ConnectionString = SetupMySql() ;
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
                cl.Celular = dr.GetInt64(5);
                cl.NumeroCasa = dr.GetInt32(6);
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

            string sql = String.Format("INSERT INTO Cliente (nome, endereco, cpf, telefone, dataNasc, celular, numeroCasa) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", c.Nome,c.Endereco,c.Cpf,c.Telefone,c.DataNasc.ToString("yyyy-MM-dd"),c.Telefone,c.NumeroCasa);

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
