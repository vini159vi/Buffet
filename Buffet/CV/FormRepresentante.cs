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
        bool check=false;
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
                checkBoxNenhumaEmpresa.Visible = false;


            }
        }

        private ClienteFisico GetDTO()
        {
            ClienteFisico rj = new ClienteFisico();

            //Representante
            rj.Nome = txtNomeRepresentante.Text;
            txtCPFRepresentante.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rj.Cpf = long.Parse(txtCPFRepresentante.Text);
            rj.Rg = txtRG.Text;
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
            if (check)
            {
                rj.Empresa.Cnpj = 0;
            }
            else
            {
                rj.Empresa.Cnpj = Convert.ToInt64(cbEmpresaBusca.SelectedValue);
            }
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
            if(cf.Empresa.Cnpj == 0)
            {
                checkBoxNenhumaEmpresa.Checked = true;
            }
            else
            {
                checkBoxNenhumaEmpresa.Checked = false;
            }
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {

            if (Verifica())
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
            else
            {
                MessageBox.Show("Algum campo está faltando", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Resetar();
        }

        private bool Verifica()
        {
            if (txtNomeRepresentante.Text != "" && txtBairroRepresentante.Text != "" && txtCelular.Text != "" && txtCEPRepresentante.Text != "" && txtCidadeRepresentante.Text != "" && txtCPFRepresentante.Text != "" && txtEstadoCivil.Text != "" && txtEstadoRepresentante.Text != "" && txtNacionalidade.Text != "" && txtNumeroRepresentante.Text != "" && txtProfissao.Text != "" && txtRG.Text != "" && txtRuaRepresentante.Text != "" && txtTelefone.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resetar();
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
            checkBoxNenhumaEmpresa.Visible = true;
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
            Resetar();
        }

        private void cbEmpresaBusca_Click(object sender, EventArgs e)
        {
            UpdateComboBox();

        }

        private void Resetar()
        {
            UpdateComboBox();

            txtBairroRepresentante.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCEPRepresentante.Text = string.Empty;
            txtCidadeRepresentante.Text = string.Empty;
            txtCPFRepresentante.Text = string.Empty;
            txtEmpresaView.Text = string.Empty;
            txtEstadoCivil.Text = string.Empty;
            txtEstadoRepresentante.Text = string.Empty;
            txtNacionalidade.Text = string.Empty;
            txtNomeRepresentante.Text = string.Empty;
            txtNumeroRepresentante.Text = string.Empty;
            txtProfissao.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtRuaRepresentante.Text = string.Empty;
            txtTelefone.Text = string.Empty;
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

        private void checkBoxNenhumaEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if(check != true)
            {
                check = true;
                cbEmpresaBusca.Visible = false;
                txtEmpresaView.Visible = true;
                txtEmpresaView.ReadOnly = true;
            }
            else
            {
                check = false;
                cbEmpresaBusca.Visible = true;
                txtEmpresaView.Visible = false;
                txtEmpresaView.ReadOnly = false;
            }
        }

        private void UpdateComboBox()
        {
            List<ClienteJuridico> listcj = new List<ClienteJuridico>();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            listcj = cjDAO.List();

            cbEmpresaBusca.DisplayMember = "NomeEmpresa";
            cbEmpresaBusca.ValueMember = "cnpj";
            cbEmpresaBusca.DataSource = listcj;
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
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Numeros!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SomenteNumerosELetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Numeros e Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
