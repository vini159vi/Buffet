using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Buffet
{
    class ClienteDAO
    {
        MySqlConnection bd = new MySqlConnection();

        public void Create(Cliente c)
        {
            Database dbCliente = Database.GetInstance();
            string qry = string.Format("INSERT INTO Cliente(nome, endereco, cpf, telefone, dataNasc) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                c.Nome, c.Endereco, c.Cpf, c.Telefone, c.DataNasc.ToString("yyyy - MM - dd"));
            dbCliente.ExecuteNonQuery(qry);
        }

        public Cliente Read(string cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM cliente WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);
            Cliente c = new Cliente();
            DataRow dr = ds.Tables[0].Rows[0];
            c.Cpf = long.Parse(dr["cpf"].ToString());
            c.Nome = dr["nome"].ToString();
            c.DataNasc = DateTime.Parse(dr["dataNasc"].ToString());
            c.Celular = long.Parse(dr["celular"].ToString());
            c.NumeroCasa = int.Parse(dr["numerocasa"].ToString());
            c.Telefone = long.Parse(dr["telefone"].ToString());
            c.Endereco = dr["endereco"].ToString();
            return c;
        }

        /*public void Update(Cliente c)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE cliente SET nome='{0}', cpf = '{1}', dtnasc = '{2}' "
            + " WHERE codigo = {3}", a.Nome, aluno.Cpf,
            a.DataNascimento.ToString("
            yyyy - MM - dd"), a.Codigo);
            db.ExecuteNonQuery(qry);
        }*/

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

            string sql = String.Format("INSERT INTO Cliente (nome, endereco, cpf, telefone, dataNasc, celular, numeroCasa) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", c.Nome, c.Endereco, c.Cpf, c.Telefone, c.DataNasc.ToString("yyyy-MM-dd"),c.Celular, c.NumeroCasa);

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
