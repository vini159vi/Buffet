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
        public FormAgenda()
        {
            InitializeComponent();
            Fill();
        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvAgenda.Columns["ColumnRemove"].Index)
            {

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
            List<Agenda> listA = aDAO.List();


            ColumnRemove.HeaderText = "Remover";
            ColumnRemove.Text = "Remover";
            ColumnRemove.UseColumnTextForButtonValue = true;

            dgvAgenda.Rows.Clear();

            foreach (Agenda a in listA)
            {
                int index = dgvAgenda.Rows.Add();

                dgvAgenda.Rows[index].Cells[0].Value = a.Nome;
                dgvAgenda.Rows[index].Cells[1].Value = a.Telefone.ToString(@"(00)");
                dgvAgenda.Rows[index].Cells[2].Value = a.Data.Date;
                //dgvAgenda.Rows[index].Cells["ColumnRemove"]
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

    }
}
