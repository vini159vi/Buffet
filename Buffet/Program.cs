using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Buffet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCadastrados());
        }
    }
}

/*Banco de dados
 
CREATE TABLE Cliente(
  nome VARCHAR(64) NOT NULL,
  endereco VARCHAR(64),
  cpf BIGINT NOT NULL,
  telefone BIGINT,
  dataNasc DATE,
  celular BIGINT,
  numeroCasa INT,

  PRIMARY KEY(cpf)
);

CREATE TABLE ClienteFisico(
  nome VARCHAR(64) NOT NULL,
  cpf BIGINT NOT NULL,
  rg BIGINT,
  telefone BIGINT,
  celular BIGINT,
  dataNasc DATE,
  endereco VARCHAR(64),
  bairro VARCHAR(64),
  numeroCasa INT,

  PRIMARY KEY(cpf)
);
/
CREATE TABLE ClienteJuridico(
  nomeEmpresa VARCHAR(64),
  cnpj BIGINT NOT NULL,
  cep BIGINT,
  cidade VARCHAR(64),
  rua VARCHAR(64),
  bairro VARCHAR(64),
  estado VARCHAR(64),
  numeroEmpresa INTEGER,
  representanteCPF BIGINT,

  PRIMARY KEY(cnpj),
  FOREIGN KEY (representanteCPF) REFERENCES RepresentanteJuridico
);
/
CREATE TABLE RepresentanteJuridico(
  nome VARCHAR(64) NOT NULL,
  nacionalidade VARCHAR(64) DEFAULT 'Brasileiro',
  estadoCivil VARCHAR(32),
  profissao VARCHAR(64) DEFAULT 'Desempregado',
  cpf BIGINT NOT NULL,
  rg BIGINT,
  telefone BIGINT,
  cep BIGINT,
  endereco VARCHAR(64),
  bairro VARCHAR(64),
  cidade VARCHAR(64),
  estado VARCHAR(64),
  numeroCasa INT,

  PRIMARY KEY (cpf)
);
/

     */
