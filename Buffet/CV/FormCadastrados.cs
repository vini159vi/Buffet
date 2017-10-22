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
            dataGViewLista.Columns[2].DefaultCellStyle.Format = @"(##) ####-####";
            dataGViewLista.Columns[3].DefaultCellStyle.Format = @"(##) #####-####";
            Fill();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {

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
            List<ClienteFisico> listcf = fisicos.List();

            RepresentanteDAO representantes = new RepresentanteDAO();
            List<RepresentanteJuridico> listrj = representantes.List();

            dataGViewLista.Rows.Clear();

            if(tipo == 1)
            {
                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"000\.000\.000\-00";
                    dataGViewLista.Rows.Add(cf.Nome, cf.Cpf, cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }
            else if(tipo == 2)
            {
                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"00\.000\.000\\0000\-00";
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }
            }
            else
            {
                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"00\.000\.000\\0000\-00";
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa+"- "+ cj.Cidade);
                }

                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"000\.000\.000\-00";
                    dataGViewLista.Rows.Add(cf.Nome, cf.Cpf, cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }


        }

        public void Fill(long num)
        {
            ClienteJuridicoDAO juridicos = new ClienteJuridicoDAO();
            ClienteFisicoDAO fisicos = new ClienteFisicoDAO();
            RepresentanteDAO representantes = new RepresentanteDAO();

            dataGViewLista.Rows.Clear();

            if (tipo == 1)//Fisico
            {
                List<ClienteFisico> listcf = fisicos.ListByCPF(num);

                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"000\.000\.000\-00";
                    dataGViewLista.Rows.Add(cf.Nome, cf.Cpf, cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }
            else if (tipo == 2)//Juridico
            {
                List<ClienteJuridico> listcj = juridicos.ListByCNPJ(num);

                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"00\.000\.000\\0000\-00";
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }
            }
            else//Todos
            {
                List<ClienteJuridico> listcj = juridicos.ListByCNPJ(num);
                List<ClienteFisico> listcf = fisicos.ListByCPF(num);

                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"00\.000\.000\\0000\-00";
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }

                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"000\.000\.000\-00";
                    dataGViewLista.Rows.Add(cf.Nome, cf.Cpf, cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }


        }


        public void Fill(string nome)
        {
            ClienteJuridicoDAO juridicos = new ClienteJuridicoDAO();
            ClienteFisicoDAO fisicos = new ClienteFisicoDAO();
            RepresentanteDAO representantes = new RepresentanteDAO();

            dataGViewLista.Rows.Clear();

            if (tipo == 1)//Fisico
            {
                List<ClienteFisico> listcf = fisicos.ListByName(nome);

                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"000\.000\.000\-00";
                    dataGViewLista.Rows.Add(cf.Nome, cf.Cpf, cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }
            else if (tipo == 2)//Juridico
            {
                List<ClienteJuridico> listcj = juridicos.ListByName(nome);

                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"00\.000\.000\\0000\-00";
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }
            }
            else//Todos
            {
                List<ClienteJuridico> listcj = juridicos.ListByName(nome);
                List<ClienteFisico> listcf = fisicos.ListByName(nome);

                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"00\.000\.000\\0000\-00";
                    dataGViewLista.Rows.Add(cj.NomeEmpresa, cj.Cnpj, rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }

                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Columns[1].DefaultCellStyle.Format = @"000\.000\.000\-00";
                    dataGViewLista.Rows.Add(cf.Nome, cf.Cpf, cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
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

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBuscaNomeCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                Fill(txtBuscaNomeCPF.Text);

            }
            else if (char.IsNumber(e.KeyChar))
            {
                Fill(txtBuscaNomeCPF.Text);
            }
        }

        /*private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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
        }*/



    }
}
