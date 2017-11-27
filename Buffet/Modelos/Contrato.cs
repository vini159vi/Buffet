using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    public class Contrato
    {
        private DateTime eventoData, eventoHora, eventoTerminoHora, contratadoHoraChegada, contratadoInicioServico, contratadoTerminoServico, contratadoDataPgto, devolucaoHora, devolucaoDia, dataCriacao;
        private int id, eventoNConvidados, eventoCapMaxima, contratadoHoraAntecedencia, contratadoQuantGarcons, contratadoQuantCopeiros, tipo;
        private double contratadoPrecoPagar;

        ClienteFisico pessoaFisica = new ClienteFisico();
        ClienteJuridico pessoaJuridica = new ClienteJuridico();
        RepresentanteJuridico representante = new RepresentanteJuridico();

        public Contrato(DateTime eventoData, DateTime eventoHora, DateTime eventoTerminoHora, DateTime contratadoHoraChegada, DateTime contratadoInicioServico, DateTime contratadoTerminoServico, DateTime contratadoDataPgto, DateTime devolucaoHora, int id, int eventoNConvidados, int eventoCapMaxima, int contratadoHoraAntecedencia, int contratadoQuantGarcons, int contratadoQuantCopeiros, int tipo, double contratadoPrecoPagar, ClienteFisico pessoaFisica, ClienteJuridico pessoaJuridica, RepresentanteJuridico representante, DateTime devolucaoDia, DateTime dataCriacao)
        {
            this.EventoData = eventoData;
            this.EventoHora = eventoHora;
            this.EventoTerminoHora = eventoTerminoHora;
            this.ContratadoHoraChegada = contratadoHoraChegada;
            this.ContratadoInicioServico = contratadoInicioServico;
            this.ContratadoTerminoServico = contratadoTerminoServico;
            this.ContratadoDataPgto = contratadoDataPgto;
            this.DevolucaoHora = devolucaoHora;
            this.Id = id;
            this.EventoNConvidados = eventoNConvidados;
            this.EventoCapMaxima = eventoCapMaxima;
            this.ContratadoHoraAntecedencia = contratadoHoraAntecedencia;
            this.ContratadoQuantGarcons = contratadoQuantGarcons;
            this.ContratadoQuantCopeiros = contratadoQuantCopeiros;
            this.Tipo = tipo;
            this.ContratadoPrecoPagar = contratadoPrecoPagar;
            this.PessoaFisica = pessoaFisica;
            this.PessoaJuridica = pessoaJuridica;
            this.Representante = representante;
            this.DevolucaoDia = devolucaoDia;
            this.dataCriacao = dataCriacao;
        }

        public Contrato()
        {

        }
        public DateTime EventoData { get { return eventoData; } set { eventoData = value; } }
        public DateTime EventoHora { get { return eventoHora; } set { eventoHora = value; } }
        public DateTime EventoTerminoHora { get { return eventoTerminoHora; } set { eventoTerminoHora = value; } }
        public DateTime ContratadoHoraChegada { get { return contratadoHoraChegada; } set { contratadoHoraChegada = value; } }
        public DateTime ContratadoInicioServico { get { return contratadoInicioServico; } set { contratadoInicioServico = value; } }
        public DateTime ContratadoTerminoServico { get { return contratadoTerminoServico; }  set { contratadoTerminoServico = value; } }
        public DateTime ContratadoDataPgto { get { return contratadoDataPgto; } set { contratadoDataPgto = value; } }
        public DateTime DevolucaoHora { get { return devolucaoHora; } set { devolucaoHora = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int EventoNConvidados { get { return eventoNConvidados; } set { eventoNConvidados = value; } }
        public int EventoCapMaxima { get { return eventoCapMaxima; } set { eventoCapMaxima = value; } }
        public int ContratadoHoraAntecedencia { get { return contratadoHoraAntecedencia; } set { contratadoHoraAntecedencia = value; } }
        public int ContratadoQuantGarcons { get { return contratadoQuantGarcons; } set { contratadoQuantGarcons = value; } }
        public int ContratadoQuantCopeiros { get { return contratadoQuantCopeiros; } set { contratadoQuantCopeiros = value; } }
        public int Tipo { get { return tipo; } set { tipo = value; } }
        public double ContratadoPrecoPagar { get { return contratadoPrecoPagar; } set { contratadoPrecoPagar = value; } }
        public ClienteFisico PessoaFisica { get { return pessoaFisica; } set { pessoaFisica = value; } }
        public ClienteJuridico PessoaJuridica { get { return pessoaJuridica; } set { pessoaJuridica = value; } }
        public RepresentanteJuridico Representante { get { return representante; } set { representante = value; } }
        public DateTime DevolucaoDia { get { return devolucaoDia; } set { devolucaoDia = value; } }
        public DateTime DataCriacao { get { return dataCriacao; } set { dataCriacao = value; } }
    }
}
