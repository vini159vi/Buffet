using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Fill()
        {
            DatabaseDict clientes = new DatabaseDict();
            List<Cliente> listc = clientes.ListAll();

            dataGViewLista.Rows.Clear();

            foreach (Cliente c in listc)
            {
                dataGViewLista.Rows.Add(c.Nome, c.Cpf, c.Endereco, c.DataNasc, c.Telefone);
            }

        }

    }
}
