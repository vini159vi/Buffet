namespace Buffet.CV
{
    partial class FormCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCardapio));
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.radioBttTipo1 = new System.Windows.Forms.RadioButton();
            this.radioBttTipo2 = new System.Windows.Forms.RadioButton();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.gbCardapio = new System.Windows.Forms.GroupBox();
            this.bttRemover = new System.Windows.Forms.Button();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.cellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellValorPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCardapio = new System.Windows.Forms.DataGridView();
            this.cellIDCardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNomeCardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellValorPessoaCardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTipoCardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOpcao.SuspendLayout();
            this.gbItens.SuspendLayout();
            this.gbCardapio.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardapio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.radioBttTipo2);
            this.gbOpcao.Controls.Add(this.radioBttTipo1);
            this.gbOpcao.Location = new System.Drawing.Point(2, 3);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(856, 61);
            this.gbOpcao.TabIndex = 0;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Qual cardápio vai editar?";
            // 
            // radioBttTipo1
            // 
            this.radioBttTipo1.AutoSize = true;
            this.radioBttTipo1.Location = new System.Drawing.Point(10, 22);
            this.radioBttTipo1.Name = "radioBttTipo1";
            this.radioBttTipo1.Size = new System.Drawing.Size(55, 17);
            this.radioBttTipo1.TabIndex = 0;
            this.radioBttTipo1.TabStop = true;
            this.radioBttTipo1.Text = "Tipo 1";
            this.radioBttTipo1.UseVisualStyleBackColor = true;
            this.radioBttTipo1.CheckedChanged += new System.EventHandler(this.radioBttTipo1_CheckedChanged);
            // 
            // radioBttTipo2
            // 
            this.radioBttTipo2.AutoSize = true;
            this.radioBttTipo2.Location = new System.Drawing.Point(88, 22);
            this.radioBttTipo2.Name = "radioBttTipo2";
            this.radioBttTipo2.Size = new System.Drawing.Size(55, 17);
            this.radioBttTipo2.TabIndex = 1;
            this.radioBttTipo2.TabStop = true;
            this.radioBttTipo2.Text = "Tipo 2";
            this.radioBttTipo2.UseVisualStyleBackColor = true;
            this.radioBttTipo2.CheckedChanged += new System.EventHandler(this.radioBttTipo2_CheckedChanged);
            // 
            // gbItens
            // 
            this.gbItens.Controls.Add(this.dgvItens);
            this.gbItens.Location = new System.Drawing.Point(2, 70);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(398, 537);
            this.gbItens.TabIndex = 1;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Lista de Itens";
            // 
            // gbCardapio
            // 
            this.gbCardapio.Controls.Add(this.dgvCardapio);
            this.gbCardapio.Location = new System.Drawing.Point(460, 70);
            this.gbCardapio.Name = "gbCardapio";
            this.gbCardapio.Size = new System.Drawing.Size(398, 537);
            this.gbCardapio.TabIndex = 2;
            this.gbCardapio.TabStop = false;
            this.gbCardapio.Text = "Cardápio";
            // 
            // bttRemover
            // 
            this.bttRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttRemover.BackgroundImage")));
            this.bttRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRemover.Location = new System.Drawing.Point(413, 400);
            this.bttRemover.Name = "bttRemover";
            this.bttRemover.Size = new System.Drawing.Size(34, 34);
            this.bttRemover.TabIndex = 10;
            this.bttRemover.UseVisualStyleBackColor = true;
            this.bttRemover.Click += new System.EventHandler(this.bttRemover_Click);
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttAdicionar.BackgroundImage")));
            this.bttAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Location = new System.Drawing.Point(413, 257);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(34, 34);
            this.bttAdicionar.TabIndex = 9;
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbBotoes.Controls.Add(this.bttCancelar);
            this.gbBotoes.Location = new System.Drawing.Point(6, 613);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(842, 75);
            this.gbBotoes.TabIndex = 6;
            this.gbBotoes.TabStop = false;
            // 
            // bttCancelar
            // 
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCancelar.Location = new System.Drawing.Point(358, 22);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(125, 43);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Sair";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellID,
            this.cellNome,
            this.cellValorPessoa,
            this.cellTipo});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItens.Location = new System.Drawing.Point(3, 16);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(392, 518);
            this.dgvItens.TabIndex = 1;
            // 
            // cellID
            // 
            this.cellID.HeaderText = "ID";
            this.cellID.Name = "cellID";
            this.cellID.ReadOnly = true;
            // 
            // cellNome
            // 
            this.cellNome.HeaderText = "Nome";
            this.cellNome.Name = "cellNome";
            this.cellNome.ReadOnly = true;
            // 
            // cellValorPessoa
            // 
            this.cellValorPessoa.HeaderText = "Valor por pessoa";
            this.cellValorPessoa.Name = "cellValorPessoa";
            this.cellValorPessoa.ReadOnly = true;
            // 
            // cellTipo
            // 
            this.cellTipo.HeaderText = "Tipo";
            this.cellTipo.Name = "cellTipo";
            this.cellTipo.ReadOnly = true;
            // 
            // dgvCardapio
            // 
            this.dgvCardapio.AllowUserToAddRows = false;
            this.dgvCardapio.AllowUserToDeleteRows = false;
            this.dgvCardapio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCardapio.BackgroundColor = System.Drawing.Color.White;
            this.dgvCardapio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCardapio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellIDCardapio,
            this.cellNomeCardapio,
            this.cellValorPessoaCardapio,
            this.cellTipoCardapio});
            this.dgvCardapio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCardapio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCardapio.Location = new System.Drawing.Point(3, 16);
            this.dgvCardapio.MultiSelect = false;
            this.dgvCardapio.Name = "dgvCardapio";
            this.dgvCardapio.ReadOnly = true;
            this.dgvCardapio.RowHeadersVisible = false;
            this.dgvCardapio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCardapio.Size = new System.Drawing.Size(392, 518);
            this.dgvCardapio.TabIndex = 2;
            // 
            // cellIDCardapio
            // 
            this.cellIDCardapio.HeaderText = "ID";
            this.cellIDCardapio.Name = "cellIDCardapio";
            this.cellIDCardapio.ReadOnly = true;
            // 
            // cellNomeCardapio
            // 
            this.cellNomeCardapio.HeaderText = "Nome";
            this.cellNomeCardapio.Name = "cellNomeCardapio";
            this.cellNomeCardapio.ReadOnly = true;
            // 
            // cellValorPessoaCardapio
            // 
            this.cellValorPessoaCardapio.HeaderText = "Valor por pessoa";
            this.cellValorPessoaCardapio.Name = "cellValorPessoaCardapio";
            this.cellValorPessoaCardapio.ReadOnly = true;
            // 
            // cellTipoCardapio
            // 
            this.cellTipoCardapio.HeaderText = "Tipo";
            this.cellTipoCardapio.Name = "cellTipoCardapio";
            this.cellTipoCardapio.ReadOnly = true;
            // 
            // FormCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 690);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.bttRemover);
            this.Controls.Add(this.bttAdicionar);
            this.Controls.Add(this.gbCardapio);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.gbOpcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCardapio";
            this.Text = "FormCardapio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.VisibleChanged += new System.EventHandler(this.FormCardapio_VisibleChanged);
            this.gbOpcao.ResumeLayout(false);
            this.gbOpcao.PerformLayout();
            this.gbItens.ResumeLayout(false);
            this.gbCardapio.ResumeLayout(false);
            this.gbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardapio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.RadioButton radioBttTipo2;
        private System.Windows.Forms.RadioButton radioBttTipo1;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.GroupBox gbCardapio;
        private System.Windows.Forms.Button bttRemover;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellValorPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTipo;
        private System.Windows.Forms.DataGridView dgvCardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellIDCardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNomeCardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellValorPessoaCardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTipoCardapio;
    }
}