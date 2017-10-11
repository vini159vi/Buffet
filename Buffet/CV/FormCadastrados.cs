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
            dataGViewLista.Columns[2].DefaultCellStyle.Format = "(##) ####-####";
            dataGViewLista.Columns[3].DefaultCellStyle.Format = "(##) #####-####";
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

            foreach (Cliente c in listc)
            {
                dataGViewLista.Rows.Add(c.Nome, c.Cpf.ToString(@"000\.000\.000\-00"), c.Telefone, c.Celular, c.DataNasc.Date, c.Endereco, c.NumeroCasa);
            }

        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            IDatabase clientes = new DatabaseMySQL();

            try
            {
                int index = dataGViewLista.CurrentCell.ColumnIndex;
                clientes.Delete(long.Parse(dataGViewLista.Rows[index].Cells[1].Value.ToString()));
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Não contem nenhuma pessoa registrada","Buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Fill();
            }
        }

        private void dataGViewLista_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Fill();
        }
    }
}
