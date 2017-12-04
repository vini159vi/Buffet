namespace Buffet.CV
{
    partial class FormControleItens
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
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.cellId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellValorPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttFechar = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.panelBotoes.SuspendLayout();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.bttFechar);
            this.panelBotoes.Controls.Add(this.bttEditar);
            this.panelBotoes.Controls.Add(this.bttRemove);
            this.panelBotoes.Location = new System.Drawing.Point(2, 587);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(855, 100);
            this.panelBotoes.TabIndex = 0;
            // 
            // panelDgv
            // 
            this.panelDgv.Controls.Add(this.dgvItens);
            this.panelDgv.Location = new System.Drawing.Point(2, 2);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(855, 579);
            this.panelDgv.TabIndex = 1;
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
            this.cellId,
            this.cellNome,
            this.cellValorPessoa,
            this.cellTipo});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(855, 579);
            this.dgvItens.TabIndex = 1;
            // 
            // cellId
            // 
            this.cellId.HeaderText = "ID";
            this.cellId.Name = "cellId";
            this.cellId.ReadOnly = true;
            // 
            // cellNome
            // 
            this.cellNome.HeaderText = "Nome";
            this.cellNome.Name = "cellNome";
            this.cellNome.ReadOnly = true;
            // 
            // cellValorPessoa
            // 
            this.cellValorPessoa.HeaderText = "Valor Por Pessoa";
            this.cellValorPessoa.Name = "cellValorPessoa";
            this.cellValorPessoa.ReadOnly = true;
            // 
            // cellTipo
            // 
            this.cellTipo.HeaderText = "Tipo";
            this.cellTipo.Name = "cellTipo";
            this.cellTipo.ReadOnly = true;
            // 
            // bttFechar
            // 
            this.bttFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFechar.Location = new System.Drawing.Point(698, 29);
            this.bttFechar.Name = "bttFechar";
            this.bttFechar.Size = new System.Drawing.Size(125, 43);
            this.bttFechar.TabIndex = 5;
            this.bttFechar.Text = "Fechar";
            this.bttFechar.UseVisualStyleBackColor = true;
            this.bttFechar.Click += new System.EventHandler(this.bttFechar_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEditar.Location = new System.Drawing.Point(369, 29);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(125, 43);
            this.bttEditar.TabIndex = 4;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttRemove
            // 
            this.bttRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRemove.Location = new System.Drawing.Point(32, 29);
            this.bttRemove.Name = "bttRemove";
            this.bttRemove.Size = new System.Drawing.Size(125, 43);
            this.bttRemove.TabIndex = 3;
            this.bttRemove.Text = "Remover";
            this.bttRemove.UseVisualStyleBackColor = true;
            this.bttRemove.Click += new System.EventHandler(this.bttRemove_Click);
            // 
            // FormControleItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 690);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.panelBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControleItens";
            this.Text = "FormControleItens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.VisibleChanged += new System.EventHandler(this.FormControleItens_VisibleChanged);
            this.panelBotoes.ResumeLayout(false);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Panel panelDgv;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellValorPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTipo;
        private System.Windows.Forms.Button bttFechar;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttRemove;
    }
}