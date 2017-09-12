using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet
{
    public partial class FormCadastroCliente : Form
    {
        DatabaseDict clientes = new DatabaseDict();

        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            GetDTO(SetDTO());
            Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private Cliente SetDTO()
        {
            Cliente c = new Cliente();

            c.Cpf = long.Parse(txtCPF.Text);
            c.Nome = txtNome.Text;
            c.Telefone = long.Parse(txtTelefone.Text);
            c.DataNasc = dateNascimento.Value;
            c.Endereco = txtEndereco.Text;

            return c;
        }
        private void GetDTO(Cliente c)
        {
            clientes.Save(c);
        }
    }
}
