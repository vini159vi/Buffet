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
    public partial class FormContratoJuridico : Form
    {
        public FormContratoJuridico()
        {
            InitializeComponent();
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormContratoJuridico_VisibleChanged(object sender, EventArgs e)
        {
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            List<ClienteJuridico> listcj = cjDAO.List();

            /*if (cbBuscaPessoaFisica.Items.Count == 0)
                cbBuscaPessoaFisica.Items.Clear();*/

            cbEmpresa.DisplayMember = "NomeEmpresa";
            cbEmpresa.ValueMember = "Cnpj";
            cbEmpresa.DataSource = listcj;
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            RepresentanteJuridico rj = cjDAO.FindByRepresentante(Convert.ToInt64(cbEmpresa.SelectedValue));
            List<RepresentanteJuridico> listrj =  new List<RepresentanteJuridico>();
            listrj.Add(rj);

            cbRepresentante.DisplayMember = "Nome";
            cbRepresentante.ValueMember = "Cpf";
            cbRepresentante.DataSource = listrj;
        }

        private void FormContratoJuridico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
