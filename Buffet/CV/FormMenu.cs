using Buffet.CV;
using System;
using System.Windows.Forms;

namespace Buffet
{
    public partial class FormMenu : Form
    {
        private FormJuridico fj = new FormJuridico();
        private FormCadastrados fc = new FormCadastrados();
        private FormRepresentante fr = new FormRepresentante();
        private FormFisico ff = new FormFisico();
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
    }
}
