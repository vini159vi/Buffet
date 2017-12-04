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
                    //Tabelas
            return "CREATE TABLE ClienteFisico( `nome` VARCHAR(64) NOT NULL, `nacionalidade` VARCHAR(64) DEFAULT 'Brasileiro', `estadoCivil` VARCHAR(32), `profissao` VARCHAR(64) DEFAULT 'Desempregado', `cpf` BIGINT NOT NULL, `rg` BIGINT, `telefone` BIGINT, `cep` BIGINT, `rua` VARCHAR(64), `bairro` VARCHAR(64), `cidade` VARCHAR(64), `estado` VARCHAR(64), `numeroCasa` INT, `celular` BIGINT, `dataCriacao` DATE, `cnpjEmpresa` BIGINT DEFAULT NULL, FOREIGN KEY(`cnpjEmpresa`) REFERENCES `ClienteJuridico`(`cnpj`), PRIMARY KEY(`cpf`) );" +
                    "CREATE TABLE ClienteFisicoHistorico( `nome` VARCHAR(64) NOT NULL, `nacionalidade` VARCHAR(64) DEFAULT 'Brasileiro', `estadoCivil` VARCHAR(32), `profissao` VARCHAR(64) DEFAULT 'Desempregado', `cpf` BIGINT NOT NULL, `rg` BIGINT, `telefone` BIGINT, `cep` BIGINT, `rua` VARCHAR(64), `bairro` VARCHAR(64), `cidade` VARCHAR(64), `estado` VARCHAR(64), `numeroCasa` INT, `celular` BIGINT, `dataCriacao` DATE, `cnpjEmpresa` BIGINT DEFAULT NULL, PRIMARY KEY(`cpf`), FOREIGN KEY(`cnpjEmpresa`) REFERENCES `ClienteJuridicoHistorico`(`cnpj`) );" +
                    "CREATE TABLE ClienteJuridico( `nomeEmpresa` VARCHAR(64), `cnpj` BIGINT NOT NULL, `cep` BIGINT, `cidade` VARCHAR(64), `rua` VARCHAR(64), `bairro` VARCHAR(64), `estado` VARCHAR(64), `numeroEmpresa` INTEGER, `dataCriacao` DATE, PRIMARY KEY(`cnpj`));" +
                    "CREATE TABLE ClienteJuridicoHistorico( `nomeEmpresa` VARCHAR(64), `cnpj` BIGINT NOT NULL, `cep` BIGINT, `cidade` VARCHAR(64), `rua` VARCHAR(64), `bairro` VARCHAR(64), `estado` VARCHAR(64), `numeroEmpresa` INTEGER, `dataCriacao` DATE, PRIMARY KEY(`cnpj`));" +
                    "CREATE TABLE Agenda ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `nome` VARCHAR(64), `data` DATE, `telefone` BIGINT, `ativo` INTEGER );" +
                    "CREATE TABLE Item ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `nome` VARCHAR(64), `valorPessoa` REAL, `tipo` INTEGER )" +
                    "CREATE TABLE Cardapio ( `id` INTEGER, `totalValor` REAL, PRIMARY KEY(`id`) );" +
                    "CREATE TABLE Contrato( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `tipo` INTEGER, `eventoData` DATE, 'nomeAniversariante' VARCHAR(64), `eventoHora` TIME, `eventoTerminoHora` TIME, `eventoNConvidados` INTEGER, `eventoCapMaxima` INTEGER, `contratadoHoraChegada` TIME, `contratadoHoraAntecedencia` INTEGER, `contratadoInicioServico` TIME, `contratadoTerminoServico` TIME, `contratadoQuantGarcons` INTEGER, `contratadoQuantCopeiros` INTEGER, `contratadoPrecoPagar` DOUBLE(8, 2), `contratadoDataPgto` DATE, `devolucaoDia` DATE, `devolucaoHora` TIME, `pessoaFisicaCPF` BIGINT, `pessoaJuridicaCNPJ` BIGINT, `dataCriacao` DATE, `notaFiscal` INTEGER, FOREIGN KEY(`pessoaJuridicaCNPJ`) REFERENCES `ClienteJuridico`(`cnpj`), FOREIGN KEY(`pessoaFisicaCPF`) REFERENCES `ClienteFisico`(`cpf`) );" +
                    "CREATE TABLE ContratoHistorico( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `tipo` INTEGER, `eventoData` DATE, 'nomeAniversariante' VARCHAR(64), `eventoHora` TIME, `eventoTerminoHora` TIME, `eventoNConvidados` INTEGER, `eventoCapMaxima` INTEGER, `contratadoHoraChegada` TIME, `contratadoHoraAntecedencia` INTEGER, `contratadoInicioServico` TIME, `contratadoTerminoServico` TIME, `contratadoQuantGarcons` INTEGER, `contratadoQuantCopeiros` INTEGER, `contratadoPrecoPagar` DOUBLE ( 8 , 2 ), `contratadoDataPgto` DATE, `devolucaoDia` DATE, `devolucaoHora` TIME, `pessoaFisicaCPF` BIGINT, `pessoaJuridicaCNPJ` BIGINT, `dataCriacao` DATE, `notaFiscal` INTEGER, FOREIGN KEY(`pessoaFisicaCPF`) REFERENCES `ClienteFisicoHistorico`(`cpf`), FOREIGN KEY(`pessoaJuridicaCNPJ`) REFERENCES `ClienteJuridicoHistorico`(`cnpj`) );" +
                    "CREATE TABLE ItemDoCardapio ( `idItem` INTEGER, `idCardapio` INTEGER, FOREIGN KEY(`idItem`) REFERENCES `Item`(`id`), FOREIGN KEY(`idCardapio`) REFERENCES `Cardapio`(`id`) ); "+

                    //Triggers
                    //Fisico
                    "CREATE TRIGGER t_FisicoHistorico_insert AFTER INSERT ON ClienteFisico " +
                    "BEGIN "+
                        "INSERT INTO ClienteFisicoHistorico(nome, nacionalidade, estadoCivil, profissao, cpf, rg, telefone, cep, rua, bairro,"+
                        "cidade, estado, numeroCasa, celular, dataCriacao, cnpjEmpresa) VALUES(NEW.nome, NEW.nacionalidade, NEW.estadoCivil, NEW.profissao, NEW.cpf, NEW.rg, NEW.telefone, NEW.cep, NEW.rua, NEW.bairro,"+
                        "NEW.cidade, NEW.estado, NEW.numeroCasa, NEW.celular, NEW.dataCriacao, NEW.cnpjEmpresa);"+
                    "END; "+

                    "CREATE TRIGGER t_FisicoHistorico_update after UPDATE ON ClienteFisico "+
                    "BEGIN "+
                        "UPDATE ClienteFisicoHistorico SET nome = new.nome, nacionalidade = new.nacionalidade, estadoCivil = new.estadoCivil, profissao = new.profissao, cpf = new.cpf, rg = new.rg, telefone = new.telefone, cep = new.cep, rua = new.rua, bairro = new.bairro, cidade = new.cidade, estado = new.estado, numeroCasa = new.numeroCasa, celular = new.celular, dataCriacao = new.dataCriacao, cnpjEmpresa = new.cnpjEmpresa "+
                        "WHERE cpf = OLD.cpf; "+
                    "END; "+


                    "CREATE TRIGGER t_JuridicoHistorico_insert AFTER INSERT ON ClienteJuridico " +
                    "BEGIN "+
                        "INSERT INTO ClienteJuridicoHistorico(nomeEmpresa, cnpj, cep, cidade, rua, bairro, estado, numeroEmpresa, dataCriacao)"+
                        "VALUES(NEW.nomeEmpresa, NEW.cnpj, NEW.cep, NEW.cidade, NEW.rua, NEW.bairro, NEW.estado, NEW.numeroEmpresa, NEW.dataCriacao); "+
                    "END; "+

                    "CREATE TRIGGER t_JuridicoHistorico_update AFTER UPDATE ON ClienteJuridico "+
                    "BEGIN "+
                        "UPDATE ClienteJuridicoHistorico SET nomeEmpresa = NEW.nomeEmpresa, cnpj = NEW.cnpj, cep = NEW.cep, cidade = NEW.cidade, rua = NEW.rua, bairro = NEW.bairro, estado = NEW.estado, numeroEmpresa = NEW.numeroEmpresa, dataCriacao = NEW.dataCriacao "+
                    "WHERE cnpj = OLD.cnpj;"+
                    "END; "


            ;
        }
    }
}
