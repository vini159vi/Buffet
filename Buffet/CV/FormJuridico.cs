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
    public partial class FormJuridico : Form
    {
        public FormJuridico()
        {
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();

            InitializeComponent();
            //cbRepresentanteBusca.Items.Add(cjDAO.List());
        }

        public FormJuridico(ClienteJuridico cj,int mode)
        {
            InitializeComponent();

            if(mode == 1)
            {
                this.Text = "Editando";
                this.bttAdicionar.Text = "Editar";
                this.bttCancelar.Text = "Cancelar";
                SetDTO(cj);

            }
            else
            {
                SetDTO(cj);
                this.bttAdicionar.Hide();
                this.bttCancelar.Text = "Fechar";

                //Ativar só leitura nos txt da Empresa
                txtNomeEmpresa.ReadOnly = true;
                txtCNPJ.ReadOnly = true;
                txtRuaEmpresa.ReadOnly = true;
                txtNumeroEmpresa.ReadOnly = true;
                txtBairroEmpresa.ReadOnly = true;
                txtCEPEmpresa.ReadOnly = true;
                txtCidadeEmpresa.ReadOnly = true;
                txtEstadoEmpresa.ReadOnly = true;

            }
        }

        private void lbRua_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbCPF_Click(object sender, EventArgs e)
        {

        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

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

        private ClienteJuridico GetDTO()
        {
            ClienteJuridico cj = new ClienteJuridico();

            //Empresa
            cj.NomeEmpresa = txtNomeEmpresa.Text;
            txtCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cj.Cnpj = long.Parse(txtCNPJ.Text);
            cj.Rua = txtRuaEmpresa.Text;
            cj.NumeroEmpresa = int.Parse(txtNumeroEmpresa.Text);
            cj.Bairro = txtBairroEmpresa.Text;
            txtCEPEmpresa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cj.Cep = long.Parse(txtCEPEmpresa.Text);
            cj.Cidade = txtCidadeEmpresa.Text;
            cj.Estado = txtEstadoEmpresa.Text;
            cj.Tipo = 2;
            return cj;
            Console.WriteLine("Passou o GetDTO");
        }


        private void SetDTO(ClienteJuridico cj)
        {
            txtNomeEmpresa.Text = cj.NomeEmpresa;
            txtCNPJ.Text = cj.Cnpj.ToString();
            txtRuaEmpresa.Text = cj.Rua;
            txtNumeroEmpresa.Text = cj.NumeroEmpresa.ToString();
            txtBairroEmpresa.Text = cj.Bairro;
            txtCEPEmpresa.Text = cj.Cep.ToString();
            txtCidadeEmpresa.Text = cj.Cidade;
            txtEstadoEmpresa.Text = cj.Estado;
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            ClienteJuridico cj = GetDTO();

            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();

            cjDAO.Create(cj);

            if (f != null)
            {
                f.Fill();
            }
            this.Hide();
            //cbRepresentanteBusca.Items.Add(cjDAO.List());
        }

        
    }
}
