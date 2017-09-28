using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Buffet
{
    public partial class FormCadastrados : Form
    {
            
        public FormCadastrados()
        {
            InitializeComponent();
            Fill();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente tela = new FormCadastroCliente();
            tela.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FormCadastrados_Load(object sender, EventArgs e)
        {

        }

        private void gbLista_Enter(object sender, EventArgs e)
        {
            
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            Fill();
        }
        public void Fill()
        {
            IDatabase clientes = new DatabaseMySQL();
            List<Cliente> listc = clientes.ListAll();

            dataGViewLista.Rows.Clear();

            foreach (Cliente c in listc)
            {
                dataGViewLista.Rows.Add(c.Nome, c.Cpf, c.Endereco, c.DataNasc, c.Telefone);
            }

        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            IDatabase clientes = new DatabaseMySQL();
            int index = dataGViewLista.CurrentCell.ColumnIndex;
            clientes.Delete(long.Parse(dataGViewLista.Rows[index].Cells[1].Value.ToString()));
        }
    }
}
