using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    class Agenda
    {
        private int id;
        private string nome;
        private DateTime data;
        private long telefone;
        private bool ativo;

        public Agenda(int id, string nome, DateTime data, long telefone, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Data = data;
            this.Telefone = telefone;
            this.Ativo = ativo;
        }

        public Agenda()
        {

        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }


        public string Nome {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public long Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }
        public bool Ativo
        {
            get
            {
                return ativo;
            }
            set
            {
                ativo = value;
            }
        }
    }
}
