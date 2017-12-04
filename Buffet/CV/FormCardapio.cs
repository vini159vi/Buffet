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
    public partial class FormCardapio : Form
    {
        private int check;
        public FormCardapio()
        {
            InitializeComponent();
            Fill();
        }

        private void FormCardapio_VisibleChanged(object sender, EventArgs e)
        {
            Fill();
        }
        private void Fill()
        {
            ItemDAO iDAO = new ItemDAO();
            List<Item> listI = iDAO.List();
            dgvItens.Rows.Clear();
            dgvCardapio.Rows.Clear();
            foreach (Item i in listI)
            {
                bool verifica = Filtro(i);
                if (verifica)
                {
                    int index = dgvCardapio.Rows.Add();

                    dgvCardapio.Rows[index].Cells["cellIDCardapio"].Value = i.Id;
                    dgvCardapio.Rows[index].Cells["cellNomeCardapio"].Value = i.Nome;
                    dgvCardapio.Rows[index].Cells["cellValorPessoaCardapio"].Value = i.ValorCabeca;
                    switch (i.Tipo)
                    {
                        case 0:
                            dgvCardapio.Rows[index].Cells["cellTipoCardapio"].Value = "Pratos Quentes";
                            break;
                        case 1:
                            dgvCardapio.Rows[index].Cells["cellTipoCardapio"].Value = "Salada";
                            break;
                        case 2:
                            dgvCardapio.Rows[index].Cells["cellTipoCardapio"].Value = "Fruta";
                            break;
                        case 3:
                            dgvCardapio.Rows[index].Cells["cellTipoCardapio"].Value = "Frio";
                            break;
                        case 4:
                            dgvCardapio.Rows[index].Cells["cellTipoCardapio"].Value = "Bebida";
                            break;
                        case 5:
                            dgvCardapio.Rows[index].Cells["cellTipoCardapio"].Value = "Serviço";
                            break;
                    }
                }
                else
                {
                    int index = dgvItens.Rows.Add();

                    dgvItens.Rows[index].Cells["cellID"].Value = i.Id;
                    dgvItens.Rows[index].Cells["cellNome"].Value = i.Nome;
                    dgvItens.Rows[index].Cells["cellValorPessoa"].Value = i.ValorCabeca;
                    switch (i.Tipo)
                    {
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
        }

        private bool Filtro(Item i)
        {
            ItemDAO iDAO = new ItemDAO();
            int aux=0;

            if (check == 0)
                aux = 1;
            else if (check == 1)
                aux = 2;

            if (iDAO.Verifica(i.Id,aux))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void radioBttTipo1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttTipo1.Checked)
                check = 0;

            Fill();
        }

        private void radioBttTipo2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttTipo2.Checked)
                check = 1;

            Fill();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            ItemDAO iDAO = new ItemDAO();
            int index = dgvItens.CurrentCell.RowIndex;
            int aux=0;

            if (check == 0)
                aux = 1;
            else if (check == 1)
                aux = 2;

            iDAO.AdicionarNoCardapio(int.Parse(dgvItens.Rows[index].Cells["cellID"].Value.ToString()), aux);
            Fill();
        }

        private void bttRemover_Click(object sender, EventArgs e)
        {
            ItemDAO iDAO = new ItemDAO();
            int index = dgvCardapio.CurrentCell.RowIndex;

            iDAO.RemoverDoCardapio(int.Parse(dgvCardapio.Rows[index].Cells["cellIDCardapio"].Value.ToString()));
            Fill();
        }

        private void bttSalvar_Click(object sender, EventArgs e)
        {

        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
