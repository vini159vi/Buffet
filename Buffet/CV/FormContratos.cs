using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.CV
{
    public partial class FormContratos : Form
    {
        public FormContratos()
        {
            InitializeComponent();
        }

        private void FormContratos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
