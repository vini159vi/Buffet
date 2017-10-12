using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Buffet
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }
        public FormCadastroCliente(Cliente c)
        {
            InitializeComponent();
            SetDTO(c);
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastrados f = Application.OpenForms["FormCadastrados"] as FormCadastrados;
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = GetDTO();
            clienteDAO.Create(cliente);
            
            if (f != null)
            {
                f.Fill();
            }
            Dispose();
        }

        private Cliente GetDTO()
        {
            Cliente c = new Cliente();

            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            c.Cpf = long.Parse(txtCPF.Text);
            txtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            c.Nome = txtNome.Text;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            c.Telefone = long.Parse(txtTelefone.Text);
            txtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            c.DataNasc = dateNascimento.Value;
            c.Endereco = txtEndereco.Text;
            c.NumeroCasa = int.Parse(txtNumero.Text);
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            c.Celular = long.Parse(txtCelular.Text);
            txtCelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            return c;
        }
        private void SetDTO(Cliente c)
        {
            txtNome.Text = c.Nome;
            txtEndereco.Text = c.Endereco;
            txtCPF.Text = c.Cpf.ToString();
            txtTelefone.Text = c.Telefone.ToString();
            txtCelular.Text = c.Celular.ToString();
            txtNumero.Text = c.NumeroCasa.ToString();
        }



        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }

                
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
