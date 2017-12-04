using Buffet.DAO;
using Buffet.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.CV
{
    public partial class FormControleItens : Form
    {
        public FormControleItens()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            ItemDAO iDAO = new ItemDAO();
            List<Item> listI = iDAO.List();
            dgvItens.Rows.Clear();
            foreach (Item i in listI)
            {
                int index = dgvItens.Rows.Add();
                dgvItens.Rows[index].Cells["cellID"].Value = i.Id;
                dgvItens.Rows[index].Cells["cellNome"].Value = i.Nome;
                dgvItens.Rows[index].Cells["cellValorPessoa"].Value = i.ValorCabeca;
                switch(i.Tipo){
                    case 0:
                        dgvItens.Rows[index].Cells["cellTipo"].Value = "Pratos Quentes";
                        break;
                    case 1:
                        dgvItens.Rows[index].Cells["cellTipo"].Value = "Salada";
                        break;
                    case 2:
                        dgvItens.Rows[index].Cells["cellTipo"].Value = "Fruta";
                        break;
                    case 3:
                        dgvItens.Rows[index].Cells["cellTipo"].Value = "Frio";
                        break;
                    case 4:
                        dgvItens.Rows[index].Cells["cellTipo"].Value = "Bebida";
                        break;
                    case 5:
                        dgvItens.Rows[index].Cells["cellTipo"].Value = "Serviço";
                        break;
                }
            }
        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            int index = dgvItens.CurrentCell.RowIndex;
            ItemDAO iDAO = new ItemDAO();

            iDAO.Delete(int.Parse(dgvItens.Rows[index].Cells["cellID"].Value.ToString()));
            Fill();
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            int index = dgvItens.CurrentCell.RowIndex;
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormControleItens_VisibleChanged(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
