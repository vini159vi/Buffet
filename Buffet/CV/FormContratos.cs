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
    public partial class FormContratos : Form
    {
        int tipo;

        public FormContratos()
        {
            InitializeComponent();
            if (txtID.Text != "")
                Fill(int.Parse(txtID.Text));
            else
                Fill();
        }




        private void FormContratos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Fill()
        {
            ContratoDAO contratos = new ContratoDAO();
            dataGViewLista.Rows.Clear();


            if (tipo == 1)//Fisico
            {
                List<Contrato> listc = contratos.ListByFisico();
                foreach (Contrato c in listc)
                {
                    ClienteFisico cf = contratos.FindByFisico(c.PessoaFisica.Cpf);
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                    dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cf.Nome;
                    dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                    dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                    if (c.NotaFiscal == 1)
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                    else
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";
                }

            }
            else if (tipo == 2)//Juridico
            {
                List<Contrato> listc = contratos.ListByJuridico();

                foreach (Contrato c in listc)
                {
                    ClienteJuridico cj = contratos.FindByJuridico(c.PessoaJuridica.Cnpj);
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                    dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cj.NomeEmpresa;
                    dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                    dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                    if (c.NotaFiscal == 1)
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                    else
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";

                }
            }
            else
            {
                List<Contrato> listc = contratos.List();;

                foreach (Contrato c in listc)
                {
                    if (c.PessoaJuridica.Cnpj == 0)
                    {
                        ClienteFisico cf = contratos.FindByFisico(c.PessoaFisica.Cpf);
                        int index = dataGViewLista.Rows.Add();
                        dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                        dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                        dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cf.Nome;
                        dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                        dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                        if (c.NotaFiscal == 1)
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                        else
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";
                    }
                    else {
                        ClienteJuridico cj = contratos.FindByJuridico(c.PessoaJuridica.Cnpj);
                        int index = dataGViewLista.Rows.Add();
                        dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                        dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                        dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cj.NomeEmpresa;
                        dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                        dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                        if (c.NotaFiscal == 1)
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                        else
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";
                    }
                }

            }
        }

        public void Fill(int num)
        {
            ContratoDAO contratos = new ContratoDAO();

            dataGViewLista.Rows.Clear();

            if (tipo == 1)//Fisico
            {
                List<Contrato> listc = contratos.ListByIDFisico(num);

                foreach (Contrato c in listc)
                {
                    ClienteFisico cf = contratos.FindByFisico(c.PessoaFisica.Cpf);
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                    dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cf.Nome;
                    dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                    dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                    if (c.NotaFiscal == 1)
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                    else
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";
                }
            }
            else if (tipo == 2)//Juridico
            {
                List<Contrato> listc = contratos.ListByIDJuridico(num);

                foreach (Contrato c in listc)
                {
                    ClienteJuridico cj = contratos.FindByJuridico(c.PessoaJuridica.Cnpj);
                    int index = dataGViewLista.Rows.Add();
                    dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                    dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                    dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cj.NomeEmpresa;
                    dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                    dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                    if (c.NotaFiscal == 1)
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                    else
                        dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";

                }
            }
            else if (tipo == 0)//Todos
            {
                List<Contrato> listc = contratos.ListByID(num);

                foreach (Contrato c in listc)
                {
                    if (c.PessoaJuridica.Cnpj == 0)
                    {
                        ClienteFisico cf = contratos.FindByFisico(c.PessoaFisica.Cpf);
                        int index = dataGViewLista.Rows.Add();
                        dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                        dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Fisico";
                        dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cf.Nome;
                        dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                        dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                        if (c.NotaFiscal == 1)
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                        else
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";
                    }
                    else
                    {
                        ClienteJuridico cj = contratos.FindByJuridico(c.PessoaJuridica.Cnpj);
                        int index = dataGViewLista.Rows.Add();
                        dataGViewLista.Rows[index].Cells["cellID"].Value = c.Id;
                        dataGViewLista.Rows[index].Cells["cellTipo"].Value = "Juridico";
                        dataGViewLista.Rows[index].Cells["cellNomeEmpresa"].Value = cj.NomeEmpresa;
                        dataGViewLista.Rows[index].Cells["cellDataEvento"].Value = c.EventoData.ToString("dd/MM/yyyy") + " - " + c.EventoHora.ToString("HH:mm");
                        dataGViewLista.Rows[index].Cells["cellPreco"].Value = c.ContratadoPrecoPagar;

                        if (c.NotaFiscal == 1)
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Sim";
                        else
                            dataGViewLista.Rows[index].Cells["CellNotaFiscal"].Value = "Não";
                    }
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
                    ContratoDAO cDAO = new ContratoDAO();
                    cDAO.Delete(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                }
                else if (tipo == 2)//Juridico
                {
                    ContratoDAO cDAO = new ContratoDAO();
                    cDAO.Delete(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                }
                else if (tipo == 0)//Todos
                {
                    ContratoDAO cDAO = new ContratoDAO();
                    cDAO.Delete(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Não contem nenhuma pessoa registrada", "Buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (txtID.Text != "")
                    Fill(int.Parse(txtID.Text));
                else
                    Fill();
            }
        }

        private void dataGViewLista_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (txtID.Text != "")
                Fill(int.Parse(txtID.Text));
            else
                Fill();
        }

        private void radioBttJuridica_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            if (txtID.Text != "")
                Fill(int.Parse(txtID.Text));
            else
                Fill();
        }

        private void radioBttTodos_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 0;
            if (txtID.Text != "")
                Fill(int.Parse(txtID.Text));
            else
                Fill();

        }

        private void radioBttFisica_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            if (txtID.Text != "")
                Fill(int.Parse(txtID.Text));
            else
                Fill();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dataGViewLista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGViewLista.CurrentCell.RowIndex;

            if (tipo == 1)
            {
                ContratoDAO cDAO = new ContratoDAO();
                Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                FormContratoFísico fcf = new FormContratoFísico(c, 0);
                fcf.Show();
            }
            else if (tipo == 2)
            {
                ContratoDAO cDAO = new ContratoDAO();
                Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                //FormContratoJuridico fcj = new FormContratoJuridico(c, 0);
                //fcj.Show();
            }
            else if (tipo == 0)
            {
                if (dataGViewLista.Rows[index].Cells[1].Value.ToString() == "Fisico")
                {
                    ContratoDAO cDAO = new ContratoDAO();
                    Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                    FormContratoFísico fcf = new FormContratoFísico(c, 0);
                    fcf.Show();
                }
                else
                {
                    ContratoDAO cDAO = new ContratoDAO();
                    Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                    //FormContratoJuridico fcj = new FormContratoJuridico(c, 0);
                    //fcj.Show();
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "")
                Fill(int.Parse(txtID.Text));
            else
                Fill();
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            int index = dataGViewLista.CurrentCell.RowIndex;

            if (tipo == 1)
            {
                ContratoDAO cDAO = new ContratoDAO();
                Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                FormContratoFísico fcf = new FormContratoFísico(c, 1);
                fcf.Show();
            }
            else if (tipo == 2)
            {
                ContratoDAO cDAO = new ContratoDAO();
                Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                //FormContratoJuridico fcj = new FormContratoJuridico(c, 1);
                //fcj.Show();
            }
            else if (tipo == 0)
            {
                if (dataGViewLista.Rows[index].Cells[1].Value.ToString() == "Fisico")
                {
                    ContratoDAO cDAO = new ContratoDAO();
                    Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                    FormContratoFísico fcf = new FormContratoFísico(c, 1);
                    fcf.Show();
                }
                else
                {
                    ContratoDAO cDAO = new ContratoDAO();
                    Contrato c = cDAO.FindByID(int.Parse(dataGViewLista.Rows[index].Cells[0].Value.ToString()));
                    //FormContratoJuridico fcj = new FormContratoJuridico(c, 1);
                    //fcj.Show();
                }
            }
        }
    }
}
