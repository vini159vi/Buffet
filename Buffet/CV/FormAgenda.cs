﻿using Buffet.DAO;
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
    public partial class FormAgenda : Form
    {
        bool check=false;
        public FormAgenda()
        {
            InitializeComponent();
            Fill();
        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvAgenda.CurrentCell.RowIndex;
                if (e.ColumnIndex == dgvAgenda.Columns["ColumnRemove"].Index)
                {
                    AgendaDAO aDAO = new AgendaDAO();
                    aDAO.Delete(int.Parse(dgvAgenda.Rows[index].Cells[0].Value.ToString()));
                    Fill();
                }
            }
            catch
            {
                MessageBox.Show("Não tem nenhum dado selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            if (Verifica()) {
                AgendaDAO aDAO = new AgendaDAO();
                Agenda a = GetDTO();

                aDAO.Create(a);

                Fill();
            }
            else
            {
                MessageBox.Show("Algum campo está faltando", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool Verifica()
        {
            if (txtNome.Text != "" && txtTelefone.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Fill()
        {
            AgendaDAO aDAO = new AgendaDAO();


            ColumnRemove.HeaderText = "Remover";
            ColumnRemove.Text = "Remover";
            ColumnRemove.UseColumnTextForButtonValue = true;

            dgvAgenda.Rows.Clear();

            if (check != true)
            {
                List<Agenda> listA = aDAO.List();
                foreach (Agenda a in listA)
                {
                    int index = dgvAgenda.Rows.Add(), n = a.Telefone.ToString().Length;
                    string data = a.Data.ToString("dd/MM/yyyy");

                    dgvAgenda.Rows[index].Cells[0].Value = a.Id;
                    dgvAgenda.Rows[index].Cells[1].Value = a.Nome;
                    if (n == 9)
                    {
                        dgvAgenda.Rows[index].Cells[2].Value = a.Telefone.ToString(@"(00) 00000-0000");
                    }
                    else
                    {
                        dgvAgenda.Rows[index].Cells[2].Value = a.Telefone.ToString(@"(00) 0000-0000");
                    }
                    dgvAgenda.Rows[index].Cells[3].Value = data;
                }
            }
            else
            {
                List<Agenda> listA = aDAO.ListHistorico();
                foreach (Agenda a in listA)
                {
                    int index = dgvAgenda.Rows.Add(), n = a.Telefone.ToString().Length;
                    string data = a.Data.ToString("dd/MM/yyyy");

                    dgvAgenda.Rows[index].Cells[0].Value = a.Id;
                    dgvAgenda.Rows[index].Cells[1].Value = a.Nome;
                    if (n == 9)
                    {
                        dgvAgenda.Rows[index].Cells[2].Value = a.Telefone.ToString(@"(00) 00000-0000");
                    }
                    else
                    {
                        dgvAgenda.Rows[index].Cells[2].Value = a.Telefone.ToString(@"(00) 0000-0000");
                    }
                    dgvAgenda.Rows[index].Cells[3].Value = data;
                }
            }
        }



        private Agenda GetDTO()
        {
            Agenda a = new Agenda();

            //Agenda
            a.Nome = txtNome.Text;
            a.Telefone = long.Parse(txtTelefone.Text);
            a.Data = DateTime.Parse(dtData.Value.Date.ToShortDateString());
            a.Ativo = true;

            return a;
        }

        private void SetDTO(Agenda a)
        {
            AgendaDAO aDAO = new AgendaDAO();

            txtNome.Text = a.Nome.ToString();
            txtTelefone.Text = a.Telefone.ToString();
            dtData.Value = a.Data.Date; 
        }

        private void checkBoxHistorico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHistorico.Checked)
                check = true;
            else
                check = false;

            Fill();
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

        private void bttEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
