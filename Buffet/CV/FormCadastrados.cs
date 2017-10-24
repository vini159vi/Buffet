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
            dataGViewLista.Columns[3].DefaultCellStyle.Format = @"(##) ####-####";
            dataGViewLista.Columns[4].DefaultCellStyle.Format = @"(##) #####-####";
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

            int index = dataGViewLista.CurrentCell.RowIndex;

            if (tipo == 1)
            {
                ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                FormFisico ff = new FormFisico(cf, 1);
                ff.ShowDialog();
            }
            else if (tipo == 2)
            {
                ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                FormJuridico fj = new FormJuridico(cj,1);
                fj.ShowDialog();
            }
            else
            {
               if(dataGViewLista.Rows[index].Cells[0].Value.ToString() == "Fisico")
                {
                    ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                    ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                    FormFisico ff = new FormFisico(cf, 1);
                    ff.ShowDialog();
                }
                else
                {
                    ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                    ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                    FormJuridico fj = new FormJuridico(cj, 1);
                    fj.ShowDialog();
                }
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

            if(tipo == 1)//Fisico
            {
                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Rows.Add("Fisico",cf.Nome, cf.Cpf.ToString(@"000\.000\.000\-00"), cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }
            else if(tipo == 2)//Juridico
            {
                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Rows.Add("Juridico",cj.NomeEmpresa, cj.Cnpj.ToString(@"00\.000\.000\\0000\-00"), rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }
            }
            else
            {
                foreach (ClienteJuridico cj in listcj)//Todos
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Rows.Add("Juridico", cj.NomeEmpresa, cj.Cnpj.ToString(@"00\.000\.000\\0000\-00"), rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa+"- "+ cj.Cidade);
                }

                foreach (ClienteFisico cf in listcf)
                {
                    dataGViewLista.Rows.Add("Fisico", cf.Nome, cf.Cpf.ToString(@"000\.000\.000\-00"), cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
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
                    dataGViewLista.Rows.Add("Fisico",cf.Nome, cf.Cpf.ToString(@"000\.000\.000\-00"), cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }
            else if (tipo == 2)//Juridico
            {
                List<ClienteJuridico> listcj = juridicos.ListByCNPJ(num);

                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Rows.Add("Juridico",cj.NomeEmpresa, cj.Cnpj.ToString(@"00\.000\.000\\0000\-00"), rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);
                }
            }
            else//Todos
            {
                List<ClienteJuridico> listcj = juridicos.ListByCNPJ(num);
                List<ClienteFisico> listcf = fisicos.ListByCPF(num);

                foreach (ClienteJuridico cj in listcj)
                {
                    RepresentanteJuridico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    dataGViewLista.Rows.Add("Juridico",cj.NomeEmpresa, cj.Cnpj.ToString(@"00\.000\.000\\0000\-00"), rj.Telefone, rj.Celular, cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade);

                }

                foreach (ClienteFisico cf in listcf)
                {

                    dataGViewLista.Rows.Add("Fisico",cf.Nome, cf.Cpf.ToString(@"000\.000\.000\-00"), cf.Telefone, cf.Celular, cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade);
                }
            }


        }


        private void bttRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGViewLista.CurrentCell.RowIndex;

                if (tipo == 1)//Fisico
                {
                    ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                    cfDAO.Delete(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                }
                else if (tipo == 2)//Juridico
                {
                    ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                    cjDAO.Delete(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                }
                else//Todos
                {
                    if (dataGViewLista.Rows[index].Cells[0].Value.ToString() == "Fisico")
                    {
                        ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                        cfDAO.Delete(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                    }
                    else
                    {
                        ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                        cjDAO.Delete(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                    }
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Não contem nenhuma pessoa registrada","Buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (txtBuscaCpfCnpj.Text != "")
                    Fill(long.Parse(txtBuscaCpfCnpj.Text));
                else
                    Fill();
            }
        }

        private void dataGViewLista_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (txtBuscaCpfCnpj.Text != "")
                Fill(long.Parse(txtBuscaCpfCnpj.Text));
            else
                Fill();
        }

        private void radioBttJuridica_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            if (txtBuscaCpfCnpj.Text != "")
                Fill(long.Parse(txtBuscaCpfCnpj.Text));
            else
                Fill();
        }

        private void radioBttTodos_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 0;
            if (txtBuscaCpfCnpj.Text != "")
                Fill(long.Parse(txtBuscaCpfCnpj.Text));
            else
                Fill();
        }

        private void radioBttFisica_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            if (txtBuscaCpfCnpj.Text != "")
                Fill(long.Parse(txtBuscaCpfCnpj.Text));
            else
                Fill();
        }

        private void dataGViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tirar
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBuscaNomeCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dataGViewLista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGViewLista.CurrentCell.RowIndex;

            if (tipo == 1)//Fisico
            {
                ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                FormFisico ff = new FormFisico(cf, 0);
                ff.ShowDialog();
            }
            else if (tipo == 2)//Juridico
            {
                ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\","").Replace("-","")));
                FormJuridico fj = new FormJuridico(cj, 0);
                fj.ShowDialog();

            }
            else//Todos
            {
                if (dataGViewLista.Rows[index].Cells[0].Value.ToString() == "Fisico")
                {
                    ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                    ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                    FormFisico ff = new FormFisico(cf, 0);
                    ff.ShowDialog();
                }
                else
                {
                    ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                    ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                    FormJuridico fj = new FormJuridico(cj, 0);
                    fj.ShowDialog();
                }
            }
        }

        private void txtBuscaCpfCnpj_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscaCpfCnpj.Text != "")
                Fill(long.Parse(txtBuscaCpfCnpj.Text));
            else
                Fill();
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
