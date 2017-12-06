using Buffet.DAO;
using Buffet.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Buffet.CV
{
    public partial class FormContratoCardapio : Form
    {
        private Contrato c = new Contrato();
        private ClienteFisico cf = new ClienteFisico();
        private ClienteJuridico cj = null;

        private int selecionada=0;
        private long cpf, cnpj;
        private int check, contrato;
        public FormContratoCardapio()
        {
            InitializeComponent();

        }

        public FormContratoCardapio(Contrato c, long cpf, long cnpj, int contrato)
        {
            InitializeComponent();
            Fill();
            this.c = c;
            this.cpf = cpf;
            this.cnpj = cnpj;
            this.contrato = contrato;

            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();

            if (cnpj != 0)
            {
                this.cj = cjDAO.FindByCNPJ(cnpj);
                this.cf = cfDAO.FindByCPF(cpf);
            }
            else
            {
                this.cj = null;
                this.cf = cfDAO.FindByCPF(cpf);
            }



        }

        private void radioBttTipo1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttTipo1.Checked)
                check = 0;

            Fill();
        }

        private void radioBttTipo2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBttTipo2.Checked)
                check = 1;

            Fill();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            
            ItemDAO iDAO = new ItemDAO();
            string nome, tipo;
            double valor;
            int id,aux=0;
            try
            {
                int index = dgvItens.CurrentCell.RowIndex;
                id = int.Parse(dgvItens.Rows[index].Cells["cellID"].Value.ToString());
                tipo = dgvItens.Rows[index].Cells["cellTipo"].Value.ToString();
                valor = double.Parse(dgvItens.Rows[index].Cells["cellValorPessoa"].Value.ToString());
                nome = dgvItens.Rows[index].Cells["cellNome"].Value.ToString();
                Console.WriteLine(tipo);
                Console.WriteLine(nome);
                Console.WriteLine(id);
                Console.WriteLine(valor);

                switch (tipo)
                {
                    case "Pratos Quentes":
                        aux = 0;
                        break;
                    case "Salada":
                        aux = 1;
                        break;
                    case "Fruta":
                        aux = 2;
                        break;
                    case "Frios":
                        aux = 3;
                        break;
                    case "Bebida":
                        aux = 4;
                        break;
                    case "Serviço":
                        aux = 5;
                        break;
                }


                switch (aux)
                {
                    case 0:
                        int indexPQuentes = dgvPratosQuentes.Rows.Add();
                        dgvPratosQuentes.Rows[indexPQuentes].Cells["ColumnIDPratosQuentes"].Value = id;
                        dgvPratosQuentes.Rows[indexPQuentes].Cells["ColumnNomePratosQuentes"].Value = nome;
                        dgvPratosQuentes.Rows[indexPQuentes].Cells["ColumnValorPratosQuentes"].Value = valor;
                        dgvItens.Rows.RemoveAt(index);
                        break;
                    case 1:
                        int indexSaladas = dgvSaladas.Rows.Add();
                        dgvSaladas.Rows[indexSaladas].Cells["ColumnIDSaladas"].Value = id;
                        dgvSaladas.Rows[indexSaladas].Cells["ColumnNomeSaladas"].Value = nome;
                        dgvSaladas.Rows[indexSaladas].Cells["ColumnValorSaladas"].Value = valor;
                        dgvItens.Rows.RemoveAt(index);
                        break;
                    case 2:
                        int indexFrutas = dgvFrutas.Rows.Add();
                        dgvFrutas.Rows[indexFrutas].Cells["ColumnIDFrutas"].Value = id;
                        dgvFrutas.Rows[indexFrutas].Cells["ColumnNomeFrutas"].Value = nome;
                        dgvFrutas.Rows[indexFrutas].Cells["ColumnValorFrutas"].Value = valor;
                        dgvItens.Rows.RemoveAt(index);
                        break;
                    case 3:
                        int indexFrios = dgvFrios.Rows.Add();
                        dgvFrios.Rows[indexFrios].Cells["ColumnIDFrios"].Value = id;
                        dgvFrios.Rows[indexFrios].Cells["ColumnNomeFrios"].Value = nome;
                        dgvFrios.Rows[indexFrios].Cells["ColumnValorFrios"].Value = valor;
                        dgvItens.Rows.RemoveAt(index);
                        break;
                    case 4:
                        int indexBebidas = dgvBebidas.Rows.Add();
                        dgvBebidas.Rows[indexBebidas].Cells["ColumnIDBebidas"].Value = id;
                        dgvBebidas.Rows[indexBebidas].Cells["ColumnNomeBebidas"].Value = nome;
                        dgvBebidas.Rows[indexBebidas].Cells["ColumnValorBebidas"].Value = valor;
                        dgvItens.Rows.RemoveAt(index);
                        break;
                    case 5:
                        int indexServicos = dgvServicos.Rows.Add();
                        dgvServicos.Rows[indexServicos].Cells["ColumnIDServicos"].Value = id;
                        dgvServicos.Rows[indexServicos].Cells["ColumnNomeServicos"].Value = nome;
                        dgvServicos.Rows[indexServicos].Cells["ColumnValorServicos"].Value = valor;
                        dgvItens.Rows.RemoveAt(index);
                        break;
                }
                txtTotal.Text = String.Format(@"Valor Total:R$:" + Total(c.EventoNConvidados).ToString() + "\nValor por cabeça:R$:" + ValorCabeca(c.EventoNConvidados).ToString());
                txtTotal.Text.Replace(@"\n", "<br>");
            }
            catch
            {
                MessageBox.Show("Você não selecionou um produto valido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bttRemover_Click(object sender, EventArgs e)
        {
            ItemDAO iDAO = new ItemDAO();
            int index=0;
            string nome="", tipo="";
            double valor=0;
            int id = 0;

            try
            {
                if (selecionada == 0)
                {
                    index = dgvPratosQuentes.CurrentCell.RowIndex;
                    id = int.Parse(dgvPratosQuentes.Rows[index].Cells["ColumnIDPratosQuentes"].Value.ToString());
                    tipo = "Pratos Quentes";
                    valor = double.Parse(dgvPratosQuentes.Rows[index].Cells["ColumnValorPratosQuentes"].Value.ToString());
                    nome = dgvPratosQuentes.Rows[index].Cells["ColumnNomePratosQuentes"].Value.ToString();
                    dgvPratosQuentes.Rows.RemoveAt(index);
                }
                if (selecionada == 1)
                {
                    index = dgvSaladas.CurrentCell.RowIndex;
                    id = int.Parse(dgvSaladas.Rows[index].Cells["ColumnIDSaladas"].Value.ToString());
                    tipo = "Saladas";
                    valor = double.Parse(dgvSaladas.Rows[index].Cells["ColumnValorSaladas"].Value.ToString());
                    nome = dgvSaladas.Rows[index].Cells["ColumnNomeSaladas"].Value.ToString();
                    dgvSaladas.Rows.RemoveAt(index);
                }
                if (selecionada == 2)
                {
                    index = dgvFrutas.CurrentCell.RowIndex;
                    id = int.Parse(dgvFrutas.Rows[index].Cells["ColumnIDFrutas"].Value.ToString());
                    tipo = "Frutas";
                    valor = double.Parse(dgvFrutas.Rows[index].Cells["ColumnValorFrutas"].Value.ToString());
                    nome = dgvFrutas.Rows[index].Cells["ColumnNomeFrutas"].Value.ToString();
                    dgvFrutas.Rows.RemoveAt(index);
                }
                if (selecionada == 3)
                {
                    index = dgvFrios.CurrentCell.RowIndex;
                    id = int.Parse(dgvFrios.Rows[index].Cells["ColumnIDFrios"].Value.ToString());
                    tipo = "Frios";
                    valor = double.Parse(dgvFrios.Rows[index].Cells["ColumnValorFrios"].Value.ToString());
                    nome = dgvFrios.Rows[index].Cells["ColumnNomeFrios"].Value.ToString();
                    dgvFrios.Rows.RemoveAt(index);
                }
                if (selecionada == 4)
                {
                    index = dgvBebidas.CurrentCell.RowIndex;
                    id = int.Parse(dgvBebidas.Rows[index].Cells["ColumnIDBebidas"].Value.ToString());
                    tipo = "Bebidas";
                    valor = double.Parse(dgvBebidas.Rows[index].Cells["ColumnValorBebidas"].Value.ToString());
                    nome = dgvBebidas.Rows[index].Cells["ColumnNomeBebidas"].Value.ToString();
                    dgvBebidas.Rows.RemoveAt(index);
                }
                if (selecionada == 5)
                {
                    index = dgvServicos.CurrentCell.RowIndex;
                    id = int.Parse(dgvServicos.Rows[index].Cells["ColumnIDServicos"].Value.ToString());
                    tipo = "Serviços";
                    valor = double.Parse(dgvServicos.Rows[index].Cells["ColumnValorServicos"].Value.ToString());
                    nome = dgvServicos.Rows[index].Cells["ColumnNomeServicos"].Value.ToString();
                    dgvServicos.Rows.RemoveAt(index);
                }

                int indexNovo = dgvItens.Rows.Add();
                dgvItens.Rows[indexNovo].Cells["cellID"].Value = id;
                dgvItens.Rows[indexNovo].Cells["cellTipo"].Value = tipo;
                dgvItens.Rows[indexNovo].Cells["cellValorPessoa"].Value = valor;
                dgvItens.Rows[indexNovo].Cells["cellNome"].Value = nome;
            }
            catch
            {
                MessageBox.Show("Você não selecionou um produto valido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtTotal.Text = String.Format(@"Valor Total:R$:" + Total(c.EventoNConvidados).ToString() + "\nValor por cabeça:R$:" + ValorCabeca(c.EventoNConvidados).ToString());
            txtTotal.Text.Replace(@"\n", "<br>");
        }

        private void bttGerarContrato_Click(object sender, EventArgs e)
        {
            ContratoDAO cDAO = new ContratoDAO();
            c.ContratadoPrecoPagar = Total(c.EventoNConvidados);

            if (cj == null)
            {
                cDAO.Create(c);
                CriarDocumento(c, cf, null, contrato, ValorCabeca(c.EventoNConvidados));
            }
            else
            {
                cDAO.Create(c);
                CriarDocumento(c, cf, cj, contrato, ValorCabeca(c.EventoNConvidados));
            }
            this.Hide();

        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Fill()
        {
            ItemDAO iDAO = new ItemDAO();
            List<Item> listI = iDAO.List();
            dgvItens.Rows.Clear();
            dgvPratosQuentes.Rows.Clear();
            dgvSaladas.Rows.Clear();
            dgvFrutas.Rows.Clear();
            dgvFrios.Rows.Clear();
            dgvBebidas.Rows.Clear();
            dgvServicos.Rows.Clear();

            foreach (Item i in listI)
            {
                bool verifica = Filtro(i);
                if (verifica)
                {
                    switch (i.Tipo)
                    {
                        case 0:
                            int indexPQuentes = dgvPratosQuentes.Rows.Add();
                            dgvPratosQuentes.Rows[indexPQuentes].Cells["ColumnIDPratosQuentes"].Value = i.Id;
                            dgvPratosQuentes.Rows[indexPQuentes].Cells["ColumnNomePratosQuentes"].Value = i.Nome ;
                            dgvPratosQuentes.Rows[indexPQuentes].Cells["ColumnValorPratosQuentes"].Value =i.ValorCabeca;
                            break;
                        case 1:
                            int indexSaladas = dgvSaladas.Rows.Add();
                            dgvSaladas.Rows[indexSaladas].Cells["ColumnIDSaladas"].Value = i.Id;
                            dgvSaladas.Rows[indexSaladas].Cells["ColumnNomeSaladas"].Value = i.Nome;
                            dgvSaladas.Rows[indexSaladas].Cells["ColumnValorSaladas"].Value = i.ValorCabeca;
                            break;
                        case 2:
                            int indexFrutas = dgvFrutas.Rows.Add();
                            dgvFrutas.Rows[indexFrutas].Cells["ColumnIDFrutas"].Value = i.Id;
                            dgvFrutas.Rows[indexFrutas].Cells["ColumnNomeFrutas"].Value = i.Nome;
                            dgvFrutas.Rows[indexFrutas].Cells["ColumnValorFrutas"].Value = i.ValorCabeca;
                            break;
                        case 3:
                            int indexFrios = dgvFrios.Rows.Add();
                            dgvFrios.Rows[indexFrios].Cells["ColumnIDFrios"].Value = i.Id;
                            dgvFrios.Rows[indexFrios].Cells["ColumnNomeFrios"].Value = i.Nome;
                            dgvFrios.Rows[indexFrios].Cells["ColumnValorFrios"].Value = i.ValorCabeca;
                            break;
                        case 4:
                            int indexBebidas = dgvBebidas.Rows.Add();
                            dgvBebidas.Rows[indexBebidas].Cells["ColumnIDBebidas"].Value = i.Id;
                            dgvBebidas.Rows[indexBebidas].Cells["ColumnNomeBebidas"].Value = i.Nome;
                            dgvBebidas.Rows[indexBebidas].Cells["ColumnValorBebidas"].Value = i.ValorCabeca;
                            break;
                        case 5:
                            int indexServicos = dgvServicos.Rows.Add();
                            dgvServicos.Rows[indexServicos].Cells["ColumnIDServicos"].Value = i.Id;
                            dgvServicos.Rows[indexServicos].Cells["ColumnNomeServicos"].Value = i.Nome;
                            dgvServicos.Rows[indexServicos].Cells["ColumnValorServicos"].Value = i.ValorCabeca;
                            break;
                    }
                }
                else
                {
                    int index = dgvItens.Rows.Add();

                    dgvItens.Rows[index].Cells["cellID"].Value = i.Id;
                    dgvItens.Rows[index].Cells["cellNome"].Value = i.Nome;
                    dgvItens.Rows[index].Cells["cellValorPessoa"].Value = i.ValorCabeca;
                    switch (i.Tipo)
                    {
                        case 0:
                            dgvItens.Rows[index].Cells["cellTipo"].Value = "Pratos Quentes";
                            break;
                        case 1:
                            dgvItens.Rows[index].Cells["cellTipo"].Value = "Salada";
                            break;
                        case 2:
                            dgvItens.Rows[index].Cells["cellTipo"].Value = "Fruta";
                            break;
                        case 3:
                            dgvItens.Rows[index].Cells["cellTipo"].Value = "Frio";
                            break;
                        case 4:
                            dgvItens.Rows[index].Cells["cellTipo"].Value = "Bebida";
                            break;
                        case 5:
                            dgvItens.Rows[index].Cells["cellTipo"].Value = "Serviço";
                            break;
                    }
                }
            }
            txtTotal.Text = String.Format(@"Valor Total:R$:"+Total(c.EventoNConvidados).ToString()+"\nValor por cabeça:R$:"+ValorCabeca(c.EventoNConvidados).ToString());
            txtTotal.Text.Replace(@"\n", "<br>");
        }

        private bool Filtro(Item i)
        {
            ItemDAO iDAO = new ItemDAO();
            int aux = 0;

            if (check == 0)
                aux = 1;
            else if (check == 1)
                aux = 2;

            if (iDAO.Verifica(i.Id, aux))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double Total(int pessoas)
        {
            double total=0;
            double aux;
            foreach (DataGridViewRow i in dgvBebidas.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorBebidas"].Value.ToString());
                total += aux;
            }
            foreach (DataGridViewRow i in dgvFrios.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorFrios"].Value.ToString());
                total += aux;
            }
            foreach (DataGridViewRow i in dgvFrutas.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorFrutas"].Value.ToString());
                total += aux;
            }
            foreach (DataGridViewRow i in dgvPratosQuentes.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorPratosQuentes"].Value.ToString());
                total += aux;
            }
            foreach (DataGridViewRow i in dgvSaladas.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorSaladas"].Value.ToString());
                total += aux;
            }
            foreach (DataGridViewRow i in dgvServicos.Rows)
            {

                aux = double.Parse(i.Cells["ColumnValorServicos"].Value.ToString());
                total += aux;
            }
            total = total * pessoas;
            return total;
        }

        private double ValorCabeca(int pessoas)
        {
            double valorCabeca = 0;
            double aux;
            foreach (DataGridViewRow i in dgvBebidas.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorBebidas"].Value.ToString());
                valorCabeca += aux;
            }
            foreach (DataGridViewRow i in dgvFrios.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorFrios"].Value.ToString());
                valorCabeca += aux;
            }
            foreach (DataGridViewRow i in dgvFrutas.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorFrutas"].Value.ToString());
                valorCabeca += aux;
            }
            foreach (DataGridViewRow i in dgvPratosQuentes.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorPratosQuentes"].Value.ToString());
                valorCabeca += aux;
            }
            foreach (DataGridViewRow i in dgvSaladas.Rows)
            {
                aux = double.Parse(i.Cells["ColumnValorSaladas"].Value.ToString());
                valorCabeca += aux;
            }
            foreach (DataGridViewRow i in dgvServicos.Rows)
            {

                aux = double.Parse(i.Cells["ColumnValorServicos"].Value.ToString());
                valorCabeca += aux;
            }

            valorCabeca = (valorCabeca*pessoas) / pessoas;
            return valorCabeca;
        }

        public void CriarDocumento(Contrato c, ClienteFisico cf, ClienteJuridico cj, int tipo, double ValorCabeca)
        {
            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            

            string path = Directory.GetCurrentDirectory();
            object missing = System.Reflection.Missing.Value;
            object template = "";
            Word.Application oApp = new Word.Application();

            if (cj == null)
            {
                switch (tipo)
                {
                    case 0:
                        template = (path + @"\Modelos\ContratoAniversariantePessoaFisica.doc");
                        break;
                    case 1:
                        template = (path + @"\Modelos\ContratoCasamentoPessoaFisica.doc");
                        break;
                    case 2:
                        template = (path + @"\Modelos\Contrato15AnosPessoaFisica.doc");
                        break;
                    case 4:
                        template = (path + @"\Modelos\ContratoEventosGeraisPessoaFisica.doc");
                        break;
                    case 3:
                        MessageBox.Show("Pessoa Fisica não pode fazer festa de Empresa", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Hide();
                        break;
                }
            }
            else
            {
                switch (tipo)
                {
                    case 0:
                        template = (path + @"\Modelos\ContratoAniversariantePessoaJuridica.doc");//Aniversario
                        break;
                    case 1:
                        template = (path + @"\Modelos\ContratoCasamentoPessoaJuridica.doc");//Casamento
                        break;
                    case 2:
                        template = (path + @"\Modelos\Contrato15AnosPessoaJuridica.doc");//15 Anos
                        break;
                    case 3:
                        template = (path + @"\Modelos\ContratoFestaEmpresaPessoaJuridica.doc");//Empresa
                        break;
                    case 4:
                        template = (path + @"\Modelos\ContratoEventosGeraisPessoaJuridica.doc");//Eventos Gerais
                        break;
                }
            }
            Word.Document oDoc = new Word.Document();

            try
            {
                oDoc = oApp.Documents.Open(ref template, ref missing, ref missing, ref missing);

                if (cj == null)
                {
                    string aux, aux2, aux3, aux4, aux5, aux6;
                    switch (tipo)
                    {
                        case 0:
                            this.Substitui(oDoc, "@nomeFisico", cf.Nome);
                            this.Substitui(oDoc, "@cidadeFisico", cf.Cidade);
                            this.Substitui(oDoc, "@ruaFisico", cf.Rua);
                            this.Substitui(oDoc, "@numeroFisico", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroFisico", cf.Bairro);
                            this.Substitui(oDoc, "@cepFisico", cf.Cep);
                            this.Substitui(oDoc, "@estadoFisico", cf.Estado);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);
                            this.Substitui(oDoc, "@nomeAniversariante", c.NomeAniversariante);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);

                            break;
                        case 1:
                            this.Substitui(oDoc, "@nomeFisico", cf.Nome);
                            this.Substitui(oDoc, "@cidadeFisico", cf.Cidade);
                            this.Substitui(oDoc, "@ruaFisico", cf.Rua);
                            this.Substitui(oDoc, "@numeroFisico", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroFisico", cf.Bairro);
                            this.Substitui(oDoc, "@cepFisico", cf.Cep);
                            this.Substitui(oDoc, "@estadoFisico", cf.Estado);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                        case 2:
                            this.Substitui(oDoc, "@nomeFisico", cf.Nome);
                            this.Substitui(oDoc, "@cidadeFisico", cf.Cidade);
                            this.Substitui(oDoc, "@ruaFisico", cf.Rua);
                            this.Substitui(oDoc, "@numeroFisico", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroFisico", cf.Bairro);
                            this.Substitui(oDoc, "@cepFisico", cf.Cep);
                            this.Substitui(oDoc, "@estadoFisico", cf.Estado);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);
                            this.Substitui(oDoc, "@nomeAniversariante", c.NomeAniversariante);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                        case 4:
                            this.Substitui(oDoc, "@nomeFisico", cf.Nome);
                            this.Substitui(oDoc, "@cidadeFisico", cf.Cidade);
                            this.Substitui(oDoc, "@ruaFisico", cf.Rua);
                            this.Substitui(oDoc, "@numeroFisico", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroFisico", cf.Bairro);
                            this.Substitui(oDoc, "@cepFisico", cf.Cep);
                            this.Substitui(oDoc, "@estadoFisico", cf.Estado);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                        case 3:
                            MessageBox.Show("Pessoa Fisica não pode fazer festa de Empresa", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    string aux,aux2,aux3,aux4,aux5,aux6;
                    switch (tipo)
                    {

                        case 0:
                            this.Substitui(oDoc, "@nomeEmpresa", cj.NomeEmpresa);
                            this.Substitui(oDoc, "@cidadeEmpresa", cj.Cidade);
                            this.Substitui(oDoc, "@ruaEmpresa", cj.Rua);
                            this.Substitui(oDoc, "@numeroEmpresa", cj.NumeroEmpresa);
                            this.Substitui(oDoc, "@bairroEmpresa", cj.Bairro);
                            this.Substitui(oDoc, "@cepEmpresa", cj.Cep);
                            this.Substitui(oDoc, "@estadoJuridico", cj.Estado);
                            this.Substitui(oDoc, "@cnpj", cj.Cnpj);
                            this.Substitui(oDoc, "@nomeRepresentante", cf.Nome);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);
                            this.Substitui(oDoc, "@ruaRepresentante", cf.Rua);
                            this.Substitui(oDoc, "@numeroCasa", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroRepresentante", cf.Bairro);
                            this.Substitui(oDoc, "@cepRepresentante", cf.Cep);
                            this.Substitui(oDoc, "@cidadeRepresentante", cf.Cidade);
                            this.Substitui(oDoc, "@estadoRepresentante", cf.Estado);
                            this.Substitui(oDoc, "@nomeAniversariante", c.NomeAniversariante);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                        case 1:
                            this.Substitui(oDoc, "@nomeEmpresa", cj.NomeEmpresa);
                            this.Substitui(oDoc, "@cidadeEmpresa", cj.Cidade);
                            this.Substitui(oDoc, "@ruaEmpresa", cj.Rua);
                            this.Substitui(oDoc, "@numeroEmpresa", cj.NumeroEmpresa);
                            this.Substitui(oDoc, "@bairroEmpresa", cj.Bairro);
                            this.Substitui(oDoc, "@cepEmpresa", cj.Cep);
                            this.Substitui(oDoc, "@estadoJuridico", cj.Estado);
                            this.Substitui(oDoc, "@cnpj", cj.Cnpj);
                            this.Substitui(oDoc, "@nomeRepresentante", cf.Nome);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);
                            this.Substitui(oDoc, "@ruaRepresentante", cf.Rua);
                            this.Substitui(oDoc, "@numeroCasa", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroRepresentante", cf.Bairro);
                            this.Substitui(oDoc, "@cepRepresentante", cf.Cep);
                            this.Substitui(oDoc, "@cidadeRepresentante", cf.Cidade);
                            this.Substitui(oDoc, "@estadoRepresentante", cf.Estado);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                        case 2:
                            this.Substitui(oDoc, "@nomeEmpresa", cj.NomeEmpresa);
                            this.Substitui(oDoc, "@cidadeEmpresa", cj.Cidade);
                            this.Substitui(oDoc, "@ruaEmpresa", cj.Rua);
                            this.Substitui(oDoc, "@numeroEmpresa", cj.NumeroEmpresa);
                            this.Substitui(oDoc, "@bairroEmpresa", cj.Bairro);
                            this.Substitui(oDoc, "@cepEmpresa", cj.Cep);
                            this.Substitui(oDoc, "@estadoJuridico", cj.Estado);
                            this.Substitui(oDoc, "@cnpj", cj.Cnpj);
                            this.Substitui(oDoc, "@nomeRepresentante", cf.Nome);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);
                            this.Substitui(oDoc, "@ruaRepresentante", cf.Rua);
                            this.Substitui(oDoc, "@numeroCasa", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroRepresentante", cf.Bairro);
                            this.Substitui(oDoc, "@cepRepresentante", cf.Cep);
                            this.Substitui(oDoc, "@cidadeRepresentante", cf.Cidade);
                            this.Substitui(oDoc, "@estadoRepresentante", cf.Estado);
                            this.Substitui(oDoc, "@nomeAniversariante", c.NomeAniversariante);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                        case 3:
                            this.Substitui(oDoc, "@nomeEmpresa", cj.NomeEmpresa);
                            this.Substitui(oDoc, "@cidadeEmpresa", cj.Cidade);
                            this.Substitui(oDoc, "@ruaEmpresa", cj.Rua);
                            this.Substitui(oDoc, "@numeroEmpresa", cj.NumeroEmpresa);
                            this.Substitui(oDoc, "@bairroEmpresa", cj.Bairro);
                            this.Substitui(oDoc, "@cepEmpresa", cj.Cep);
                            this.Substitui(oDoc, "@estadoJuridico", cj.Estado);
                            this.Substitui(oDoc, "@cnpj", cj.Cnpj);
                            this.Substitui(oDoc, "@nomeRepresentante", cf.Nome);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);
                            this.Substitui(oDoc, "@ruaRepresentante", cf.Rua);
                            this.Substitui(oDoc, "@numeroCasa", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroRepresentante", cf.Bairro);
                            this.Substitui(oDoc, "@cepRepresentante", cf.Cep);
                            this.Substitui(oDoc, "@cidadeRepresentante", cf.Cidade);
                            this.Substitui(oDoc, "@estadoRepresentante", cf.Estado);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                        case 4:
                            this.Substitui(oDoc, "@nomeEmpresa", cj.NomeEmpresa);
                            this.Substitui(oDoc, "@cidadeEmpresa", cj.Cidade);
                            this.Substitui(oDoc, "@ruaEmpresa", cj.Rua);
                            this.Substitui(oDoc, "@numeroEmpresa", cj.NumeroEmpresa);
                            this.Substitui(oDoc, "@bairroEmpresa", cj.Bairro);
                            this.Substitui(oDoc, "@cepEmpresa", cj.Cep);
                            this.Substitui(oDoc, "@estadoJuridico", cj.Estado);
                            this.Substitui(oDoc, "@cnpj", cj.Cnpj);
                            this.Substitui(oDoc, "@nomeRepresentante", cf.Nome);
                            this.Substitui(oDoc, "@nacionalidade", cf.Nacionalidade);
                            this.Substitui(oDoc, "@estadoCivil", cf.EstadoCivil);
                            this.Substitui(oDoc, "@profissao", cf.Profissao);
                            this.Substitui(oDoc, "@rg", cf.Rg);
                            this.Substitui(oDoc, "@cpf", cf.Cpf);
                            this.Substitui(oDoc, "@ruaRepresentante", cf.Rua);
                            this.Substitui(oDoc, "@numeroCasa", cf.NumeroCasa);
                            this.Substitui(oDoc, "@bairroRepresentante", cf.Bairro);
                            this.Substitui(oDoc, "@cepRepresentante", cf.Cep);
                            this.Substitui(oDoc, "@cidadeRepresentante", cf.Cidade);
                            this.Substitui(oDoc, "@estadoRepresentante", cf.Estado);

                            this.Substitui(oDoc, "@dataEvento01", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@dataEvento02", c.EventoData.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino01", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino02", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino03", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico.ToString("HH:mm"));
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada.ToString("HH:mm"));
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto.ToString("dd/MM/yyyy"));
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora.ToString("HH:mm"));

                            aux = AnexoItem(0);
                            aux2 = AnexoItem(1);
                            aux3 = AnexoItem(2);
                            aux4 = AnexoItem(3);
                            aux5 = AnexoItem(4);
                            aux6 = AnexoItem(5);

                            this.Substitui(oDoc, "@pratosQuentesLista", aux);
                            this.Substitui(oDoc, "@saladasLista", aux2);
                            this.Substitui(oDoc, "@frutasLista", aux3);
                            this.Substitui(oDoc, "@friosLista", aux4);
                            this.Substitui(oDoc, "@bebidasLista", aux5);
                            this.Substitui(oDoc, "@servicoLista", aux6);
                            break;
                    }
                }

                if (cj == null)
                {
                    this.SalvarDocumento(oDoc, cf);
                }
                else
                {
                    this.SalvarDocumento(oDoc, cj);
                }

            }
            catch
            {
                MessageBox.Show("Aconteceu algum erro na criação do documento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                object naoSalvarAlteracoes = Word.WdSaveOptions.wdDoNotSaveChanges;
                oDoc.Close(ref naoSalvarAlteracoes, ref missing, ref missing);
                oApp.Quit();
            }
        }

        protected void Substitui(Word.Document oDoc, object parametro, object texto)
        {
            object missing = System.Reflection.Missing.Value;

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = parametro;
            object ReplaceWith = texto;
            object MatchWholeWord = true;
            object Forward = false;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
        }

        private void dgvPratosQuentes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecionada = 0;
        }

        private void dgvSaladas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecionada = 1;
        }

        private void dgvFrutas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecionada = 2;
        }

        private void dgvFrios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecionada = 3;
        }

        private void dgvBebidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecionada = 4;
        }

        private void dgvServicos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecionada = 5;
        }

        private void SalvarDocumento(Word.Document oDoc, object pessoa)
        {
            ContratoDAO cDAO = new ContratoDAO();
            object missing = System.Reflection.Missing.Value;
            string path = Directory.GetCurrentDirectory();
            object FileName = "";

            oDoc.ActiveWindow.Selection.WholeStory();
            oDoc.ActiveWindow.Selection.Copy();

            Word.Document oDoc2 = new Word.Document();
            oDoc2.ActiveWindow.Selection.WholeStory();
            oDoc2.ActiveWindow.Selection.Delete();
            oDoc2.ActiveWindow.Selection.Paste();
            
            if (pessoa is ClienteFisico)
            {
                FileName = (path + @"\DocumentosGerados\" + ((ClienteFisico)pessoa).Nome +"["+cDAO.FindID()+"]"+".doc");
            }
            else
            {
                FileName = (path + @"\DocumentosGerados\" + ((ClienteJuridico)pessoa).NomeEmpresa + "[" + cDAO.FindID() + "]" + ".doc");
            }
            object FileFormat = Word.WdSaveFormat.wdFormatDocument97;
            object LockComments = false;
            object AddToRecentFiles = true;
            object ReadOnlyRecommended = false;
            object EmbedTrueTypeFonts = false;
            object SaveNativePictureFormat = true;
            object SaveFormsData = true;
            object SaveAsAOCELetter = false;
            object Encoding = missing;
            object InsertLineBreaks = false;
            object AllowSubstitutions = true;
            object LineEnding = Word.WdLineEndingType.wdCRLF;
            object AddBiDiMarks = false;

            try
            {
                oDoc2.Application.ActiveDocument.SaveAs(ref FileName,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                MessageBox.Show("Documento salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("O documento não pode ser salvo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                oDoc2.Close();
            }
        }

        private string AnexoItem(int tipo)
        {
            string saida="";
            switch (tipo)
            {
                case 0:
                    foreach (DataGridViewRow i in dgvPratosQuentes.Rows)
                    {
                        saida = String.Format(saida + "\n" + i.Cells["ColumnNomePratosQuentes"].Value.ToString());
                    }
                    break;
                case 1:
                    foreach (DataGridViewRow i in dgvSaladas.Rows)
                    {
                        saida = String.Format(saida +"\n"+ i.Cells["ColumnNomeSaladas"].Value.ToString());
                    }
                    break;
                case 2:
                    foreach (DataGridViewRow i in dgvFrutas.Rows)
                    {
                        saida = String.Format(saida + "\n" + i.Cells["ColumnNomeFrutas"].Value.ToString());
                    }
                    break;
                case 3:
                    foreach (DataGridViewRow i in dgvFrios.Rows)
                    {
                        saida = String.Format(saida + "\n" + i.Cells["ColumnNomeFrios"].Value.ToString());
                    }
                    break;
                case 4:
                    foreach (DataGridViewRow i in dgvBebidas.Rows)
                    {
                        saida = String.Format(saida + "\n" + i.Cells["ColumnNomeBebidas"].Value.ToString());
                    }
                    break;
                case 5:
                    foreach (DataGridViewRow i in dgvServicos.Rows)
                    {
                        saida = String.Format(saida + "\n" + i.Cells["ColumnNomeServicos"].Value.ToString());
                    }
                    break;
            }
            Console.WriteLine(saida);
            return saida;
        }
    }
}
