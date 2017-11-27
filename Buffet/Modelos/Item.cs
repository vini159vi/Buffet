using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    class Item
    {
        private int id, tipo;
        private string nome;
        private double valorCabeca;

        public Item(int id, int tipo, string nome, double valorCabeca)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Nome = nome;
            this.ValorCabeca = valorCabeca;
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
        public int Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public double ValorCabeca
        {
            get
            {
                return valorCabeca;
            }
            set
            {
                valorCabeca = value;
            }
        }
    }
}
