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
    class AgendaDAO
    {
        SQLiteConnection bd = Database.GetInstance().GetConnection();
        public void Create(Agenda a)
        {
            Database dbCliente = Database.GetInstance();
            string dataSQL = a.Data.ToString("yyyy-MM-dd");

            string qry = string.Format("INSERT INTO Agenda(nome, data, telefone, ativo) " +
                "VALUES('{0}', '{1}', '{2}', '{3}')",
                a.Nome, dataSQL, a.Telefone, a.Ativo);

            dbCliente.ExecuteNonQuery(qry);
        }

        public Agenda Read(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Agenda WHERE id=" + id + " AND ativo = 1";
            DataSet ds = bd.ExecuteQuery(qry);
            Agenda a = new Agenda();
            DataRow dr = ds.Tables[0].Rows[0];
            int aux;

            a.Id = int.Parse(dr["id"].ToString());
            a.Nome = dr["nome"].ToString();
            a.Data = DateTime.Parse(dr["data"].ToString()).Date;
            a.Telefone = Int64.Parse(dr["telefone"].ToString());
            aux = int.Parse(dr["ativo"].ToString());
            if(aux == 1)
            {
                a.Ativo = true;
            }
            else
            {
                a.Ativo = false;
            }

            return a;
        }

        public void Update(Agenda a, int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Agenda SET id='{0}', nome = '{1}', data = '{2}', telefone = '{3}',  ativo = '{4}'"
            + " WHERE id = '{5}'",
            a.Id, a.Nome, a.Data.Date, a.Telefone, a.Ativo, id);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(int id)
        {
            Database db = Database.GetInstance();
            string qry = "UPDATE Agenda SET ativo = 0 WHERE id=" + id;

            db.ExecuteNonQuery(qry);
        }

        public List<Agenda> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Agenda WHERE ativo = 'True'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Agenda> agenda = new List<Agenda>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Agenda a = new Agenda();


                a.Id = int.Parse(dr["id"].ToString());
                a.Nome = dr["nome"].ToString();
                a.Data = DateTime.Parse(dr["data"].ToString()).Date;
                a.Telefone = Int64.Parse(dr["telefone"].ToString());
                aux = int.Parse(dr["ativo"].ToString());
                if (aux == 1)
                {
                    a.Ativo = true;
                }
                else
                {
                    a.Ativo = false;
                }

                agenda.Add(a);
            }
            return agenda;
        }


        public List<Agenda> ListHistorico()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Agenda";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Agenda> agenda = new List<Agenda>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Agenda a = new Agenda();


                a.Id = int.Parse(dr["id"].ToString());
                a.Nome = dr["nome"].ToString();
                a.Data = DateTime.Parse(dr["data"].ToString()).Date;
                a.Telefone = Int64.Parse(dr["telefone"].ToString());
                aux = int.Parse(dr["ativo"].ToString());
                if (aux == 1)
                {
                    a.Ativo = true;
                }
                else
                {
                    a.Ativo = false;
                }

                agenda.Add(a);
            }
            return agenda;
        }
    }

}
