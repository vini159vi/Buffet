using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    class Cardapio
    {
        private int id;
        List<Item> entrada = new List<Item>();
        List<Item> jantar = new List<Item>();
        List<Item> serviços = new List<Item>();
        private double totalValor;

        public Cardapio(int id, List<Item> entrada, List<Item> jantar, List<Item> serviços, double totalValor)
        {
            this.Id = id;
            this.Entrada = entrada;
            this.Jantar = jantar;
            this.Serviços = serviços;
            this.TotalValor = totalValor;
        }

        public Cardapio()
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

        public double TotalValor
        {
            get
            {
                return totalValor;
            }
            set
            {
                totalValor = value;
            }
        }
        internal List<Item> Entrada
        {
            get
            {
                return entrada;
            }
            set
            {
                entrada = value;
            }
        }
        internal List<Item> Jantar
        {
            get
            {
                return jantar;
            }
            set
            {
                jantar = value;
            }
        }
        internal List<Item> Serviços
        {
            get
            {
                return serviços;
            }
            set
            {
                serviços = value;
            }
        }
    }
}
