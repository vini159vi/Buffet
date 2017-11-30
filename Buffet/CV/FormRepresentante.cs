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

        public FormRepresentante(ClienteFisico rj, int mode)
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

        private ClienteFisico GetDTO()
        {
            ClienteFisico rj = new ClienteFisico();

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
            rj.DataCriacao = DateTime.Now;

            return rj;
        }

        private void SetDTO(ClienteFisico cf)
        {
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            ClienteJuridico aux = cjDAO.FindByCNPJ(cf.Empresa.Cnpj);

            txtNomeRepresentante.Text = cf.Nome.ToString();
            txtCPFRepresentante.Text = cf.Cpf.ToString();
            txtRG.Text = cf.Rg.ToString();
            txtProfissao.Text = cf.Profissao;
            txtNacionalidade.Text = cf.Nacionalidade;
            txtEstadoCivil.Text = cf.EstadoCivil;
            txtRuaRepresentante.Text = cf.Rua;
            txtNumeroRepresentante.Text = cf.NumeroCasa.ToString();
            txtBairroRepresentante.Text = cf.Bairro;
            txtCEPRepresentante.Text = cf.Cep.ToString();
            txtCidadeRepresentante.Text = cf.Cidade;
            txtEstadoRepresentante.Text = cf.Estado;
            txtTelefone.Text = cf.Telefone.ToString();
            txtCelular.Text = cf.Celular.ToString();
            txtEmpresaView.Text = aux.NomeEmpresa;
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            ClienteFisico cf = GetDTO();
            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();

            cfDAO.Create(cf);

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
            ClienteFisico rj = GetDTO();

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
            ClienteFisico cf = GetDTO();

            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();

            cfDAO.Update(cf, cpf);

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
            listcj.Add(SemEmpresa());



            if (cbEmpresaBusca.Items.Count == 0)
               // cbEmpresaBusca.Items.Clear();


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

        private void FormRepresentante_Load(object sender, EventArgs e)
        {
            
        }

        private ClienteJuridico SemEmpresa()
        {
            ClienteJuridico cj = new ClienteJuridico();
            cj.NomeEmpresa = "Nenhuma";
            return cj;
        }
    }
}
