using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.MISC
{
    interface IDAO
    {
        void Create();

        void Update(Cliente c);

        Cliente Read(string cpf);

        void Delete(long cpf);

        List<Cliente> List();

        List<Cliente> ListByName(string nome);

        List<Cliente> ListByCPF(long cpf);
    }
}
