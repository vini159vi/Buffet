using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Buffet.CV
{
    public partial class FormTemporario : Form
    {
        public FormTemporario()
        {
            InitializeComponent();
            CriarDocumento();
        }

        public void CriarDocumento()
        {
            object missing = System.Reflection.Missing.Value;

            Word.Application oApp = new Word.Application();
            object template = Path.GetDirectoryName(@"C:\Novapasta\ContratoJuridicoEmpresa.doc");
            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            this.Substitui(oDoc, "@nomeEmpresa", "William");
            this.Substitui(oDoc, "@cidadeEmpresa", "Crudeli");
            this.Substitui(oDoc, "@ruaEmpresa", "40 e alguma coisa");

            this.SalvarDocumento(oDoc);
        }

        protected void Substitui(Word.Document oDoc, object parametro, object texto)
        {
            object missing = System.Reflection.Missing.Value;

            //Troca o conteúdo de alguns tags
            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = parametro;
            object ReplaceWith = texto;
            object MatchWholeWord = true;
            object Forward = false;

            oRng.Find.Execute(ref FindText, ref missing, ref MatchWholeWord, ref missing, ref missing, ref missing, ref Forward,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing, ref missing, ref missing, ref missing);
        }
        private void SalvarDocumento(Word.Document oDoc)
        {
            object missing = System.Reflection.Missing.Value;

            object FileName = Path.GetDirectoryName(@"C:\Users\Lellis\DesktopTeste3.doc");
            object FileFormat = Word.WdSaveFormat.wdFormatDocument;
            object LockComments = false;
            object AddToRecentFiles = true;
            object ReadOnlyRecommended = false;
            object EmbedTrueTypeFonts = false;
            object SaveNativePictureFormat = true;
            object SaveFormsData = true;
            object SaveAsAOCELetter = false;
            object Encoding = missing;
            object InsertLineBreaks = false;
            object AllowSubstitutions = true;
            object LineEnding = Word.WdLineEndingType.wdCRLF;
            object AddBiDiMarks = false;

        }    
    }
}
