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
            InitializeComponent();
        }

        public FormJuridico(ClienteJuridico cj, RepresentanteJuridico rj ,int mode)
        {
            InitializeComponent();

            if(mode == 1)
            {
                this.Text = "Editando";
                this.bttAdicionar.Text = "Editar";
                this.bttCancelar.Text = "Cancelar";
                SetDTOJuridico(cj);
                SetDTORepresentante(rj);

            }
            else
            {
                SetDTOJuridico(cj);
                SetDTORepresentante(rj);
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

        private ClienteJuridico GetDTOJuridico()
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

            return cj;
        }

        private RepresentanteJuridico GetDTORepresentante()
        {
            RepresentanteJuridico rj = new RepresentanteJuridico();

            //Representante
            rj.Nome = txtNomeRepresentante.Text;
            txtCPFRepresentante.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rj.Cep = long.Parse(txtCPFRepresentante.Text);
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

            return rj;
        }

        private void SetDTOJuridico(ClienteJuridico cj)
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
        private void SetDTORepresentante(RepresentanteJuridico rj)
        {
            txtNomeRepresentante.Text = rj.Nome.ToString();
            txtCPFRepresentante.Text = rj.Cep.ToString() ;
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
        }
    }
}
