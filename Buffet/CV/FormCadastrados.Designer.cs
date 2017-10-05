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
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.dataGViewLista = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatadeNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.gbProcuraNome = new System.Windows.Forms.GroupBox();
            this.txtBuscaNomeCPF = new System.Windows.Forms.TextBox();
            this.lbNomeCPF = new System.Windows.Forms.Label();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.gbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewLista)).BeginInit();
            this.gbProcuraNome.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLista
            // 
            this.gbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbLista.Controls.Add(this.dataGViewLista);
            this.gbLista.Location = new System.Drawing.Point(3, 76);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(707, 372);
            this.gbLista.TabIndex = 1;
            this.gbLista.TabStop = false;
            this.gbLista.Enter += new System.EventHandler(this.gbLista_Enter);
            // 
            // dataGViewLista
            // 
            this.dataGViewLista.AllowUserToDeleteRows = false;
            this.dataGViewLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Endereço,
            this.DatadeNascimento,
            this.Telefone});
            this.dataGViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGViewLista.Location = new System.Drawing.Point(3, 16);
            this.dataGViewLista.Name = "dataGViewLista";
            this.dataGViewLista.ReadOnly = true;
            this.dataGViewLista.Size = new System.Drawing.Size(701, 353);
            this.dataGViewLista.TabIndex = 0;
            this.dataGViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGViewLista.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGViewLista_UserDeletedRow);
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
            this.bttRemove.Click += new System.EventHandler(this.bttRemove_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(515, 19);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(125, 43);
            this.bttEditar.TabIndex = 4;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // gbProcuraNome
            // 
            this.gbProcuraNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProcuraNome.AutoSize = true;
            this.gbProcuraNome.Controls.Add(this.txtBuscaNomeCPF);
            this.gbProcuraNome.Controls.Add(this.lbNomeCPF);
            this.gbProcuraNome.Location = new System.Drawing.Point(3, 1);
            this.gbProcuraNome.Name = "gbProcuraNome";
            this.gbProcuraNome.Size = new System.Drawing.Size(707, 69);
            this.gbProcuraNome.TabIndex = 5;
            this.gbProcuraNome.TabStop = false;
            // 
            // txtBuscaNomeCPF
            // 
            this.txtBuscaNomeCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaNomeCPF.Location = new System.Drawing.Point(73, 23);
            this.txtBuscaNomeCPF.Name = "txtBuscaNomeCPF";
            this.txtBuscaNomeCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscaNomeCPF.Size = new System.Drawing.Size(619, 20);
            this.txtBuscaNomeCPF.TabIndex = 1;
            // 
            // lbNomeCPF
            // 
            this.lbNomeCPF.AutoSize = true;
            this.lbNomeCPF.Location = new System.Drawing.Point(7, 27);
            this.lbNomeCPF.Name = "lbNomeCPF";
            this.lbNomeCPF.Size = new System.Drawing.Size(63, 13);
            this.lbNomeCPF.TabIndex = 0;
            this.lbNomeCPF.Text = "Nome/CPF:";
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbBotoes.Controls.Add(this.bttAdicionar);
            this.gbBotoes.Controls.Add(this.bttEditar);
            this.gbBotoes.Controls.Add(this.bttRemove);
            this.gbBotoes.Location = new System.Drawing.Point(15, 444);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(680, 74);
            this.gbBotoes.TabIndex = 7;
            this.gbBotoes.TabStop = false;
            // 
            // FormCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 529);
            this.Controls.Add(this.gbProcuraNome);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbBotoes);
            this.Name = "FormCadastrados";
            this.Text = "Cadastrados";
            this.Load += new System.EventHandler(this.FormCadastrados_Load);
            this.gbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewLista)).EndInit();
            this.gbProcuraNome.ResumeLayout(false);
            this.gbProcuraNome.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView dataGViewLista;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatadeNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.GroupBox gbProcuraNome;
        private System.Windows.Forms.TextBox txtBuscaNomeCPF;
        private System.Windows.Forms.Label lbNomeCPF;
        private System.Windows.Forms.GroupBox gbBotoes;
    }
}