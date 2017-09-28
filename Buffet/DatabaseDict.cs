using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Buffet
{
    class DatabaseDict : IDatabase
    {
        private static Dictionary<long, Cliente> clientes = new Dictionary<long, Cliente>();

        public void Delete(long cpf)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListAll()
        {
            List<Cliente> c = new List<Cliente>();
            foreach(KeyValuePair<long,Cliente> cl in clientes)
            {
                c.Add(cl.Value);
            }
            return c;
        }

        public List<Cliente> ListByCPF(long cpf)
        {
            List<Cliente> c = new List<Cliente>();
            foreach(KeyValuePair<long, Cliente> cl in clientes)
            {
                if (cl.Value.Cpf.Equals(cpf))
                    c.Add(cl.Value);
            }
            return c;
        }

        public List<Cliente> ListByName(string nome)
        {
            List<Cliente> c = new List<Cliente>();
            foreach (KeyValuePair<long, Cliente> cl in clientes)
            {
                if (cl.Value.Nome.Contains(nome))
                    c.Add(cl.Value);
            }
            return c;
        }

        public Cliente Read(long cpf)
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente c)
        {
            clientes.Add(c.Cpf, c);
        }

        public void Update(Cliente c)
        {
            throw new NotImplementedException();
        }
    }
}
