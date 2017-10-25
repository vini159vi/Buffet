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
    public partial class FormRepresentante : Form
    {
        long cpf;
        public FormRepresentante()
        {
            InitializeComponent();
        }

        public FormRepresentante(RepresentanteJuridico rj, int mode)
        {
            InitializeComponent();

            if (mode == 1)
            {
                cpf = rj.Cpf;
                this.Text = "Editando "+rj.Nome;
                this.bttAdicionar.Text = "Editar";
                this.bttAdicionar.Click -= new EventHandler(bttAdicionar_Click);
                this.bttAdicionar.Click += new EventHandler(bttUpdate_Click);
                this.bttCancelar.Text = "Cancelar";
                SetDTO(rj);

            }
            else
            {
                cpf = rj.Cpf;
                SetDTO(rj);
                this.bttAdicionar.Text = "Editar";
                bttAdicionar.Click -= new EventHandler(bttAdicionar_Click);
                bttAdicionar.Click += new EventHandler(bttEditar_Click);
                this.bttCancelar.Text = "Fechar";

                //Ativar só leitura nos txt do Representante
                txtNomeRepresentante.ReadOnly = true;
                txtCPFRepresentante.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtProfissao.ReadOnly = true;
                txtNacionalidade.ReadOnly = true;
                txtEstadoCivil.ReadOnly = true;
                txtRuaRepresentante.ReadOnly = true;
                txtNumeroRepresentante.ReadOnly = true;
                txtBairroRepresentante.ReadOnly = true;
                txtCEPRepresentante.ReadOnly = true;
                txtCidadeRepresentante.ReadOnly = true;
                txtEstadoRepresentante.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtCelular.ReadOnly = true;
                txtEmpresaView.Visible = true;
                cbEmpresaBusca.Visible = false;
                txtEmpresaView.ReadOnly = true;
            }
        }

        private RepresentanteJuridico GetDTO()
        {
            RepresentanteJuridico rj = new RepresentanteJuridico();

            //Representante
            rj.Nome = txtNomeRepresentante.Text;
            txtCPFRepresentante.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rj.Cpf = long.Parse(txtCPFRepresentante.Text);
            rj.Rg = long.Parse(txtRG.Text);
            rj.Profissao = txtProfissao.Text;
            rj.Nacionalidade = txtNacionalidade.Text;
            rj.EstadoCivil = txtEstadoCivil.Text;
            rj.Rua = txtRuaRepresentante.Text;
            rj.NumeroCasa = int.Parse(txtNumeroRepresentante.Text);
            rj.Bairro = txtBairroRepresentante.Text;
            txtCEPRepresentante.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rj.Cep = long.Parse(txtCEPRepresentante.Text);
            rj.Cidade = txtCidadeRepresentante.Text;
            rj.Estado = txtEstadoRepresentante.Text;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rj.Telefone = long.Parse(txtTelefone.Text);
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rj.Celular = long.Parse(txtCelular.Text);
            rj.Empresa.Cnpj = Convert.ToInt64(cbEmpresaBusca.SelectedValue);


            return rj;
        }

        private void SetDTO(RepresentanteJuridico rj)
        {
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            ClienteJuridico aux = cjDAO.FindByCNPJ(rj.Empresa.Cnpj);

            txtNomeRepresentante.Text = rj.Nome.ToString();
            txtCPFRepresentante.Text = rj.Cpf.ToString();
            txtRG.Text = rj.Rg.ToString();
            txtProfissao.Text = rj.Profissao;
            txtNacionalidade.Text = rj.Nacionalidade;
            txtEstadoCivil.Text = rj.EstadoCivil;
            txtRuaRepresentante.Text = rj.Rua;
            txtNumeroRepresentante.Text = rj.NumeroCasa.ToString();
            txtBairroRepresentante.Text = rj.Bairro;
            txtCEPRepresentante.Text = rj.Cep.ToString();
            txtCidadeRepresentante.Text = rj.Cidade;
            txtEstadoRepresentante.Text = rj.Estado;
            txtTelefone.Text = rj.Telefone.ToString();
            txtCelular.Text = rj.Celular.ToString();
            txtEmpresaView.Text = aux.NomeEmpresa;
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            RepresentanteJuridico rj = GetDTO();

            RepresentanteDAO rjDAO = new RepresentanteDAO();

            rjDAO.Create(rj);

            if (f != null)
            {
                f.Fill();
            }
            this.Hide();
        }


        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            RepresentanteJuridico rj = GetDTO();

            this.Text = "Editando " + rj.Nome;
            this.bttAdicionar.Text = "Editar";
            this.bttAdicionar.Click -= new EventHandler(bttAdicionar_Click);
            this.bttAdicionar.Click += new EventHandler(bttUpdate_Click);
            this.bttCancelar.Text = "Cancelar";

            txtNomeRepresentante.ReadOnly = false;
            txtCPFRepresentante.ReadOnly = false;
            txtRG.ReadOnly = false;
            txtProfissao.ReadOnly = false;
            txtNacionalidade.ReadOnly = false;
            txtEstadoCivil.ReadOnly = false;
            txtRuaRepresentante.ReadOnly = false;
            txtNumeroRepresentante.ReadOnly = false;
            txtBairroRepresentante.ReadOnly = false;
            txtCEPRepresentante.ReadOnly = false;
            txtCidadeRepresentante.ReadOnly = false;
            txtEstadoRepresentante.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtEmpresaView.Visible = false;
            cbEmpresaBusca.Visible = true;
            txtEmpresaView.ReadOnly = false;

            SetDTO(rj);

        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            RepresentanteJuridico rj = GetDTO();

            RepresentanteDAO rjDAO = new RepresentanteDAO();

            rjDAO.Update(rj, cpf);

            if (f != null)
            {
                f.Fill();
            }
            this.Hide();
            
        }

        private void cbEmpresaBusca_Click(object sender, EventArgs e)
        {
            FormRepresentante_VisibleChanged(this, new EventArgs());

        }

        private void FormRepresentante_VisibleChanged(object sender, EventArgs e)
        {
            List<ClienteJuridico> listcj = new List<ClienteJuridico>();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            listcj = cjDAO.List();

            if (cbEmpresaBusca.Items.Count == 0)
                cbEmpresaBusca.Items.Clear();


            cbEmpresaBusca.DisplayMember = "NomeEmpresa";
            cbEmpresaBusca.ValueMember = "cnpj";
            cbEmpresaBusca.DataSource = listcj;
        }

        private void cbEmpresaBusca_keyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FormRepresentante_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
