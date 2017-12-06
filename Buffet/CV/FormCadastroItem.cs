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
    public partial class FormCadastroItem : Form
    {
        private int tipo, id;
        private Item i;
        public FormCadastroItem()
        {
            InitializeComponent();
            
        }

        public FormCadastroItem(int mode, int id)
        {
            ItemDAO idao = new ItemDAO();
            InitializeComponent();
            this.i = idao.Read(id);
            this.id = id;
            if (mode == 1)
            {
                Item i = idao.Read(id);
                Editar(i);
            }
            else
            {
                Item i = idao.Read(id);
                Visualizar(i);
            }
        }

        private Item GetDTO()
        {
            Item i = new Item();
            i.Nome = txtNome.Text;

            i.ValorCabeca = double.Parse(txtValorPorCabeca.Text);
            i.Tipo = tipo;

            return i;
        }

        private void SetDTO(Item i)
        {

            txtNome.Text = i.Nome;
            txtValorPorCabeca.Text = i.ValorCabeca.ToString();
            switch (i.Tipo)
            {
                case 0:
                    radioBttPratoQuente.Checked = true;
                    break;
                case 1:
                    radioBttSalada.Checked = true;
                    break;
                case 2:
                    radioBttFrutas.Checked = true;
                    break;
                case 3:
                    radioBttFrios.Checked = true;
                    break;
                case 4:
                    radioBttBebida.Checked = true;
                    break;
                case 5:
                    radioBttServicos.Checked = true;
                    break;
            }
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
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Numeros!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void radioBttPratoQuente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttPratoQuente.Checked)
                tipo = 0;
        }

        private void radioBttFrios_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttFrios.Checked)
                tipo = 3;
        }
        private void radioBttSalada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttSalada.Checked)
                tipo = 1;
        }

        private void radioBttBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttBebida.Checked)
                tipo = 4;
        }

        private void radioBttFrutas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttFrutas.Checked)
                tipo = 2;
        }

        private void radioBttServicos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttServicos.Checked)
                tipo = 5;
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            if (Verifica())
            {
                ItemDAO iDAO = new ItemDAO();
                Item i = GetDTO();

                iDAO.Create(i);
                Resetar();
            }
            else
            {
                MessageBox.Show("Algum campo está faltando", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resetar();
        }

        private void Resetar()
        {
            txtNome.Text = string.Empty;
            txtValorPorCabeca.Text = string.Empty;
        }

        private bool Verifica()
        {
            if(txtNome.Text != "" && txtValorPorCabeca.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            ItemDAO idao = new ItemDAO();
            Item i = GetDTO();
            idao.Update(i, this.id);

            this.Hide();

            FormControleItens fci = Application.OpenForms["FormControleItens"] as FormControleItens;
            fci.Fill();
        }

        private void Editar(Item i)
        {
            bttAdicionar.Text = "Editar";
            bttAdicionar.Click -= new EventHandler(bttAdicionar_Click);
            bttAdicionar.Click += new EventHandler(bttEditar_Click);

            txtNome.Text = i.Nome;
            txtValorPorCabeca.Text = i.ValorCabeca.ToString();
            switch (i.Tipo)
            {
                case 0:
                    radioBttPratoQuente.Checked = true;
                    break;
                case 1:
                    radioBttSalada.Checked = true;
                    break;
                case 2:
                    radioBttFrutas.Checked = true;
                    break;
                case 3:
                    radioBttFrios.Checked = true;
                    break;
                case 4:
                    radioBttBebida.Checked = true;
                    break;
                case 5:
                    radioBttServicos.Checked = true;
                    break;
            }
        }

        private void Visualizar(Item i)
        {
            txtNome.ReadOnly = true;
            txtValorPorCabeca.ReadOnly = true;
            SetDTO(i);
            bttAdicionar.Visible = false;
        }
    }
}
