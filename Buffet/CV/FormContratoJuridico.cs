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
        int id;
        public FormContratoJuridico()
        {
            InitializeComponent();
        }

        public FormContratoJuridico(Contrato c, int mode)
        {
            InitializeComponent();

            if (mode == 1)
            {
                id = c.Id;
                this.Text = "Editando";
                this.bttGerarContrato.Text = "Editar Contrato";
                this.bttGerarContrato.Click -= new EventHandler(bttGerarContrato_Click);
                this.bttGerarContrato.Click += new EventHandler(bttUpdate_Click);
                this.bttCancelar.Text = "Cancelar";
                SetDTO(c);

            }
            else
            {
                id = c.Id;
                SetDTO(c);
                this.bttGerarContrato.Visible = false;
                this.bttCancelar.Text = "Fechar";

                //Ativar só leitura nos txt do Representante

                cbEmpresa.Visible = false;
                cbRepresentante.Visible = false;

                txtEmpresa.Visible = true;
                txtEmpresa.ReadOnly = true;

                txtRepresentante.Visible = true;
                txtRepresentante.ReadOnly = true;

                dtDataEvento.Enabled = false;
                dtHoraEvento.Enabled = false;
                dtHoraTermino.Enabled = false;
                txtConvidados.ReadOnly = true;
                txtCapacidade.ReadOnly = true;
                dtHoraChegada.Enabled = false;
                dtHoraInicio.Enabled = false;
                txtGarcom.ReadOnly = true;
                txtPreco.ReadOnly = true;
                txtHorasAntecedencia.ReadOnly = true;
                dtHoraTerminoContratado.Enabled = false;
                txtCopeiros.ReadOnly = true;
                dtPagamento.Enabled = false;
                dtDiaDevolucao.Enabled = false;
                dtHoraDevolucao.Enabled = false;

            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormContratoJuridico_VisibleChanged(object sender, EventArgs e)
        {
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            List<ClienteJuridico> listcj = cjDAO.List();

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

        private Contrato GetDTO()
        {
            Contrato c = new Contrato();

            //Fisico
            c.PessoaJuridica.Cnpj = Convert.ToInt64(cbEmpresa.SelectedValue);
            c.EventoData = DateTime.Parse(dtDataEvento.Text);
            c.EventoHora = DateTime.Parse(dtHoraEvento.Text);
            c.EventoTerminoHora = DateTime.Parse(dtHoraTermino.Text);
            c.EventoNConvidados = int.Parse(txtConvidados.Text);
            c.EventoCapMaxima = int.Parse(txtCapacidade.Text);
            c.ContratadoHoraChegada = DateTime.Parse(dtHoraChegada.Text);
            c.ContratadoInicioServico = DateTime.Parse(dtHoraInicio.Text);
            c.ContratadoQuantGarcons = int.Parse(txtGarcom.Text);
            txtPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            c.ContratadoPrecoPagar = double.Parse(txtPreco.Text);
            c.ContratadoHoraAntecedencia = int.Parse(txtHorasAntecedencia.Text);
            c.ContratadoTerminoServico = DateTime.Parse(dtHoraTerminoContratado.Text);
            c.ContratadoQuantCopeiros = int.Parse(txtCopeiros.Text);
            c.ContratadoDataPgto = DateTime.Parse(dtPagamento.Text);
            c.DevolucaoDia = DateTime.Parse(dtDiaDevolucao.Text);
            c.DevolucaoHora = DateTime.Parse(dtHoraDevolucao.Text);
            c.Tipo = 2;

            return c;
        }

        private void SetDTO(Contrato c)
        {
            ContratoDAO cDAO = new ContratoDAO();
            ClienteJuridico aux = cDAO.FindByJuridico(c.Id);


            dtDataEvento.Text = c.EventoData.ToString("dd/mm/yyyy");
            dtHoraEvento.Text = c.EventoHora.ToString("hh:mm");
            dtHoraTermino.Text = c.EventoTerminoHora.ToString("hh:mm");
            txtConvidados.Text = c.EventoNConvidados.ToString();
            txtCapacidade.Text = c.EventoCapMaxima.ToString();
            dtHoraChegada.Text = c.ContratadoHoraChegada.ToString("hh:mm");
            dtHoraInicio.Text = c.ContratadoInicioServico.ToString("hh:mm");
            txtGarcom.Text = c.ContratadoQuantGarcons.ToString();
            txtPreco.Text = c.ContratadoPrecoPagar.ToString();
            txtHorasAntecedencia.Text = c.ContratadoHoraAntecedencia.ToString();
            dtHoraTerminoContratado.Text = c.ContratadoTerminoServico.ToString("hh:mm");
            txtCopeiros.Text = c.ContratadoQuantCopeiros.ToString();
            dtPagamento.Text = c.ContratadoDataPgto.ToString("dd/mm/yyyy");
            dtDiaDevolucao.Text = c.DevolucaoDia.ToString("dd/mm/yyyy");
            dtHoraDevolucao.Text = c.DevolucaoHora.ToString("hh:mm");
            txtEmpresa.Text = aux.NomeEmpresa;
        }

        private void bttGerarContrato_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            Contrato c = GetDTO();

            ContratoDAO cDAO = new ContratoDAO();

            cDAO.Create(c);

            if (f != null)
            {
                f.Fill();
            }
            this.Hide();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            Contrato rj = GetDTO();

            ContratoDAO cDAO = new ContratoDAO();

            cDAO.Update(rj, id);

            if (f != null)
            {
                f.Fill();
            }
            this.Hide();

        }
    }
}
