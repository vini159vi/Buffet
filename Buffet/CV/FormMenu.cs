using Buffet.CV;
using System;
using System.Windows.Forms;

namespace Buffet
{
    public partial class FormMenu : Form
    {
        //Telas que se abrirão atraves do menu
        private FormJuridico fj = new FormJuridico();
        private FormCadastrados fc = new FormCadastrados();
        private FormRepresentante fr = new FormRepresentante();
        private FormFisico ff = new FormFisico();
        private FormContratoFísico fcf = new FormContratoFísico();
        private FormContratoJuridico fcj = new FormContratoJuridico();
        //private FormContratos fcon = new FormContratos();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!fc.Visible)
            {
                fc.MdiParent = this;
                fc.Show();
            }
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fj.Visible) {
                fj.MdiParent = this;
                fj.Show();
            }
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ff.Visible)
            {
                ff.MdiParent = this;
                ff.Show();
            }
        }

        private void representanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fr.Visible)
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!fcf.Visible)
            {
                fcf.MdiParent = this;
                fcf.Show();
            }
        }

        private void pessoaJurídicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!fcj.Visible)
            {
                fcj.MdiParent = this;
                fcj.Show();
            }
        }

        /*private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!fcon.Visible)
            {
                fcon.MdiParent = this;
                fcon.Show();
            }
        }*/
    }
}
