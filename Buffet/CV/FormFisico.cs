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
    public partial class FormFisico : Form
    {
        //Remove o botão de fechar
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public FormFisico()
        {
            InitializeComponent();
        }

        public FormFisico(ClienteFisico cf, int mode)
        {
            InitializeComponent();

            if (mode == 1)
            {
                this.Text = "Editando " + cf.Nome;
                this.bttAdicionar.Text = "Editar";
                this.bttAdicionar.Click += new EventHandler(bttAdicionarUpdate_Click);
                this.bttCancelar.Text = "Cancelar";
                SetDTO(cf);

            }
            else
            {
                SetDTO(cf);
                this.bttAdicionar.Hide();
                this.bttCancelar.Text = "Fechar";

                //Ativar só leitura nos txt do fisico
                txtBairro.ReadOnly = true;
                txtCelular.ReadOnly = true;
                txtCEP.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtCPF.ReadOnly = true;
                txtEstado.ReadOnly = true;
                txtEstadoCivil.ReadOnly = true;
                txtNacionalidade.ReadOnly = true;
                txtNome.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtProfissao.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtRua.ReadOnly = true;
                txtTelefone.ReadOnly = true;
            }
        }

        private ClienteFisico GetDTO()
        {
            ClienteFisico cf = new ClienteFisico();

            //Fisico
            cf.Nome = txtNome.Text;
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cf.Cpf = long.Parse(txtCPF.Text);
            cf.Rg = long.Parse(txtRG.Text);
            cf.Profissao = txtProfissao.Text;
            cf.Nacionalidade = txtNacionalidade.Text;
            cf.EstadoCivil = txtEstadoCivil.Text;
            cf.Rua = txtRua.Text;
            cf.NumeroCasa = int.Parse(txtNumero.Text);
            cf.Bairro = txtBairro.Text;
            txtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cf.Cep = long.Parse(txtCEP.Text);
            cf.Cidade = txtCidade.Text;
            cf.Estado = txtEstado.Text;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cf.Telefone = long.Parse(txtTelefone.Text);
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cf.Celular = long.Parse(txtCelular.Text);
            cf.Tipo = 1;

            return cf;
        }

        private void SetDTO(ClienteFisico cf)
        {
            txtNome.Text = cf.Nome.ToString();
            txtCPF.Text = cf.Cpf.ToString();
            txtRG.Text = cf.Rg.ToString();
            txtProfissao.Text = cf.Profissao;
            txtNacionalidade.Text = cf.Nacionalidade;
            txtEstadoCivil.Text = cf.EstadoCivil;
            txtRua.Text = cf.Rua;
            txtNumero.Text = cf.NumeroCasa.ToString();
            txtBairro.Text = cf.Bairro;
            txtCEP.Text = cf.Cep.ToString();
            txtCidade.Text = cf.Cidade;
            txtEstado.Text = cf.Estado;
            txtTelefone.Text = cf.Telefone.ToString();
            txtCelular.Text = cf.Celular.ToString();
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

        private void bttAdicionarUpdate_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            ClienteFisico cf = GetDTO();

            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();

            cfDAO.Update(cf);

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


    }
}
