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
            int index = dgvAgenda.CurrentCell.RowIndex;
            if (e.ColumnIndex == dgvAgenda.Columns["ColumnRemove"].Index)
            {
                AgendaDAO aDAO = new AgendaDAO();
                aDAO.Delete(int.Parse(dgvAgenda.Rows[index].Cells[0].Value.ToString()));
                Fill();
            }
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            AgendaDAO aDAO = new AgendaDAO();
            Agenda a = GetDTO();

            aDAO.Create(a);

            Fill();
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
    }
}
