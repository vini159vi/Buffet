using Buffet.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO
{
    class ContratoDAO
    {
        SQLiteConnection bd = Database.GetInstance().GetConnection();
        public void Create(Contrato c)
        {
            Database dbContrato = Database.GetInstance();
            string dataEvento = c.EventoData.ToString("yyyy-MM-dd");
            string horaEvento = c.EventoHora.ToString("HH:mm");
            string horaTerminoEvento = c.EventoTerminoHora.ToString("HH:mm");
            string horaChegada = c.ContratadoHoraChegada.ToString("HH:mm");
            string inicioServico = c.ContratadoInicioServico.ToString("HH:mm");
            string terminoServico = c.ContratadoTerminoServico.ToString("HH:mm");
            string dataPgto = c.ContratadoDataPgto.ToString("yyyy-MM-dd");
            string diaDevolucao = c.DevolucaoDia.ToString("yyyy-MM-dd");
            string horaDevolucao = c.DevolucaoHora.ToString("yyyy-MM-dd");
            string dataCriacao = c.DataCriacao.ToString("yyyy-MM-dd");

            string qry = string.Format("INSERT INTO Contrato(tipo, eventoData, eventoHora, eventoTerminoHora, eventoNConvidados, eventoCapMaxima," +
                "contratadoHoraChegada, contratadoHoraAntecedencia, contratadoInicioServico, contratadoTerminoServico, contratadoQuantGarcons, contratadoQuantCopeiros, contratadoPrecoPagar, contratadoDataPgto," +
                "devolucaoDia, devolucaoHora," +
                "pessoaFisicaCPF, pessoaJuridicaCNPJ, dataCriacao, notaFiscal, nomeAniversariante) " +

                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}','{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}')",
                c.Tipo, dataEvento, horaEvento, horaTerminoEvento, c.EventoNConvidados, c.EventoCapMaxima, horaChegada, c.ContratadoHoraAntecedencia, 
                inicioServico, terminoServico, c.ContratadoQuantGarcons, c.ContratadoQuantCopeiros, c.ContratadoPrecoPagar, dataPgto,
                diaDevolucao, horaDevolucao, c.PessoaFisica.Cpf, c.PessoaJuridica.Cnpj, dataCriacao, c.NotaFiscal, c.NomeAniversariante);

            dbContrato.ExecuteNonQuery(qry);
        }

        public Contrato Read(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE id=" + id;
            DataSet ds = bd.ExecuteQuery(qry);
            Contrato c = new Contrato();
            DataRow dr = ds.Tables[0].Rows[0];
            int aux;

            c.Id = int.Parse(dr["id"].ToString());
            c.Tipo = int.Parse(dr["tipo"].ToString());
            c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
            c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
            c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
            c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
            c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
            c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
            c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
            c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
            c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
            c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
            c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
            c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
            c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
            c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
            c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
            c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
            c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
            c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
            aux = int.Parse(dr["notaFiscal"].ToString());
            if (aux == 1)
            {
                c.NotaFiscal = 1;
            }
            else
            {
                c.NotaFiscal = 0;
            }
            c.NomeAniversariante = dr["nomeAniversariante"].ToString();
            return c;
        }

        public void Update(Contrato c, int id)
        {
            Database db = Database.GetInstance();
            string dataEvento = c.EventoData.ToString("yyyy-MM-dd");
            string horaEvento = c.EventoHora.ToString("HH:mm");
            string horaTerminoEvento = c.EventoTerminoHora.ToString("HH:mm");
            string horaChegada = c.ContratadoHoraChegada.ToString("HH:mm");
            string inicioServico = c.ContratadoInicioServico.ToString("HH:mm");
            string terminoServico = c.ContratadoTerminoServico.ToString("HH:mm");
            string dataPgto = c.ContratadoDataPgto.ToString("yyyy-MM-dd");
            string diaDevolucao = c.DevolucaoDia.ToString("yyyy-MM-dd");
            string horaDevolucao = c.DevolucaoHora.ToString("yyyy-MM-dd");
            string dataCriacao = c.DataCriacao.ToString("yyyy-MM-dd");

            string qry = string.Format("UPDATE Contrato SET tipo = '{0}', eventoData = '{1}', eventoHora = '{2}',  eventoTerminoHora = '{3}', eventoNConvidados= '{4}', eventoCapMaxima = '{5}', contratadoHoraChegada = '{6}', contratadoHoraAntecedencia = '{7}', contratadoInicioServico = '{8}', contratadoTerminoServico = '{9}', contratadoQuantGarcons = '{10}', contratadoQuantCopeiros = '{11}', contratadoPrecoPagar = '{12}', contratadoDataPgto = '{13}', devolucaoDia = '{14}', devolucaoHora = '{15}', pessoaFisicaCPF = '{16}', pessoaJuridicaCNPJ = '{17}', dataCriacao='{18}', notaFiscal = '{19}', nomeAniversariante = '{20}' "
            + " WHERE id = '{21}'",
            c.Tipo, dataEvento, horaEvento, horaTerminoEvento, c.EventoNConvidados, c.EventoCapMaxima, horaChegada, c.ContratadoHoraAntecedencia,
                inicioServico, terminoServico, c.ContratadoQuantGarcons, c.ContratadoQuantCopeiros, c.ContratadoPrecoPagar, dataPgto,
                diaDevolucao, horaDevolucao, c.PessoaFisica.Cpf, c.PessoaJuridica.Cnpj, dataCriacao, c.NotaFiscal, c.NomeAniversariante, id);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(int id)
        {
            Database db = Database.GetInstance();
            string qry = "DELETE FROM Contrato WHERE id =" + id;

            db.ExecuteNonQuery(qry);
        }

        public List<Contrato> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Contrato> contratos = new List<Contrato>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Contrato c = new Contrato();

                c.Id = int.Parse(dr["id"].ToString());
                c.Tipo = int.Parse(dr["tipo"].ToString());
                c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                aux = int.Parse(dr["notaFiscal"].ToString());
                if (aux == 1)
                {
                    c.NotaFiscal = 1;
                }
                else
                {
                    c.NotaFiscal = 0;
                }
                c.NomeAniversariante = dr["nomeAniversariante"].ToString();

                contratos.Add(c);
            }
            return contratos;
        }

        public List<Contrato> ListByID(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE id LIKE '%" + id + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Contrato> contratos = new List<Contrato>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                Contrato c = new Contrato();

                c.Id = int.Parse(dr["id"].ToString());
                c.Tipo = int.Parse(dr["tipo"].ToString());
                c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                aux = int.Parse(dr["notaFiscal"].ToString());
                if (aux == 1)
                {
                    c.NotaFiscal = 1;
                }
                else
                {
                    c.NotaFiscal = 0;
                }
                c.NomeAniversariante = dr["nomeAniversariante"].ToString();

                contratos.Add(c);

            }
            return contratos;
        }

        public List<Contrato> ListByFisico()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE pessoaJuridicaCNPJ=0";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Contrato> contratos = new List<Contrato>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                Contrato c = new Contrato();

                c.Id = int.Parse(dr["id"].ToString());
                c.Tipo = int.Parse(dr["tipo"].ToString());
                c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                aux = int.Parse(dr["notaFiscal"].ToString());
                if (aux == 1)
                {
                    c.NotaFiscal = 1;
                }
                else
                {
                    c.NotaFiscal = 0;
                }
                c.NomeAniversariante = dr["nomeAniversariante"].ToString();

                contratos.Add(c);

            }
            return contratos;
        }

        public List<Contrato> ListByIDFisico(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE pessoaJuridicaCNPJ=0 AND id="+id;
            DataSet ds = bd.ExecuteQuery(qry);
            List<Contrato> contratos = new List<Contrato>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                Contrato c = new Contrato();

                c.Id = int.Parse(dr["id"].ToString());
                c.Tipo = int.Parse(dr["tipo"].ToString());
                c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                aux = int.Parse(dr["notaFiscal"].ToString());
                if (aux == 1)
                {
                    c.NotaFiscal = 1;
                }
                else
                {
                    c.NotaFiscal = 0;
                }
                c.NomeAniversariante = dr["nomeAniversariante"].ToString();

                contratos.Add(c);

            }
            return contratos;
        }

        public List<Contrato> ListByJuridico()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE pessoaJuridicaCNPJ !=0";
            DataSet ds = bd.ExecuteQuery(qry);
            List<Contrato> contratos = new List<Contrato>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                Contrato c = new Contrato();

                c.Id = int.Parse(dr["id"].ToString());
                c.Tipo = int.Parse(dr["tipo"].ToString());
                c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                aux = int.Parse(dr["notaFiscal"].ToString());
                if (aux == 1)
                {
                    c.NotaFiscal = 1;
                }
                else
                {
                    c.NotaFiscal = 0;
                }
                c.NomeAniversariante = dr["nomeAniversariante"].ToString();

                contratos.Add(c);

            }
            return contratos;
        }

        public List<Contrato> ListByIDJuridico(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE pessoaJuridicaCNPJ !=0 AND id="+id;
            DataSet ds = bd.ExecuteQuery(qry);
            List<Contrato> contratos = new List<Contrato>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                Contrato c = new Contrato();

                c.Id = int.Parse(dr["id"].ToString());
                c.Tipo = int.Parse(dr["tipo"].ToString());
                c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                aux = int.Parse(dr["notaFiscal"].ToString());
                if (aux == 1)
                {
                    c.NotaFiscal = 1;
                }
                else
                {
                    c.NotaFiscal = 0;
                }
                c.NomeAniversariante = dr["nomeAniversariante"].ToString();

                contratos.Add(c);

            }
            return contratos;
        }

        public List<Contrato> ListByTipoContrato(int tipo)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE tipo="+tipo;
            DataSet ds = bd.ExecuteQuery(qry);
            List<Contrato> contratos = new List<Contrato>();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                Contrato c = new Contrato();

                c.Id = int.Parse(dr["id"].ToString());
                c.Tipo = int.Parse(dr["tipo"].ToString());
                c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                aux = int.Parse(dr["notaFiscal"].ToString());
                if (aux == 1)
                {
                    c.NotaFiscal = 1;
                }
                else
                {
                    c.NotaFiscal = 0;
                }
                c.NomeAniversariante = dr["nomeAniversariante"].ToString();
                contratos.Add(c);

            }
            return contratos;
        }

        public Contrato FindByID(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE id=" + id;
            DataSet ds = bd.ExecuteQuery(qry);
            Contrato c = new Contrato();
            int aux;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (int.Parse(dr["id"].ToString()) == id)
                {
                    c.Id = int.Parse(dr["id"].ToString());
                    c.Tipo = int.Parse(dr["tipo"].ToString());
                    c.EventoData = DateTime.Parse(dr["eventoData"].ToString());
                    c.EventoHora = DateTime.Parse(dr["eventoHora"].ToString());
                    c.EventoTerminoHora = DateTime.Parse(dr["eventoTerminoHora"].ToString());
                    c.EventoNConvidados = int.Parse(dr["eventoNConvidados"].ToString());
                    c.EventoCapMaxima = int.Parse(dr["eventoCapMaxima"].ToString());
                    c.ContratadoHoraChegada = DateTime.Parse(dr["contratadoHoraChegada"].ToString());
                    c.ContratadoHoraAntecedencia = int.Parse(dr["contratadoHoraAntecedencia"].ToString());
                    c.ContratadoInicioServico = DateTime.Parse(dr["contratadoInicioServico"].ToString());
                    c.ContratadoTerminoServico = DateTime.Parse(dr["contratadoTerminoServico"].ToString());
                    c.ContratadoQuantGarcons = int.Parse(dr["contratadoQuantGarcons"].ToString());
                    c.ContratadoQuantCopeiros = int.Parse(dr["contratadoQuantCopeiros"].ToString());
                    c.ContratadoPrecoPagar = double.Parse(dr["contratadoPrecoPagar"].ToString());
                    c.ContratadoDataPgto = DateTime.Parse(dr["contratadoDataPgto"].ToString());
                    c.DevolucaoDia = DateTime.Parse(dr["devolucaoDia"].ToString());
                    c.DevolucaoHora = DateTime.Parse(dr["devolucaoHora"].ToString());
                    c.PessoaFisica.Cpf = long.Parse(dr["pessoaFisicaCPF"].ToString());
                    c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                    c.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                    aux = int.Parse(dr["notaFiscal"].ToString());
                    if (aux == 1)
                    {
                        c.NotaFiscal = 1;
                    }
                    else
                    {
                        c.NotaFiscal = 0;
                    }
                    c.NomeAniversariante = dr["nomeAniversariante"].ToString();
                }
            }
            return c;
        }

        public ClienteFisico FindByFisico(long cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteFisico cf " +
                "JOIN Contrato c ON c.pessoaFisicaCPF=cf.cpf WHERE cf.cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);
            ClienteFisico cf = new ClienteFisico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cf.Nome = dr["nome"].ToString();
                cf.Nacionalidade = dr["nacionalidade"].ToString();
                cf.EstadoCivil = dr["estadoCivil"].ToString();
                cf.Profissao = dr["profissao"].ToString();
                cf.Cpf = long.Parse(dr["cpf"].ToString());
                cf.Rg = dr["rg"].ToString();
                cf.Telefone = long.Parse(dr["Telefone"].ToString());
                cf.Cep = long.Parse(dr["cep"].ToString());
                cf.Rua = dr["rua"].ToString();
                cf.Bairro = dr["bairro"].ToString();
                cf.Cidade = dr["cidade"].ToString();
                cf.Estado = dr["estado"].ToString();
                cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                cf.Celular = long.Parse(dr["celular"].ToString());
                cf.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;
                cf.Empresa.Cnpj = Int64.Parse(dr["cnpjEmpresa"].ToString());

            }
            return cf;

        }

        public ClienteJuridico FindByJuridico(long cnpj)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM ClienteJuridico cj " +
                "JOIN Contrato c ON c.pessoaJuridicaCNPJ=cj.cnpj WHERE cj.cnpj=" + cnpj;
            DataSet ds = bd.ExecuteQuery(qry);
            ClienteJuridico cj = new ClienteJuridico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cj.NomeEmpresa = dr["nomeEmpresa"].ToString();
                cj.Cnpj = long.Parse(dr["cnpj"].ToString());
                cj.Cep = long.Parse(dr["cep"].ToString());
                cj.Cidade = dr["cidade"].ToString();
                cj.Rua = dr["rua"].ToString();
                cj.Bairro = dr["bairro"].ToString();
                cj.Estado = dr["estado"].ToString();
                cj.NumeroEmpresa = int.Parse(dr["numeroEmpresa"].ToString());
                cj.DataCriacao = DateTime.Parse(dr["dataCriacao"].ToString()).Date;

            }
            return cj;

        }

    }
}
