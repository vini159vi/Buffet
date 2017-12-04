using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Modelos
{
    class GerarContrato
    {
        private DateTime eventoData, eventoHora, eventoTerminoHora, contratadoHoraChegada, contratadoInicioServico, contratadoTerminoServico, contratadoDataPgto, devolucaoHora, devolucaoDia, dataCriacao;
        private int id, eventoNConvidados, eventoCapMaxima, contratadoHoraAntecedencia, contratadoQuantGarcons, contratadoQuantCopeiros;
        private int tipo;
        private double contratadoPrecoPagar;
        private int notaFiscal;
        private string nomeAniversariante;

        private string fisicoNome, fisicoNacionalidade, fisicoEstadoCivil, fisicoProfissao, fisicoRua, fisicoBairro, fisicoCidade, fisicoEstado, fisicoRg;
        private long fisicoCpf, fisicoCep, fisicoTelefone, fisicoCelular;
        private int fisicoNumeroCasa;

        private string juridicoNome, juridicoCidade, juridicoRua, juridicoBairro, juridicoEstado;
        private long juridicoCep, juridicoCnpj;
        private int juridicoNumeroEmpresa;

        private List<Item> pratosQuentes = new List<Item>();
        private List<Item> saladas = new List<Item>();
        private List<Item> frutas = new List<Item>();
        private List<Item> frios = new List<Item>();
        private List<Item> bebidas = new List<Item>();
        private List<Item> serviços = new List<Item>();

    }
}
