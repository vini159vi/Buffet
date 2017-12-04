﻿using Buffet.DAO;
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
    public partial class FormContratoCardapio : Form
    {
        public FormContratoCardapio()
        {
            InitializeComponent();
        }

        private void radioBttTipo1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBttTipo2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void bttRemover_Click(object sender, EventArgs e)
        {

        }

        private void bttGerarContrato_Click(object sender, EventArgs e)
        {

        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {

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
}
