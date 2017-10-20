using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.MISC
{
    class TabelasDB
    {
        public override string ToString()
        {

            return "CREATE TABLE Cliente(" +
                   "nome VARCHAR(64) NOT NULL," +
                   "endereco VARCHAR(64)," +
                   "cpf BIGINT NOT NULL," +
                   "telefone BIGINT," +
                   "dataNasc DATE," +
                   "celular BIGINT," +
                   "numeroCasa INT," +

                   "PRIMARY KEY(cpf));" +

                   "CREATE TABLE ClienteFisico(" +
                      "nome VARCHAR(64) NOT NULL," +
                      "nacionalidade VARCHAR(64) DEFAULT 'Brasileiro'," +
                      "estadoCivil VARCHAR(32)," +
                      "profissao VARCHAR(64) DEFAULT 'Desempregado'," +
                      "cpf BIGINT NOT NULL," +
                      "rg BIGINT," +
                      "telefone BIGINT," +
                      "cep BIGINT," +
                      "rua VARCHAR(64)," +
                      "bairro VARCHAR(64)," +
                      "cidade VARCHAR(64)," +
                      "estado VARCHAR(64)," +
                      "numeroCasa INT," +
                      "celular BIGINT," +
                      "tipo INT," +

                      "PRIMARY KEY(cpf));" +

                    "CREATE TABLE RepresentanteJuridico(" +
                      "nome VARCHAR(64) NOT NULL," +
                      "nacionalidade VARCHAR(64) DEFAULT 'Brasileiro'," +
                      "estadoCivil VARCHAR(32)," +
                      "profissao VARCHAR(64) DEFAULT 'Desempregado'," +
                      "cpf BIGINT NOT NULL," +
                      "rg BIGINT," +
                      "telefone BIGINT," +
                      "cep BIGINT," +
                      "rua VARCHAR(64)," +
                      "bairro VARCHAR(64)," +
                      "cidade VARCHAR(64)," +
                      "estado VARCHAR(64)," +
                      "numeroCasa INT," +
                      "celular BIGINT," +
                      "tipo INT," +
                      "empresaCnpj BIGINT," +
                      "PRIMARY KEY(cpf)," +
                      "FOREIGN KEY(empresaCnpj) REFERENCES ClienteJuridico(cnpj)" +
                      ");" +

                    "CREATE TABLE ClienteJuridico(" +
                      "nomeEmpresa VARCHAR(64)," +
                      "cnpj BIGINT NOT NULL," +
                      "cep BIGINT," +
                      "cidade VARCHAR(64)," +
                      "rua VARCHAR(64)," +
                      "bairro VARCHAR(64)," +
                      "estado VARCHAR(64)," +
                      "numeroEmpresa INTEGER," +
                      "tipo INT," +

                      "PRIMARY KEY(cnpj));";
        }
    }
}
