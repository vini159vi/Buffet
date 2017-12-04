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
    public partial class FormCadastroItem : Form
    {
        private int tipo;
        public FormCadastroItem()
        {
            InitializeComponent();
            
        }

        private Item GetDTO()
        {
            Item i = new Item();
            i.Nome = txtNome.Text;
            i.ValorCabeca = double.Parse(txtValorPorCabeca.Text);
            i.Tipo = tipo;

            return i;
        }


        private void SomenteLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Numeros!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void radioBttPratoQuente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttPratoQuente.Checked)
                tipo = 0;
        }

        private void radioBttFrios_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttFrios.Checked)
                tipo = 3;
        }
        private void radioBttSalada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttSalada.Checked)
                tipo = 1;
        }

        private void radioBttBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttBebida.Checked)
                tipo = 4;
        }

        private void radioBttFrutas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttFrutas.Checked)
                tipo = 2;
        }

        private void radioBttServicos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttServicos.Checked)
                tipo = 5;
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            ItemDAO iDAO = new ItemDAO();
            Item i = GetDTO();

            iDAO.Create(i);
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormCadastroItem_VisibleChanged(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtValorPorCabeca.Text = string.Empty;
        }
    }
}
