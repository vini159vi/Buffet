using Buffet.DAO;
using Buffet.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace Buffet.CV
{
    
public partial class FormContratoGerado : Form
    {
        public FormContratoGerado()
        {
            InitializeComponent();
        }

        public FormContratoGerado(Contrato c, long cpf, long cnpj, int tipoPessoa, int contrato)
        {
            InitializeComponent();
            ClienteFisicoDAO cfDAO = new ClienteFisicoDAO();
            ClienteJuridicoDAO cjDAO = new ClienteJuridicoDAO();
            ClienteFisico cf = cfDAO.FindByCPF(cpf);
            if (cnpj != null)
            {
                ClienteJuridico cj = cjDAO.FindByCNPJ(cnpj);
            }
        }

        public void CriarDocumento()
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;
            var wordDoc = wordApp.Documents.Add();

            var paragrafo1 = wordDoc.Content.Paragraphs.Add();
            paragrafo1.Range.Text = "Buffet";
            paragrafo1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            paragrafo1.Range.InsertParagraphAfter();


        }

    }
}