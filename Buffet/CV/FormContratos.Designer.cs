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
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.radioBttJuridica = new System.Windows.Forms.RadioButton();
            this.radioBttFisica = new System.Windows.Forms.RadioButton();
            this.radioBttTodos = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.gbLista = new System.Windows.Forms.Panel();
            this.dataGViewLista = new System.Windows.Forms.DataGridView();
            this.cellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDataEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.bttFechar = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.gbFiltrar.SuspendLayout();
            this.gbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewLista)).BeginInit();
            this.gbBotoes.SuspendLayout();
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
            this.gbFiltrar.Location = new System.Drawing.Point(6, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(844, 90);
            this.gbFiltrar.TabIndex = 0;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
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
            this.radioBttJuridica.CheckedChanged += new System.EventHandler(this.radioBttJuridica_CheckedChanged);
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
            this.radioBttFisica.CheckedChanged += new System.EventHandler(this.radioBttFisica_CheckedChanged);
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
            this.radioBttTodos.CheckedChanged += new System.EventHandler(this.radioBttTodos_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(33, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(805, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
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
            // gbLista
            // 
            this.gbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbLista.Controls.Add(this.dataGViewLista);
            this.gbLista.Location = new System.Drawing.Point(12, 108);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(832, 473);
            this.gbLista.TabIndex = 1;
            // 
            // dataGViewLista
            // 
            this.dataGViewLista.AllowUserToAddRows = false;
            this.dataGViewLista.AllowUserToDeleteRows = false;
            this.dataGViewLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGViewLista.BackgroundColor = System.Drawing.Color.White;
            this.dataGViewLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGViewLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellID,
            this.cellTipo,
            this.cellNomeEmpresa,
            this.cellDataEvento,
            this.cellPreco});
            this.dataGViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGViewLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGViewLista.GridColor = System.Drawing.Color.Black;
            this.dataGViewLista.Location = new System.Drawing.Point(0, 0);
            this.dataGViewLista.Name = "dataGViewLista";
            this.dataGViewLista.ReadOnly = true;
            this.dataGViewLista.RowHeadersVisible = false;
            this.dataGViewLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGViewLista.Size = new System.Drawing.Size(832, 473);
            this.dataGViewLista.TabIndex = 0;
            this.dataGViewLista.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGViewLista_CellMouseDoubleClick);
            this.dataGViewLista.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGViewLista_UserDeletedRow);
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
            // cellNomeEmpresa
            // 
            this.cellNomeEmpresa.HeaderText = "Nome/Empresa";
            this.cellNomeEmpresa.Name = "cellNomeEmpresa";
            this.cellNomeEmpresa.ReadOnly = true;
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
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbBotoes.Controls.Add(this.bttFechar);
            this.gbBotoes.Controls.Add(this.bttEditar);
            this.gbBotoes.Controls.Add(this.bttRemove);
            this.gbBotoes.Location = new System.Drawing.Point(-58, 587);
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
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
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
            // FormContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 673);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContratos_FormClosing);
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewLista)).EndInit();
            this.gbBotoes.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNomeEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellDataEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPreco;
    }
}