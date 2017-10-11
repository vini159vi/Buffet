using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Buffet.MISC;

namespace Buffet
{
    class ClienteDAO
    {
        MySqlConnection bd = new MySqlConnection();

        public void Create(Cliente c)
        {
            Database dbCliente = Database.GetInstance();
            string qry = string.Format("INSERT INTO Cliente(nome, endereco, cpf, telefone, dataNasc, celular, numeroCasa) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                c.Nome, c.Endereco, c.Cpf, c.Telefone, c.DataNasc.ToString("yyyy-MM-dd"), c.Celular, c.NumeroCasa);
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

        public void Update(Cliente c)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE cliente SET nome='{0}', cpf = {1}, telefone = {2}, celular = {3},  datanasc = '{4}', endereco='{5}', numerocasa = {6} "
            + " WHERE cpf = {1}", c.Nome, c.Cpf, c.Telefone, c.Celular, c.DataNasc.ToString("yyyy - MM - dd"), c.Endereco, c.NumeroCasa);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(long cpf)
        {
            Database db = Database.GetInstance();
            string qry = "DELETE FROM Cliente WHERE cpf =" + cpf;

            db.ExecuteNonQuery(qry);
        }

        public List <Cliente> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Cliente";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente c = new Cliente();
                c.Cpf = long.Parse(dr["cpf"].ToString());
                c.Nome = dr["nome"].ToString();
                c.DataNasc = DateTime.Parse(dr["dataNasc"].ToString());
                c.Celular = long.Parse(dr["celular"].ToString());
                c.NumeroCasa = int.Parse(dr["numerocasa"].ToString());
                c.Telefone = long.Parse(dr["telefone"].ToString());
                c.Endereco = dr["endereco"].ToString();
                clientes.Add(c);
            }
            return clientes;
        }

        public List<Cliente> ListByCPF(long cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Cliente WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);
            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente c = new Cliente();
                c.Cpf = long.Parse(dr["cpf"].ToString());
                c.Nome = dr["nome"].ToString();
                c.DataNasc = DateTime.Parse(dr["dataNasc"].ToString());
                c.Celular = long.Parse(dr["celular"].ToString());
                c.NumeroCasa = int.Parse(dr["numerocasa"].ToString());
                c.Telefone = long.Parse(dr["telefone"].ToString());
                c.Endereco = dr["endereco"].ToString();
                clientes.Add(c);
            }
            return clientes;
        }

        public List<Cliente> ListByName(string nome)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Cliente WHERE nome LIKE '%"+ nome +"%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Cliente> clientes = new List<Cliente>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente c = new Cliente();
                c.Cpf = long.Parse(dr["cpf"].ToString());
                c.Nome = dr["nome"].ToString();
                c.DataNasc = DateTime.Parse(dr["dataNasc"].ToString());
                c.Celular = long.Parse(dr["celular"].ToString());
                c.NumeroCasa = int.Parse(dr["numerocasa"].ToString());
                c.Telefone = long.Parse(dr["telefone"].ToString());
                c.Endereco = dr["endereco"].ToString();
                clientes.Add(c);
            }
            return clientes;
        }

    }
}
