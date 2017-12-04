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

        }

        private void bttRemover_Click(object sender, EventArgs e)
        {

        }

        private void bttGerarContrato_Click(object sender, EventArgs e)
        {
            ContratoDAO cDAO = new ContratoDAO();

            cDAO.Create(c);
            if (cj == null)
            {
                CriarDocumento(c, cf, null, contrato, ValorCabeca(c.EventoNConvidados));
            }
            else
            {
                CriarDocumento(c, cf, cj, contrato, ValorCabeca(c.EventoNConvidados));
            }


        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {

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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);


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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                            this.Substitui(oDoc, "@dataEvento2", c.EventoData);
                            this.Substitui(oDoc, "@horasEvento", c.EventoHora);
                            this.Substitui(oDoc, "@numeroConvidados", c.EventoNConvidados);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@capMaxima", c.EventoCapMaxima);
                            this.Substitui(oDoc, "@festaInicio", c.ContratadoInicioServico);
                            this.Substitui(oDoc, "@festaTermino", c.EventoTerminoHora);
                            this.Substitui(oDoc, "@horaChegada", c.ContratadoHoraChegada);
                            this.Substitui(oDoc, "@horaAntecedencia", c.ContratadoHoraAntecedencia);
                            this.Substitui(oDoc, "@quantGarcons", c.ContratadoQuantGarcons);
                            this.Substitui(oDoc, "@quantCopeiros", c.ContratadoQuantCopeiros);
                            this.Substitui(oDoc, "@valorCabeca", ValorCabeca);
                            this.Substitui(oDoc, "@dataPagamento", c.ContratadoDataPgto);
                            this.Substitui(oDoc, "@dataEvento ", c.EventoData);
                            this.Substitui(oDoc, "@festaTermino ", c.EventoTerminoHora);
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

                MessageBox.Show("Documento salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
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
}
}
