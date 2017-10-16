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
    class RepresentanteDAO
    {
        SQLiteConnection bd = Database.GetInstance().GetConnection();
        public void Create(RepresentanteJuridico rj)
        {
            Database dbCliente = Database.GetInstance();

            string qry = string.Format("INSERT INTO RepresentanteJuridico(nome, nacionalidade, estadoCivil, profissao, cpf, rg, telefone, cep, rua, bairro, cidade, estado, numeroCasa, celular, empresaCnpj) VALUES("
               + "@Nome,@Nacionalidade,@EstadoCivil,@Profissao,@CPF,@RG,@Telefone,@CEP,@Rua,@Bairro,@Cidade,@Estado,@NumeroCasa,@Celular,@EmpresaCNPJ)");

            SQLiteCommand comm = new SQLiteCommand(qry, bd);

            comm.Parameters.AddWithValue("@Nome", rj.Nome);
            comm.Parameters.AddWithValue("@Nacionalidade", rj.Nacionalidade);
            comm.Parameters.AddWithValue("@EstadoCivil", rj.EstadoCivil);
            comm.Parameters.AddWithValue("@Profissao", rj.Profissao);
            comm.Parameters.AddWithValue("@CPF", rj.Cpf);
            comm.Parameters.AddWithValue("@RG", rj.Rg);
            comm.Parameters.AddWithValue("@Telefone", rj.Telefone);
            comm.Parameters.AddWithValue("@CEP", rj.Cep);
            comm.Parameters.AddWithValue("@Rua", rj.Rua);
            comm.Parameters.AddWithValue("@Bairro", rj.Bairro);
            comm.Parameters.AddWithValue("@Cidade", rj.Cidade);
            comm.Parameters.AddWithValue("@Estado", rj.Estado);
            comm.Parameters.AddWithValue("@NumeroCasa", rj.NumeroCasa);
            comm.Parameters.AddWithValue("@Celular", rj.Celular);
            comm.Parameters.AddWithValue("@EmpresaCNPJ", rj.Empresa.Cnpj);

            dbCliente.ExecuteNonQuery(qry);
        }

        public RepresentanteJuridico Read(string cpf)
        {
            RepresentanteJuridico rj = new RepresentanteJuridico();
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM RepresentanteJuridico WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);

            DataRow dr = ds.Tables[0].Rows[0];

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

            return rj;
        }

        public void Update(RepresentanteJuridico rj)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("UPDATE RepresentanteJuridico SET nome=@Nome, nacionalidade=@Nacionalidade, estadoCivil=@EstadoCivil, profissao=@Profissao, cpf=@CPF, rg=@RG, telefone=@Telefone, cep=@CEP, rua=@Rua, bairro=@Bairro, cidade=@Cidade, estado=@Estado, numeroCasa=@NumeroCasa, celular=@Celular, empresaCnpj=@EmpresaCNPJ"
            + " WHERE cpf = @CPF");
            SQLiteCommand comm = new SQLiteCommand(qry, bd);

            comm.Parameters.AddWithValue("@Nome", rj.Nome);
            comm.Parameters.AddWithValue("@Nacionalidade", rj.Nacionalidade);
            comm.Parameters.AddWithValue("@EstadoCivil", rj.EstadoCivil);
            comm.Parameters.AddWithValue("@Profissao", rj.Profissao);
            comm.Parameters.AddWithValue("@CPF", rj.Cpf);
            comm.Parameters.AddWithValue("@RG", rj.Rg);
            comm.Parameters.AddWithValue("@Telefone", rj.Telefone);
            comm.Parameters.AddWithValue("@CEP", rj.Cep);
            comm.Parameters.AddWithValue("@Rua", rj.Rua);
            comm.Parameters.AddWithValue("@Bairro", rj.Bairro);
            comm.Parameters.AddWithValue("@Cidade", rj.Cidade);
            comm.Parameters.AddWithValue("@Estado", rj.Estado);
            comm.Parameters.AddWithValue("@NumeroCasa", rj.NumeroCasa);
            comm.Parameters.AddWithValue("@Celular", rj.Celular);
            comm.Parameters.AddWithValue("@EmpresaCNPJ", rj.Empresa.Cnpj);

            db.ExecuteNonQuery(qry);
        }

        public void Delete(long cpf)
        {
            Database db = Database.GetInstance();
            string qry = "DELETE FROM RepresentanteJuridico WHERE cpf =" + cpf;

            db.ExecuteNonQuery(qry);
        }

        public List<RepresentanteJuridico> List()
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM RepresentanteJuridico";
            DataSet ds = bd.ExecuteQuery(qry);
            List <RepresentanteJuridico> representantes = new List<RepresentanteJuridico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                RepresentanteJuridico rj = new RepresentanteJuridico();


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

                representantes.Add(rj);
            }
            return representantes;
        }

        public List<RepresentanteJuridico> ListByCPF(long cpf)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM RepresentanteJuridico WHERE cpf=" + cpf;
            DataSet ds = bd.ExecuteQuery(qry);
            List<RepresentanteJuridico> representantes = new List<RepresentanteJuridico>();
            RepresentanteJuridico rj = new RepresentanteJuridico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (long.Parse(dr["cpf"].ToString()) == cpf)
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
            }
            representantes.Add(rj);
            return representantes;
        }

        public List<RepresentanteJuridico> ListByName(string nome)
        {
            Database bd = Database.GetInstance();
            string qry = "SELECT * FROM RepresentanteJuridico WHERE nome LIKE '%" + nome + "%'";
            DataSet ds = bd.ExecuteQuery(qry);
            List<RepresentanteJuridico> representantes = new List<RepresentanteJuridico>();
            RepresentanteJuridico rj = new RepresentanteJuridico();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr["nome"].ToString() == nome)
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
                    rj.Empresa.Cnpj = long.Parse(dr["empresaCnpj"].ToString()); ;
                }
            }
            representantes.Add(rj);
            return representantes;
        }
    }
}
