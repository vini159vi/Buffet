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
        int id, tipo, contrato;
        bool check = false;

        public FormContratoFísico()
        {
            InitializeComponent();
            cbBuscaPessoaFisica.Visible = false;
            cbEmpresa.Visible = false;
            cbRepresentante.Visible = false;
            txtEmpresa.Visible = true;
            txtEmpresa.ReadOnly = true;
            txtRepresentante.Visible = true;
            txtRepresentante.ReadOnly = true;
            txtPessoaFisica.Visible = true;
            txtPessoaFisica.ReadOnly = true;
            txtNomeAniversario.ReadOnly = true;

        }

        public FormContratoFísico (Contrato c, int mode)
        {
            InitializeComponent();

            if (mode == 1)
            {
                id = c.Id;
                this.Text = "Editando ";
                this.bttAvancar.Text = "Editar Contrato";
                this.bttAvancar.Click -= new EventHandler(bttGerarContrato_Click);
                this.bttAvancar.Click += new EventHandler(bttUpdate_Click);
                this.bttCancelar.Text = "Cancelar";
                SetDTO(c);

            }
            else
            {
                id = c.Id;
                SetDTO(c);
                this.bttAvancar.Visible = false;
                this.bttCancelar.Text = "Fechar";

                //Ativar só leitura nos txt do Representante
                cbBuscaPessoaFisica.Visible = false;

                txtPessoaFisica.Visible = true;
                txtPessoaFisica.ReadOnly = true;
     
                dtDataEvento.Enabled = false;
                dtHoraEvento.Enabled = false;
                dtHoraTermino.Enabled = false;
                txtConvidados.ReadOnly = true;
                txtCapacidade.ReadOnly = true;
                dtHoraChegada.Enabled = false;
                dtHoraInicio.Enabled = false;
                txtGarcom.ReadOnly = true;
                txtHorasAntecedencia.ReadOnly = true;
                dtHoraTerminoContratado.Enabled = false;
                txtCopeiros.ReadOnly = true;
                dtPagamento.Enabled = false;
                dtDiaDevolucao.Enabled = false;
                dtHoraDevolucao.Enabled = false;

            }
        }


        private void bttGerarContrato_Click(object sender, EventArgs e)
        {
            FormContratos fc = Application.OpenForms["FormContratos"] as FormContratos;
            Contrato c = GetDTO();

            ContratoDAO cDAO = new ContratoDAO();

            cDAO.Create(c);

            if (fc != null)
            {
                fc.Fill();
            }
            this.Hide();
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormContratoFísico_VisibleChanged(object sender, EventArgs e)
        {
            List<ClienteFisico> listcf = new List<ClienteFisico>();
            List<ClienteJuridico> listcj = new List<ClienteJuridico>();

            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            listcf = cfDAO.List();
            listcj = cjDAO.List();

            cbBuscaPessoaFisica.DisplayMember = "Nome";
            cbBuscaPessoaFisica.ValueMember = "Cpf";
            cbBuscaPessoaFisica.DataSource = listcf;

            cbEmpresa.DisplayMember = "NomeEmpresa";
            cbEmpresa.ValueMember = "Cnpj";
            cbEmpresa.DataSource = listcj;
        }

        private void FormContratoFísico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        private Contrato GetDTO()
        {
            Contrato c = new Contrato();
            if(tipo == 0)
            {
                c.PessoaFisica.Cpf = Convert.ToInt64(cbBuscaPessoaFisica.SelectedValue);
            }
            else
            {
                c.PessoaFisica.Cpf = Convert.ToInt64(cbRepresentante.SelectedValue);
                c.PessoaJuridica.Cnpj = Convert.ToInt64(cbEmpresa.SelectedValue);
            }
            c.EventoData = DateTime.Parse(dtDataEvento.Text);
            c.EventoHora = DateTime.Parse(dtHoraEvento.Text);
            c.EventoTerminoHora = DateTime.Parse(dtHoraTermino.Text);
            c.EventoNConvidados = int.Parse(txtConvidados.Text);
            c.EventoCapMaxima = int.Parse(txtCapacidade.Text);
            c.ContratadoHoraChegada = DateTime.Parse(dtHoraChegada.Text);
            c.ContratadoInicioServico = DateTime.Parse(dtHoraInicio.Text);
            c.ContratadoQuantGarcons = int.Parse(txtGarcom.Text);
            c.ContratadoHoraAntecedencia = int.Parse(txtHorasAntecedencia.Text);
            c.ContratadoTerminoServico = DateTime.Parse(dtHoraTerminoContratado.Text);
            c.ContratadoQuantCopeiros = int.Parse(txtCopeiros.Text);
            c.ContratadoDataPgto = DateTime.Parse(dtPagamento.Text);
            c.DevolucaoDia = DateTime.Parse(dtDiaDevolucao.Text);
            c.DevolucaoHora = DateTime.Parse(dtHoraDevolucao.Text);
            c.DataCriacao = DateTime.Now;
            c.NomeAniversariante = txtNomeAniversario.Text;
            if (checkBoxNotaFiscal.Checked)
                c.NotaFiscal = true;
            else
                c.NotaFiscal = false;
            c.Tipo = contrato;
            return c;
        }

        private void SetDTO(Contrato c)
        {
            ContratoDAO cDAO = new ContratoDAO();
            ClienteFisico aux = cDAO.FindByFisico(c.Id);

            dtDataEvento.Text = c.EventoData.ToString("dd/mm/yyyy");
            dtHoraEvento.Text = c.EventoHora.ToString("hh:mm");
            dtHoraTermino.Text = c.EventoTerminoHora.ToString("hh:mm");
            txtConvidados.Text = c.EventoNConvidados.ToString();
            txtCapacidade.Text = c.EventoCapMaxima.ToString();
            dtHoraChegada.Text = c.ContratadoHoraChegada.ToString("hh:mm");
            dtHoraInicio.Text = c.ContratadoInicioServico.ToString("hh:mm");
            txtGarcom.Text = c.ContratadoQuantGarcons.ToString();
            txtHorasAntecedencia.Text = c.ContratadoHoraAntecedencia.ToString();
            dtHoraTerminoContratado.Text = c.ContratadoTerminoServico.ToString("hh:mm");
            txtCopeiros.Text = c.ContratadoQuantCopeiros.ToString();
            dtPagamento.Text = c.ContratadoDataPgto.ToString("dd/mm/yyyy");
            dtDiaDevolucao.Text = c.DevolucaoDia.ToString("dd/mm/yyyy");
            dtHoraDevolucao.Text = c.DevolucaoHora.ToString("hh:mm");
            txtPessoaFisica.Text = aux.Nome;
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

        private void radioBttFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttFisica.Checked)
            {
                tipo = 0;
                cbEmpresa.Visible = false;
                cbRepresentante.Visible = false;
                cbBuscaPessoaFisica.Visible = true;
                txtEmpresa.Visible = true;
                txtEmpresa.ReadOnly = true;
                txtRepresentante.Visible = true;
                txtRepresentante.ReadOnly = true;
                txtPessoaFisica.ReadOnly = false;
                txtPessoaFisica.Visible = false;
            }
        }

        private void radioBttJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttJuridica.Checked)
            {
                tipo = 1;
                cbEmpresa.Visible = true;
                cbRepresentante.Visible = true;
                cbBuscaPessoaFisica.Visible = false;
                txtEmpresa.Visible = false;
                txtEmpresa.ReadOnly = false;
                txtRepresentante.Visible = false;
                txtRepresentante.ReadOnly = false;
                txtPessoaFisica.ReadOnly = true;
                txtPessoaFisica.Visible = true;
            }
        }
        private void cbEmpresa_DropDownClosed(object sender, EventArgs e)
        {
            List<ClienteFisico> listRepresentantes = new List<ClienteFisico>();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();

            listRepresentantes = cjDAO.ListByRepresentante(Convert.ToInt64(cbEmpresa.SelectedValue));

            cbRepresentante.DisplayMember = "Nome";
            cbRepresentante.ValueMember = "Cpf";
            cbRepresentante.DataSource = listRepresentantes;
        }

        private void radioBttAniversario_CheckedChanged(object sender, EventArgs e)
        {
            contrato = 0;
            txtNomeAniversario.ReadOnly = false;
        }

        private void radioBttCasamento_CheckedChanged(object sender, EventArgs e)
        {
            contrato = 1;
            txtNomeAniversario.ReadOnly = true;
        }

        private void radioBtt15anos_CheckedChanged(object sender, EventArgs e)
        {
            contrato = 2;
            txtNomeAniversario.ReadOnly = false;
        }

        private void checkBoxNotaFiscal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNotaFiscal.Checked)
            {
                check = true;
            }
            else
            {
                check = false;
            }
                
        }


        private void radioBttEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            contrato = 3;
            txtNomeAniversario.ReadOnly = true;
        }

        private void radioBttEventosGerais_CheckedChanged(object sender, EventArgs e)
        {
            contrato = 4;
            txtNomeAniversario.ReadOnly = true;
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
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Numeros!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
