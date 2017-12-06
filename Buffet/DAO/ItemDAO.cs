using Buffet.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO
{
    class ItemDAO
    {
        public void Create(Item i)
        {
            Database dbCliente = Database.GetInstance();
            string aux = i.ValorCabeca.ToString();


            string qry = string.Format("INSERT INTO Item(nome, valorPessoa, tipo) " +
                "VALUES('{0}', '{1}', '{2}')",
                i.Nome, aux.Replace(",", "."), i.Tipo);

            dbCliente.ExecuteNonQuery(qry);
        }

        public Item Read(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Item WHERE id=" + id;
            DataSet ds = bd.ExecuteQuery(qry);
            Item i = new Item();
            DataRow dr = ds.Tables[0].Rows[0];

            i.Id = int.Parse(dr["id"].ToString());
            i.Nome = dr["nome"].ToString();
            i.ValorCabeca = double.Parse(dr["valorPessoa"].ToString());
            i.Tipo = int.Parse(dr["tipo"].ToString());

            return i;
        }

        public void Update(Item i, int id)
        {
            string aux = i.ValorCabeca.ToString();
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Item SET nome = '{0}', valorPessoa = '{1}', tipo = '{2}'"
            + " WHERE id = '{3}'",
            i.Nome, aux.Replace(",", "."), i.Tipo, id);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(int id)
        {
            Database db = Database.GetInstance();
            string qry = "DELETE FROM Item WHERE id =" + id;

            db.ExecuteNonQuery(qry);
        }

        public List<Item> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Item";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Item> itens = new List<Item>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Item i = new Item();


                i.Id = int.Parse(dr["id"].ToString());
                i.Nome = dr["nome"].ToString();
                i.ValorCabeca = double.Parse(dr["valorPessoa"].ToString());
                i.Tipo = int.Parse(dr["tipo"].ToString());

                itens.Add(i);
            }
            return itens;
        }

        public bool Verifica(int id, int tipo)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT i.id FROM Item i JOIN itemDoCardapio idc ON idc.idItem=i.id JOIN Cardapio c ON c.id=idc.idCardapio WHERE i.id="+id+" AND c.id="+tipo;
            DataSet ds = bd.ExecuteQuery(qry);
            DataRow dr;
            try
            {
                dr = ds.Tables[0].Rows[0];
            }
            catch
            {
                return false;
            }

            Item i = new Item(); 

            if(dr["id"].ToString() != null)
            {
                i.Id = int.Parse(dr["id"].ToString());
                if (i.Id == id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool VerificaTipo(int tipo, int tipo2)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT i.tipo FROM Item i JOIN itemDoCardapio idc ON idc.idItem=i.id JOIN Cardapio c ON c.id=idc.idCardapio WHERE i.tipo=" + tipo + " AND c.id=" + tipo2;
            DataSet ds = bd.ExecuteQuery(qry);
            DataRow dr;
            try
            {
                dr = ds.Tables[0].Rows[0];
            }
            catch
            {
                return false;
            }

            Item i = new Item();

            if (dr["tipo"].ToString() != null)
            {
                i.Id = int.Parse(dr["tipo"].ToString());
                if (i.Tipo == tipo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void AdicionarNoCardapio(int id,int tipo)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("INSERT INTO ItemDoCardapio(idItem, idCardapio) " +
                "VALUES('{0}', '{1}')",
                id, tipo);
            db.ExecuteNonQuery(qry);
        }

        public void RemoverDoCardapio(int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("DELETE FROM ItemDoCardapio WHERE idItem="+id);
            db.ExecuteNonQuery(qry);
        }
    }
}
