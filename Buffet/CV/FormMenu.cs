using Buffet.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet
{
    public partial class FormMenu : Form
    {
        private FormJuridico fj = new FormJuridico();
        private FormFisico fcc = new FormFisico();
        private FormCadastrados fc = new FormCadastrados();
        private FormRepresentante fr = new FormRepresentante();
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
            if (!fcc.Visible)
            {
                fcc.MdiParent = this;
                fcc.Show();
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
