﻿using System;
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
    public partial class FormCadastrados : Form
    {
        public FormCadastrados()
        {
            InitializeComponent();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente tela = new FormCadastroCliente();
            tela.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FormCadastrados_Load(object sender, EventArgs e)
        {

        }
    }
}
