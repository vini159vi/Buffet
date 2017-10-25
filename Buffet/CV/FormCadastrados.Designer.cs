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
            this.cellTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttRemove = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.gbProcuraNome = new System.Windows.Forms.GroupBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.radioBttJuridica = new System.Windows.Forms.RadioButton();
            this.radioBttFisica = new System.Windows.Forms.RadioButton();
            this.radioBttTodos = new System.Windows.Forms.RadioButton();
            this.txtBuscaCpfCnpj = new System.Windows.Forms.TextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.bttFechar = new System.Windows.Forms.Button();
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
            this.gbLista.Size = new System.Drawing.Size(962, 543);
            this.gbLista.TabIndex = 2;
            this.gbLista.TabStop = false;
            this.gbLista.Enter += new System.EventHandler(this.gbLista_Enter);
            // 
            // dataGViewLista
            // 
            this.dataGViewLista.AllowUserToAddRows = false;
            this.dataGViewLista.AllowUserToDeleteRows = false;
            this.dataGViewLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellTipo,
            this.Nome,
            this.CPF_CNPJ,
            this.Telefone,
            this.Celular,
            this.Endereço});
            this.dataGViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGViewLista.Location = new System.Drawing.Point(3, 16);
            this.dataGViewLista.Name = "dataGViewLista";
            this.dataGViewLista.ReadOnly = true;
            this.dataGViewLista.RowHeadersVisible = false;
            this.dataGViewLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGViewLista.Size = new System.Drawing.Size(956, 524);
            this.dataGViewLista.TabIndex = 0;
            this.dataGViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGViewLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGViewLista_CellDoubleClick);
            this.dataGViewLista.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGViewLista_CellMouseDoubleClick);
            this.dataGViewLista.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGViewLista_UserDeletedRow);
            // 
            // cellTipo
            // 
            this.cellTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cellTipo.HeaderText = "Tipo";
            this.cellTipo.Name = "cellTipo";
            this.cellTipo.ReadOnly = true;
            this.cellTipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cellTipo.Width = 53;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.HeaderText = "CPF/CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            // 
            // bttRemove
            // 
            this.bttRemove.Location = new System.Drawing.Point(79, 16);
            this.bttRemove.Name = "bttRemove";
            this.bttRemove.Size = new System.Drawing.Size(125, 43);
            this.bttRemove.TabIndex = 0;
            this.bttRemove.Text = "Remover";
            this.bttRemove.UseVisualStyleBackColor = true;
            this.bttRemove.Click += new System.EventHandler(this.bttRemove_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(416, 16);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(125, 43);
            this.bttEditar.TabIndex = 1;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // gbProcuraNome
            // 
            this.gbProcuraNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProcuraNome.AutoSize = true;
            this.gbProcuraNome.Controls.Add(this.lblTipoPessoa);
            this.gbProcuraNome.Controls.Add(this.radioBttJuridica);
            this.gbProcuraNome.Controls.Add(this.radioBttFisica);
            this.gbProcuraNome.Controls.Add(this.radioBttTodos);
            this.gbProcuraNome.Controls.Add(this.txtBuscaCpfCnpj);
            this.gbProcuraNome.Controls.Add(this.lbCPFCNPJ);
            this.gbProcuraNome.Location = new System.Drawing.Point(3, 1);
            this.gbProcuraNome.Name = "gbProcuraNome";
            this.gbProcuraNome.Size = new System.Drawing.Size(964, 88);
            this.gbProcuraNome.TabIndex = 0;
            this.gbProcuraNome.TabStop = false;
            this.gbProcuraNome.Text = "Filtrar";
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(7, 54);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(69, 13);
            this.lblTipoPessoa.TabIndex = 5;
            this.lblTipoPessoa.Text = "Tipo Pessoa:";
            // 
            // radioBttJuridica
            // 
            this.radioBttJuridica.AutoSize = true;
            this.radioBttJuridica.Location = new System.Drawing.Point(201, 52);
            this.radioBttJuridica.Name = "radioBttJuridica";
            this.radioBttJuridica.Size = new System.Drawing.Size(61, 17);
            this.radioBttJuridica.TabIndex = 3;
            this.radioBttJuridica.Text = "Juridica";
            this.radioBttJuridica.UseVisualStyleBackColor = true;
            this.radioBttJuridica.CheckedChanged += new System.EventHandler(this.radioBttJuridica_CheckedChanged);
            // 
            // radioBttFisica
            // 
            this.radioBttFisica.AutoSize = true;
            this.radioBttFisica.Location = new System.Drawing.Point(143, 52);
            this.radioBttFisica.Name = "radioBttFisica";
            this.radioBttFisica.Size = new System.Drawing.Size(52, 17);
            this.radioBttFisica.TabIndex = 2;
            this.radioBttFisica.Text = "Fisica";
            this.radioBttFisica.UseVisualStyleBackColor = true;
            this.radioBttFisica.CheckedChanged += new System.EventHandler(this.radioBttFisica_CheckedChanged);
            // 
            // radioBttTodos
            // 
            this.radioBttTodos.AutoSize = true;
            this.radioBttTodos.Checked = true;
            this.radioBttTodos.Location = new System.Drawing.Point(82, 52);
            this.radioBttTodos.Name = "radioBttTodos";
            this.radioBttTodos.Size = new System.Drawing.Size(55, 17);
            this.radioBttTodos.TabIndex = 1;
            this.radioBttTodos.TabStop = true;
            this.radioBttTodos.Text = "Todos";
            this.radioBttTodos.UseVisualStyleBackColor = true;
            this.radioBttTodos.CheckedChanged += new System.EventHandler(this.radioBttTodos_CheckedChanged);
            // 
            // txtBuscaCpfCnpj
            // 
            this.txtBuscaCpfCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaCpfCnpj.Location = new System.Drawing.Point(73, 23);
            this.txtBuscaCpfCnpj.Name = "txtBuscaCpfCnpj";
            this.txtBuscaCpfCnpj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscaCpfCnpj.Size = new System.Drawing.Size(876, 20);
            this.txtBuscaCpfCnpj.TabIndex = 0;
            this.txtBuscaCpfCnpj.TextChanged += new System.EventHandler(this.txtBuscaCpfCnpj_TextChanged);
            this.txtBuscaCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaNomeCPF_KeyPress);
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(7, 27);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(62, 13);
            this.lbCPFCNPJ.TabIndex = 0;
            this.lbCPFCNPJ.Text = "CPF/CNPJ:";
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbBotoes.Controls.Add(this.bttFechar);
            this.gbBotoes.Controls.Add(this.bttEditar);
            this.gbBotoes.Controls.Add(this.bttRemove);
            this.gbBotoes.Location = new System.Drawing.Point(6, 615);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(956, 74);
            this.gbBotoes.TabIndex = 1;
            this.gbBotoes.TabStop = false;
            // 
            // bttFechar
            // 
            this.bttFechar.Location = new System.Drawing.Point(745, 16);
            this.bttFechar.Name = "bttFechar";
            this.bttFechar.Size = new System.Drawing.Size(125, 43);
            this.bttFechar.TabIndex = 2;
            this.bttFechar.Text = "Fechar";
            this.bttFechar.UseVisualStyleBackColor = true;
            this.bttFechar.Click += new System.EventHandler(this.bttFechar_Click);
            // 
            // FormCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(969, 700);
            this.Controls.Add(this.gbProcuraNome);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCadastrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastrados_FormClosing);
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
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.GroupBox gbProcuraNome;
        private System.Windows.Forms.TextBox txtBuscaCpfCnpj;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.RadioButton radioBttJuridica;
        private System.Windows.Forms.RadioButton radioBttFisica;
        private System.Windows.Forms.RadioButton radioBttTodos;
        private System.Windows.Forms.Button bttFechar;
        private System.Windows.Forms.DataGridView dataGViewLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
    }
}