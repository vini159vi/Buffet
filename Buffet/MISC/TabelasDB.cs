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

            return "CREATE TABLE ClienteFisico( `nome` VARCHAR(64) NOT NULL, `nacionalidade` VARCHAR(64) DEFAULT 'Brasileiro', `estadoCivil` VARCHAR(32), `profissao` VARCHAR(64) DEFAULT 'Desempregado', `cpf` BIGINT NOT NULL, `rg` BIGINT, `telefone` BIGINT, `cep` BIGINT, `rua` VARCHAR(64), `bairro` VARCHAR(64), `cidade` VARCHAR(64), `estado` VARCHAR(64), `numeroCasa` INT, `celular` BIGINT, `dataCriacao` DATE, `cnpjEmpresa` BIGINT DEFAULT NULL, FOREIGN KEY(`cnpjEmpresa`) REFERENCES `ClienteJuridico`(`cnpj`), PRIMARY KEY(`cpf`) );" +
                    "CREATE TABLE ClienteFisicoHistorico( `nome` VARCHAR(64) NOT NULL, `nacionalidade` VARCHAR(64) DEFAULT 'Brasileiro', `estadoCivil` VARCHAR(32), `profissao` VARCHAR(64) DEFAULT 'Desempregado', `cpf` BIGINT NOT NULL, `rg` BIGINT, `telefone` BIGINT, `cep` BIGINT, `rua` VARCHAR(64), `bairro` VARCHAR(64), `cidade` VARCHAR(64), `estado` VARCHAR(64), `numeroCasa` INT, `celular` BIGINT, `dataCriacao` DATE, `cnpjEmpresa` BIGINT DEFAULT NULL, PRIMARY KEY(`cpf`), FOREIGN KEY(`cnpjEmpresa`) REFERENCES `ClienteJuridicoHistorico`(`cnpj`) );" +
                    "CREATE TABLE ClienteJuridico( `nomeEmpresa` VARCHAR(64), `cnpj` BIGINT NULL, `cep` BIGINT, `cidade` VARCHAR(64), `rua` VARCHAR(64), `bairro` VARCHAR(64), `estado` VARCHAR(64), `numeroEmpresa` INTEGER, `dataCriacao` DATE, PRIMARY KEY(`cnpj`));" +
                    "CREATE TABLE ClienteJuridicoHistorico( `nomeEmpresa` VARCHAR(64), `cnpj` BIGINT NULL, `cep` BIGINT, `cidade` VARCHAR(64), `rua` VARCHAR(64), `bairro` VARCHAR(64), `estado` VARCHAR(64), `numeroEmpresa` INTEGER, `dataCriacao` DATE, PRIMARY KEY(`cnpj`));" +
                    "CREATE TABLE Agenda ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `nome` VARCHAR(64), `data` DATE, `telefone` BIGINT, `ativo` INTEGER );" +
                    "CREATE TABLE Cardapio ( id INTEGER PRIMARY KEY AUTOINCREMENT, totalValor REAL NOT NULL );" +
                    "CREATE TABLE Contrato( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `tipo` INTEGER, `eventoData` DATE, `eventoHora` TIME, `eventoTerminoHora` TIME, `eventoNConvidados` INTEGER, `eventoCapMaxima` INTEGER, `contratadoHoraChegada` TIME, `contratadoHoraAntecedencia` INTEGER, `contratadoInicioServico` TIME, `contratadoTerminoServico` TIME, `contratadoQuantGarcons` INTEGER, `contratadoQuantCopeiros` INTEGER, `contratadoPrecoPagar` DOUBLE(8, 2), `contratadoDataPgto` DATE, `devolucaoDia` DATE, `devolucaoHora` TIME, `pessoaFisicaCPF` BIGINT, `pessoaJuridicaCNPJ` BIGINT, `dataCriacao` DATE, `notaFiscal` INTEGER DEFAULT 0, FOREIGN KEY(`pessoaJuridicaCNPJ`) REFERENCES `ClienteJuridico`(`cnpj`), FOREIGN KEY(`pessoaFisicaCPF`) REFERENCES `ClienteFisico`(`cpf`) );" +
                    "CREATE TABLE ContratoHistorico( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `tipo` INTEGER, `eventoData` DATE, `eventoHora` TIME, `eventoTerminoHora` TIME, `eventoNConvidados` INTEGER, `eventoCapMaxima` INTEGER, `contratadoHoraChegada` TIME, `contratadoHoraAntecedencia` INTEGER, `contratadoInicioServico` TIME, `contratadoTerminoServico` TIME, `contratadoQuantGarcons` INTEGER, `contratadoQuantCopeiros` INTEGER, `contratadoPrecoPagar` DOUBLE ( 8 , 2 ), `contratadoDataPgto` DATE, `devolucaoDia` DATE, `devolucaoHora` TIME, `pessoaFisicaCPF` BIGINT, `pessoaJuridicaCNPJ` BIGINT, `dataCriacao` DATE, `notaFiscal` INTEGER DEFAULT 0, FOREIGN KEY(`pessoaFisicaCPF`) REFERENCES `ClienteFisicoHistorico`(`cpf`), FOREIGN KEY(`pessoaJuridicaCNPJ`) REFERENCES `ClienteJuridicoHistorico`(`cnpj`) );" +
                    "CREATE TABLE ItemDoCardapio ( `idItem` INTEGER, `idCardapio` INTEGER, FOREIGN KEY(`idItem`) REFERENCES `Item`(`id`), FOREIGN KEY(`idCardapio`) REFERENCES `Cardapio`(`id`) );";
                    ;
        }
    }
}
