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
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.gbProcuraNome = new System.Windows.Forms.GroupBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.radioBttJuridica = new System.Windows.Forms.RadioButton();
            this.radioBttFisica = new System.Windows.Forms.RadioButton();
            this.radioBttTodos = new System.Windows.Forms.RadioButton();
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
            this.gbLista.Size = new System.Drawing.Size(962, 543);
            this.gbLista.TabIndex = 1;
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
            this.Nome,
            this.CPF_CNPJ,
            this.Telefone,
            this.Celular,
            this.Endereço});
            this.dataGViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGViewLista.Location = new System.Drawing.Point(3, 16);
            this.dataGViewLista.Name = "dataGViewLista";
            this.dataGViewLista.ReadOnly = true;
            this.dataGViewLista.Size = new System.Drawing.Size(956, 524);
            this.dataGViewLista.TabIndex = 0;
            this.dataGViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGViewLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGViewLista_CellDoubleClick);
            this.dataGViewLista.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGViewLista_UserDeletedRow);
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
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
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
            this.gbProcuraNome.Controls.Add(this.lblTipoPessoa);
            this.gbProcuraNome.Controls.Add(this.radioBttJuridica);
            this.gbProcuraNome.Controls.Add(this.radioBttFisica);
            this.gbProcuraNome.Controls.Add(this.radioBttTodos);
            this.gbProcuraNome.Controls.Add(this.txtBuscaNomeCPF);
            this.gbProcuraNome.Controls.Add(this.lbNomeCPF);
            this.gbProcuraNome.Location = new System.Drawing.Point(3, 1);
            this.gbProcuraNome.Name = "gbProcuraNome";
            this.gbProcuraNome.Size = new System.Drawing.Size(963, 88);
            this.gbProcuraNome.TabIndex = 5;
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
            this.radioBttJuridica.TabIndex = 4;
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
            this.radioBttFisica.TabIndex = 3;
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
            this.radioBttTodos.TabIndex = 2;
            this.radioBttTodos.TabStop = true;
            this.radioBttTodos.Text = "Todos";
            this.radioBttTodos.UseVisualStyleBackColor = true;
            this.radioBttTodos.CheckedChanged += new System.EventHandler(this.radioBttTodos_CheckedChanged);
            // 
            // txtBuscaNomeCPF
            // 
            this.txtBuscaNomeCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaNomeCPF.Location = new System.Drawing.Point(73, 23);
            this.txtBuscaNomeCPF.Name = "txtBuscaNomeCPF";
            this.txtBuscaNomeCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscaNomeCPF.Size = new System.Drawing.Size(875, 20);
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
            this.gbBotoes.Location = new System.Drawing.Point(142, 615);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(680, 74);
            this.gbBotoes.TabIndex = 7;
            this.gbBotoes.TabStop = false;
            // 
            // FormCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 700);
            this.Controls.Add(this.gbProcuraNome);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCadastrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.GroupBox gbProcuraNome;
        private System.Windows.Forms.TextBox txtBuscaNomeCPF;
        private System.Windows.Forms.Label lbNomeCPF;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.RadioButton radioBttJuridica;
        private System.Windows.Forms.RadioButton radioBttFisica;
        private System.Windows.Forms.RadioButton radioBttTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
    }
}