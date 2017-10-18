using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet
{
    interface IDatabase
    {
        void Save(Cliente c);

        void Update(Cliente c);

        Cliente Read(long cpf);

        void Delete(long cpf);

        List<Cliente> ListAll();

        List<Cliente> ListByName(string nome);

        List<Cliente> ListByCPF(long cpf);
    }
}
