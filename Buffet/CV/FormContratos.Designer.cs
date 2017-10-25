namespace Buffet.CV
{
    partial class FormContratos
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
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.radioBttJuridica = new System.Windows.Forms.RadioButton();
            this.radioBttFisica = new System.Windows.Forms.RadioButton();
            this.radioBttTodos = new System.Windows.Forms.RadioButton();
            this.gbLista = new System.Windows.Forms.Panel();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.bttFechar = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.dataGViewLista = new System.Windows.Forms.DataGridView();
            this.cellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDataEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltrar.SuspendLayout();
            this.gbLista.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.AutoSize = true;
            this.gbFiltrar.Controls.Add(this.lblTipoPessoa);
            this.gbFiltrar.Controls.Add(this.radioBttJuridica);
            this.gbFiltrar.Controls.Add(this.radioBttFisica);
            this.gbFiltrar.Controls.Add(this.radioBttTodos);
            this.gbFiltrar.Controls.Add(this.txtID);
            this.gbFiltrar.Controls.Add(this.lbID);
            this.gbFiltrar.Location = new System.Drawing.Point(12, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(960, 90);
            this.gbFiltrar.TabIndex = 0;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 26);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(33, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(921, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(6, 56);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(31, 13);
            this.lblTipoPessoa.TabIndex = 9;
            this.lblTipoPessoa.Text = "Tipo:";
            // 
            // radioBttJuridica
            // 
            this.radioBttJuridica.AutoSize = true;
            this.radioBttJuridica.Location = new System.Drawing.Point(162, 54);
            this.radioBttJuridica.Name = "radioBttJuridica";
            this.radioBttJuridica.Size = new System.Drawing.Size(63, 17);
            this.radioBttJuridica.TabIndex = 3;
            this.radioBttJuridica.Text = "Jurídica";
            this.radioBttJuridica.UseVisualStyleBackColor = true;
            // 
            // radioBttFisica
            // 
            this.radioBttFisica.AutoSize = true;
            this.radioBttFisica.Location = new System.Drawing.Point(104, 54);
            this.radioBttFisica.Name = "radioBttFisica";
            this.radioBttFisica.Size = new System.Drawing.Size(54, 17);
            this.radioBttFisica.TabIndex = 2;
            this.radioBttFisica.Text = "Física";
            this.radioBttFisica.UseVisualStyleBackColor = true;
            // 
            // radioBttTodos
            // 
            this.radioBttTodos.AutoSize = true;
            this.radioBttTodos.Checked = true;
            this.radioBttTodos.Location = new System.Drawing.Point(43, 54);
            this.radioBttTodos.Name = "radioBttTodos";
            this.radioBttTodos.Size = new System.Drawing.Size(55, 17);
            this.radioBttTodos.TabIndex = 1;
            this.radioBttTodos.TabStop = true;
            this.radioBttTodos.Text = "Todos";
            this.radioBttTodos.UseVisualStyleBackColor = true;
            // 
            // gbLista
            // 
            this.gbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbLista.Controls.Add(this.dataGViewLista);
            this.gbLista.Location = new System.Drawing.Point(12, 108);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(960, 466);
            this.gbLista.TabIndex = 1;
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbBotoes.Controls.Add(this.bttFechar);
            this.gbBotoes.Controls.Add(this.bttEditar);
            this.gbBotoes.Controls.Add(this.bttRemove);
            this.gbBotoes.Location = new System.Drawing.Point(12, 580);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(960, 74);
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
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(416, 16);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(125, 43);
            this.bttEditar.TabIndex = 1;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            // 
            // bttRemove
            // 
            this.bttRemove.Location = new System.Drawing.Point(79, 16);
            this.bttRemove.Name = "bttRemove";
            this.bttRemove.Size = new System.Drawing.Size(125, 43);
            this.bttRemove.TabIndex = 0;
            this.bttRemove.Text = "Remover";
            this.bttRemove.UseVisualStyleBackColor = true;
            // 
            // dataGViewLista
            // 
            this.dataGViewLista.AllowUserToAddRows = false;
            this.dataGViewLista.AllowUserToDeleteRows = false;
            this.dataGViewLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellID,
            this.cellTipo,
            this.cellNome,
            this.cellDataEvento,
            this.cellPreco});
            this.dataGViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGViewLista.Location = new System.Drawing.Point(0, 0);
            this.dataGViewLista.Name = "dataGViewLista";
            this.dataGViewLista.ReadOnly = true;
            this.dataGViewLista.RowHeadersVisible = false;
            this.dataGViewLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGViewLista.Size = new System.Drawing.Size(960, 466);
            this.dataGViewLista.TabIndex = 0;
            // 
            // cellID
            // 
            this.cellID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cellID.HeaderText = "ID";
            this.cellID.Name = "cellID";
            this.cellID.ReadOnly = true;
            this.cellID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cellID.Width = 43;
            // 
            // cellTipo
            // 
            this.cellTipo.HeaderText = "Tipo";
            this.cellTipo.Name = "cellTipo";
            this.cellTipo.ReadOnly = true;
            // 
            // cellNome
            // 
            this.cellNome.HeaderText = "Nome";
            this.cellNome.Name = "cellNome";
            this.cellNome.ReadOnly = true;
            // 
            // cellDataEvento
            // 
            this.cellDataEvento.HeaderText = "Data do Evento";
            this.cellDataEvento.Name = "cellDataEvento";
            this.cellDataEvento.ReadOnly = true;
            this.cellDataEvento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cellPreco
            // 
            this.cellPreco.HeaderText = "Preço";
            this.cellPreco.Name = "cellPreco";
            this.cellPreco.ReadOnly = true;
            this.cellPreco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 666);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormContratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContratos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContratos_FormClosing);
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbLista.ResumeLayout(false);
            this.gbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.RadioButton radioBttJuridica;
        private System.Windows.Forms.RadioButton radioBttFisica;
        private System.Windows.Forms.RadioButton radioBttTodos;
        private System.Windows.Forms.Panel gbLista;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Button bttFechar;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.DataGridView dataGViewLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellDataEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPreco;
    }
}