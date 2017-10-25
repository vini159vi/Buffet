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

            string qry = string.Format("INSERT INTO Contrato(id, tipo, eventoData, eventoHora, eventoTerminoHora, eventoNConvidados, eventoCapMaxima," +
                "contratadoHoraChegada, contratadoHoraAntecedencia, contratadoInicioServico, contratadoTerminoServico, contratadoQuantGarcons, contratadoQuantCopeiros, contratadoPrecoPagar, contratadoDataPgto," +
                "devolucaoDia, devolucaoHora," +
                "pesssoaFisicaCPF, pessoaJuridicaCNPJ, representanteCPF) " +

                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}','{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}')",
                c.Id, c.Tipo, c.EventoData, c.EventoHora, c.EventoTerminoHora, c.EventoNConvidados, c.EventoCapMaxima, c.ContratadoHoraChegada, c.ContratadoHoraAntecedencia, 
                c.ContratadoInicioServico, c.ContratadoTerminoServico, c.ContratadoQuantGarcons, c.ContratadoQuantCopeiros, c.ContratadoPrecoPagar, c.ContratadoDataPgto,
                c.DevolucaoDia, c.DevolucaoHora, c.PessoaFisica.Cpf, c.PessoaJuridica.Cnpj, c.Representante.Cpf);

            dbContrato.ExecuteNonQuery(qry);
        }

        public Contrato Read(int id)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM Contrato WHERE id=" + id;
            DataSet ds = bd.ExecuteQuery(qry);
            Contrato c = new Contrato();
            DataRow dr = ds.Tables[0].Rows[0];

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
            c.PessoaFisica.Cpf = long.Parse(dr["pesssoaFisicaCPF"].ToString());
            c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
            c.Representante.Cpf = long.Parse(dr["representanteCPF"].ToString());

            return c;
        }

        public void Update(Contrato c, int id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE Contrato SET id='{0}', tipo = '{1}', eventoData = '{2}', eventoHora = '{3}',  eventoTerminoHora = '{4}', eventoNConvidados= '{5}', eventoCapMaxima = '{6}', contratadoHoraChegada = '{7}', contratadoHoraAntecedencia = '{8}', contratadoInicioServico = '{9}', contratadoTerminoServico = '{10}', contratadoQuantGarcons = '{11}', contratadoQuantCopeiros = '{12}', contratadoPrecoPagar = '{13}', contratadoDataPgto = '{14}', devolucaoDia = '{15}', devolucaoHora = '{16}', pesssoaFisicaCPF = '{17}', pessoaJuridicaCNPJ = '{18}', representanteCPF = '{19}'"
            + " WHERE id = '{20}'",
            c.Id, c.Tipo, c.EventoData, c.EventoHora, c.EventoTerminoHora, c.EventoNConvidados, c.EventoCapMaxima, c.ContratadoHoraChegada, c.ContratadoHoraAntecedencia,
                c.ContratadoInicioServico, c.ContratadoTerminoServico, c.ContratadoQuantGarcons, c.ContratadoQuantCopeiros, c.ContratadoPrecoPagar, c.ContratadoDataPgto,
                c.DevolucaoDia, c.DevolucaoHora, c.PessoaFisica.Cpf, c.PessoaJuridica.Cnpj, c.Representante.Cpf, id);

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
                c.PessoaFisica.Cpf = long.Parse(dr["pesssoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.Representante.Cpf = long.Parse(dr["representanteCPF"].ToString());

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
                c.PessoaFisica.Cpf = long.Parse(dr["pesssoaFisicaCPF"].ToString());
                c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                c.Representante.Cpf = long.Parse(dr["representanteCPF"].ToString());

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
                    c.PessoaFisica.Cpf = long.Parse(dr["pesssoaFisicaCPF"].ToString());
                    c.PessoaJuridica.Cnpj = long.Parse(dr["pessoaJuridicaCNPJ"].ToString());
                    c.Representante.Cpf = long.Parse(dr["representanteCPF"].ToString());
                }
            }
            return c;
        }

        public RepresentanteJuridico FindByRepresentante(long cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM RepresentanteJuridico rj " +
                "JOIN Contrato c ON c.representanteCPF=rj.cpf WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);
            RepresentanteJuridico rj = new RepresentanteJuridico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rj.Nome = dr["nome"].ToString();
                rj.Nacionalidade = dr["nacionalidade"].ToString();
                rj.EstadoCivil = dr["estadoCivil"].ToString();
                rj.Profissao = dr["profissao"].ToString();
                rj.Cpf = long.Parse(dr["cpf"].ToString());
                rj.Rg = long.Parse(dr["rg"].ToString());
                rj.Telefone = long.Parse(dr["Telefone"].ToString());
                rj.Cep = long.Parse(dr["cep"].ToString());
                rj.Rua = dr["rua"].ToString();
                rj.Bairro = dr["bairro"].ToString();
                rj.Cidade = dr["cidade"].ToString();
                rj.Estado = dr["estado"].ToString();
                rj.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                rj.Celular = long.Parse(dr["celular"].ToString());
                rj.Empresa.Cnpj = long.Parse(dr["empresaCnpj"].ToString());

            }
            return rj;

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
                cf.Rg = long.Parse(dr["rg"].ToString());
                cf.Telefone = long.Parse(dr["Telefone"].ToString());
                cf.Cep = long.Parse(dr["cep"].ToString());
                cf.Rua = dr["rua"].ToString();
                cf.Bairro = dr["bairro"].ToString();
                cf.Cidade = dr["cidade"].ToString();
                cf.Estado = dr["estado"].ToString();
                cf.NumeroCasa = int.Parse(dr["numeroCasa"].ToString());
                cf.Celular = long.Parse(dr["celular"].ToString());
                cf.Tipo = int.Parse(dr["tipo"].ToString());

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
                cj.Tipo = int.Parse(dr["tipo"].ToString());

            }
            return cj;

        }

    }
}
