using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.DAO;
using Buffet.Modelos;
using Buffet.CV;

namespace Buffet
{
    public partial class FormCadastrados : Form
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

        private int tipo;
        public FormCadastrados()
        {
            InitializeComponent();
            dataGViewLista.Columns[1].DefaultCellStyle.Format = @"000\.000\.000\-00";
            dataGViewLista.Columns[2].DefaultCellStyle.Format = @"(##) ####-####";
            dataGViewLista.Columns[3].DefaultCellStyle.Format = @"(##) #####-####";
            Fill();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente tela = new FormCadastroCliente();
            tela.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormCadastrados_Load(object sender, EventArgs e)
        {

        }

        private void gbLista_Enter(object sender, EventArgs e)
        {
            
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {

            int index = dataGViewLista.CurrentCell.ColumnIndex;

            if (tipo == 1)
            {

            }
            else if (tipo == 2)
            {


                ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[1].Value.ToString()));
                FormJuridico fj = new FormJuridico(cj,1);
            }
            else
            {
               
            }
        }
        public void Fill()
        {

            ClienteJuridicoDAO juridicos = new ClienteJuridicoDAO();
            List<ClienteJuridico> listcj = juridicos.List();

            ClienteFisicoDAO fisicos = new ClienteFisicoDAO();
            //List<ClienteFisico> listcf = fisicos.List();


            dataGViewLista.Rows.Clear();

            if(tipo == 1)
            {

            }else if(tipo == 2)
            {
                foreach (ClienteJuridico cj in listcj)
                {
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, 0, 0, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }
            }
            else
            {
                foreach (ClienteJuridico cj in listcj)
                {
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, 0, 0, cj.Rua + ", " + cj.NumeroEmpresa+"- "+ cj.Cidade);
                }

                /*foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Rows.Add();
                }*/
            }


        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            ClienteJuridicoDAO juridicos = new ClienteJuridicoDAO();

            ClienteFisicoDAO fisicos = new ClienteFisicoDAO();

            try
            {
                int index = dataGViewLista.CurrentCell.ColumnIndex;
                juridicos.Delete(long.Parse(dataGViewLista.Rows[index].Cells[1].Value.ToString()));
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Não contem nenhuma pessoa registrada","Buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Fill();
            }
        }

        private void dataGViewLista_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Fill();
        }

        private void radioBttJuridica_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            Fill();
        }

        private void radioBttTodos_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 0;
            Fill();
        }

        private void radioBttFisica_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            Fill();
        }

        private void dataGViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGViewLista.CurrentCell.ColumnIndex;

            if (tipo == 1)
            {

            }
            else if (tipo == 2)
            {
                ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[1].Value.ToString()));
                FormJuridico fj = new FormJuridico(cj, 0);


            }
            else
            {

            }
        }
    }
}
