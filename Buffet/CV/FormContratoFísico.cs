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
    public partial class FormContratoFísico : Form
    {

        public FormContratoFísico()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCapacidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtHoraTerminoContratado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bttGerarContrato_Click(object sender, EventArgs e)
        {

        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbBuscaPessoaFisica_Click(object sender, EventArgs e)
        {

        }

        private void FormContratoFísico_VisibleChanged(object sender, EventArgs e)
        {
            List<ClienteFisico> listcf = new List<ClienteFisico>();
            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
            listcf = cfDAO.List();

            if (cbBuscaPessoaFisica.Items.Count == 0)
                cbBuscaPessoaFisica.Items.Clear();


            cbBuscaPessoaFisica.DisplayMember = "Nome";
            cbBuscaPessoaFisica.ValueMember = "Cpf";
            cbBuscaPessoaFisica.DataSource = listcf;
        }

        private void FormContratoFísico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void txtPreco_MouseClick(object sender, MouseEventArgs e)
        {
            txtPreco.Focus();
        }
    }
}
