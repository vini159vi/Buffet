namespace Buffet
{
    partial class FormCadastrados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatadeNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.gbProcura = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProcura.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(3, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Endereço,
            this.DatadeNascimento,
            this.Telefone});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(676, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            // 
            // DatadeNascimento
            // 
            this.DatadeNascimento.HeaderText = "Data de Nascimento";
            this.DatadeNascimento.Name = "DatadeNascimento";
            this.DatadeNascimento.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.Location = new System.Drawing.Point(64, 19);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(125, 43);
            this.bttAdicionar.TabIndex = 2;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // bttRemove
            // 
            this.bttRemove.Location = new System.Drawing.Point(292, 19);
            this.bttRemove.Name = "bttRemove";
            this.bttRemove.Size = new System.Drawing.Size(125, 43);
            this.bttRemove.TabIndex = 3;
            this.bttRemove.Text = "Remover";
            this.bttRemove.UseVisualStyleBackColor = true;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(515, 19);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(125, 43);
            this.bttEditar.TabIndex = 4;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            // 
            // gbProcura
            // 
            this.gbProcura.Controls.Add(this.txtNome);
            this.gbProcura.Controls.Add(this.lbNome);
            this.gbProcura.Location = new System.Drawing.Point(3, 1);
            this.gbProcura.Name = "gbProcura";
            this.gbProcura.Size = new System.Drawing.Size(341, 69);
            this.gbProcura.TabIndex = 5;
            this.gbProcura.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(4, 27);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.lbCPF);
            this.groupBox1.Location = new System.Drawing.Point(344, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(39, 24);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(284, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(8, 27);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 0;
            this.lbCPF.Text = "CPF";
            // 
            // gbBotoes
            // 
            this.gbBotoes.Controls.Add(this.bttAdicionar);
            this.gbBotoes.Controls.Add(this.bttEditar);
            this.gbBotoes.Controls.Add(this.bttRemove);
            this.gbBotoes.Location = new System.Drawing.Point(2, 444);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(680, 74);
            this.gbBotoes.TabIndex = 7;
            this.gbBotoes.TabStop = false;
            // 
            // FormCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProcura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbBotoes);
            this.Name = "FormCadastrados";
            this.Text = "Cadastrados";
            this.Load += new System.EventHandler(this.FormCadastrados_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProcura.ResumeLayout(false);
            this.gbProcura.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatadeNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.GroupBox gbProcura;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.GroupBox gbBotoes;
    }
}