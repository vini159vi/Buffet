﻿using System;
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
        //Global
        private int tipo;
        private bool check=false;
        public FormCadastrados()
        {
            InitializeComponent();
            dataGViewLista.Columns[3].DefaultCellStyle.Format = @"(##) ####-####";
            dataGViewLista.Columns[4].DefaultCellStyle.Format = @"(##) #####-####";
            if (txtBuscaCpfCnpj.Text != "")
                Fill(long.Parse(txtBuscaCpfCnpj.Text));
            else
                Fill();
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGViewLista.CurrentCell.RowIndex;

                if (tipo == 1)
                {
                    ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                    ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                    FormRepresentante fr = new FormRepresentante(cf, 1);
                    if (!fr.Visible)
                    {
                        fr.TopLevel = false;
                        FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                        fmm.panelWorkstation.Controls.Add(fr);
                        fr.Refresh();
                        fr.Show();
                    }
                }
                else if (tipo == 2)
                {
                    ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                    ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                    FormJuridico fj = new FormJuridico(cj, 1);
                    if (!fj.Visible)
                    {
                        fj.TopLevel = false;
                        FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                        fmm.panelWorkstation.Controls.Add(fj);
                        fj.Refresh();
                        fj.Show();
                    }
                }
                else if (tipo == 0)
                {
                    if (dataGViewLista.Rows[index].Cells[0].Value.ToString() == "Fisico")
                    {
                        ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                        ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                        FormRepresentante fr = new FormRepresentante(cf, 1);
                        if (!fr.Visible)
                        {
                            fr.TopLevel = false;
                            FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                            fmm.panelWorkstation.Controls.Add(fr);
                            fr.Refresh();
                            fr.Show();
                        }
                    }
                    else
                    {
                        ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                        ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                        FormJuridico fj = new FormJuridico(cj, 1);
                        if (!fj.Visible)
                        {
                            fj.TopLevel = false;
                            FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                            fmm.panelWorkstation.Controls.Add(fj);
                            fj.Refresh();
                            fj.Show();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não tem nenhum dado selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Fill()
        {
            ClienteJuridicoDAO juridicos = new ClienteJuridicoDAO();
            ClienteFisicoDAO fisicos = new ClienteFisicoDAO();
            List<ClienteFisico> listcf = new List<ClienteFisico>();
            List<ClienteJuridico> listcj = new List<ClienteJuridico>();

            dataGViewLista.Rows.Clear();

            if (tipo == 1)//Fisico
            {
                if (check)
                {
                    listcf = fisicos.ListHistorico();
                }
                else
                {
                    listcf = fisicos.List();
                }

                foreach (ClienteFisico cf in listcf)
                {

                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cf.Nome;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cf.Cpf.ToString(@"000\.000\.000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = cf.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = cf.Telefone;
                }

            }
            else if (tipo == 2)//Juridico
            {
                if (check)
                {
                    listcj = juridicos.ListHistorico();
                }
                else
                {
                    listcj = juridicos.List();
                }

                foreach (ClienteJuridico cj in listcj)
                {
                    ClienteFisico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cj.NomeEmpresa;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cj.Cnpj.ToString(@"00\.000\.000\\0000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = rj.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = rj.Telefone;

                }
            }
            else
            {
                if (check)
                {
                    listcj = juridicos.ListHistorico();
                    listcf = fisicos.ListHistorico();
                }
                else
                {
                    listcj = juridicos.List();
                    listcf = fisicos.List();
                }

                foreach (ClienteJuridico cj in listcj)
                {
                    ClienteFisico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cj.NomeEmpresa;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cj.Cnpj.ToString(@"00\.000\.000\\0000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = rj.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = rj.Telefone;

                }

                foreach (ClienteFisico cf in listcf)
                {

                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cf.Nome;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cf.Cpf.ToString(@"000\.000\.000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = cf.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = cf.Telefone;
                }

            }
        }

        public void Fill(long num)
        {
            ClienteJuridicoDAO juridicos = new ClienteJuridicoDAO();
            ClienteFisicoDAO fisicos = new ClienteFisicoDAO();
            List<ClienteFisico> listcf = new List<ClienteFisico>();
            List<ClienteJuridico> listcj = new List<ClienteJuridico>();

            dataGViewLista.Rows.Clear();

            if (tipo == 1)//Fisico
            {
                if (check)
                {
                    listcf = fisicos.ListByCpfHistorico(num);
                }
                else
                {
                    listcf = fisicos.ListByCPF(num);
                }

                foreach (ClienteFisico cf in listcf)
                {
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cf.Nome;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cf.Cpf.ToString(@"000\.000\.000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = cf.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = cf.Telefone;
                }
            }
            else if (tipo == 2 )//Juridico
            {
                if (check)
                {
                    listcj = juridicos.ListByCNPJHistorico(num);
                }
                else
                {
                    listcj = juridicos.ListByCNPJ(num);
                }


                foreach (ClienteJuridico cj in listcj)
                {
                    ClienteFisico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    List<ClienteFisico> listRepresentante = juridicos.ListByRepresentante(cj.Cnpj);

                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cj.NomeEmpresa;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cj.Cnpj.ToString(@"00\.000\.000\\0000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = rj.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = rj.Telefone;

                }
            }
            else if (tipo == 0)//Todos
            {
                if (check)
                {
                    listcj = juridicos.ListByCNPJHistorico(num);
                    listcf = fisicos.ListByCpfHistorico(num);
                }
                else
                {
                    listcj = juridicos.ListByCNPJ(num);
                    listcf = fisicos.ListByCPF(num);
                }

                foreach (ClienteJuridico cj in listcj)
                {
                    ClienteFisico rj = juridicos.FindByRepresentante(cj.Cnpj);
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cj.NomeEmpresa;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cj.Cnpj.ToString(@"00\.000\.000\\0000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cj.Rua + ", " + cj.NumeroEmpresa + "- " + cj.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = rj.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = rj.Telefone;

                }

                foreach (ClienteFisico cf in listcf)
                {

                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                    dataGViewLista.Rows[index].Cells["Nome"].Value = cf.Nome;
                    dataGViewLista.Rows[index].Cells["CPF_CNPJ"].Value = cf.Cpf.ToString(@"000\.000\.000\-00");
                    dataGViewLista.Rows[index].Cells["Endereço"].Value = cf.Rua + ", " + cf.NumeroCasa + "- " + cf.Cidade;
                    dataGViewLista.Rows[index].Cells["Celular"].Value = cf.Celular;
                    dataGViewLista.Rows[index].Cells["Telefone"].Value = cf.Telefone;
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
                else if (tipo == 0)//Todos
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

        private void dataGViewLista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGViewLista.CurrentCell.RowIndex;

            if (tipo == 1)//Fisico
            {
                ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                FormRepresentante fr = new FormRepresentante(cf, 0);
                if (!fr.Visible)
                {
                    fr.TopLevel = false;
                    FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                    fmm.panelWorkstation.Controls.Add(fmm);
                    fr.Refresh();
                    fr.Show();
                }
            }
            else if (tipo == 2)//Juridico
            {
                ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\","").Replace("-","")));
                FormJuridico fj = new FormJuridico(cj, 0);
                if (!fj.Visible)
                {
                    fj.TopLevel = false;
                    FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                    fmm.panelWorkstation.Controls.Add(fj);
                    fj.Refresh();
                    fj.Show();
                }

            }
            else//Todos
            {
                if (dataGViewLista.Rows[index].Cells[0].Value.ToString() == "Fisico")
                {
                    ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
                    ClienteFisico cf = cfDAO.FindByCPF(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace("-", "")));
                    FormRepresentante fr = new FormRepresentante(cf, 0);
                    if (!fr.Visible)
                    {
                        FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                        fr.TopLevel = false;
                        fmm.panelWorkstation.Controls.Add(fr);
                        fr.Refresh();
                        fr.Show();
                    }
                }
                else
                {
                    ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
                    ClienteJuridico cj = cjDAO.FindByCNPJ(long.Parse(dataGViewLista.Rows[index].Cells[2].Value.ToString().Replace(".", "").Replace(@"\", "").Replace("-", "")));
                    FormJuridico fj = new FormJuridico(cj, 0);
                    if (!fj.Visible)
                    {
                        FormMenuModern fmm = Application.OpenForms["FormMenuModern"] as FormMenuModern;
                        fj.TopLevel = false;
                        fmm.panelWorkstation.Controls.Add(fj);
                        fj.Refresh();
                        fj.Show();
                    }
                }
            }
        }

        private void txtBuscaCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            UpdateFill();

        }

        private void FormCadastrados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void checkBoxHistorico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHistorico.Checked != true)
            {
                check = false;
                UpdateFill();
            }
            else
            {
                check = true;
                UpdateFill();
            }
        }

        private void UpdateFill()
        {
            if (txtBuscaCpfCnpj.Text != "")
                Fill(long.Parse(txtBuscaCpfCnpj.Text));
            else
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
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Numeros!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
