namespace Buffet.CV
{
    partial class FormAgenda
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
            this.panelAtributos = new System.Windows.Forms.Panel();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelAgenda = new System.Windows.Forms.Panel();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.panelAtributos.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.panelAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAtributos
            // 
            this.panelAtributos.Controls.Add(this.lblTelefone);
            this.panelAtributos.Controls.Add(this.txtTelefone);
            this.panelAtributos.Controls.Add(this.dtData);
            this.panelAtributos.Controls.Add(this.lblData);
            this.panelAtributos.Controls.Add(this.panelBotoes);
            this.panelAtributos.Controls.Add(this.txtNome);
            this.panelAtributos.Controls.Add(this.lblNome);
            this.panelAtributos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtributos.Location = new System.Drawing.Point(0, 0);
            this.panelAtributos.Name = "panelAtributos";
            this.panelAtributos.Size = new System.Drawing.Size(860, 174);
            this.panelAtributos.TabIndex = 0;
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(61, 75);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(102, 20);
            this.dtData.TabIndex = 4;
            this.dtData.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(21, 75);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 15);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.bttAdicionar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoes.Location = new System.Drawing.Point(0, 111);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(856, 63);
            this.panelBotoes.TabIndex = 2;
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Location = new System.Drawing.Point(160, 16);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(529, 32);
            this.bttAdicionar.TabIndex = 0;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(783, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(21, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // panelAgenda
            // 
            this.panelAgenda.Controls.Add(this.dgvAgenda);
            this.panelAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgenda.Location = new System.Drawing.Point(0, 174);
            this.panelAgenda.Name = "panelAgenda";
            this.panelAgenda.Size = new System.Drawing.Size(860, 516);
            this.panelAgenda.TabIndex = 1;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnData,
            this.ColumnRemove});
            this.dgvAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAgenda.Location = new System.Drawing.Point(0, 0);
            this.dgvAgenda.MultiSelect = false;
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(860, 516);
            this.dgvAgenda.TabIndex = 0;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            // 
            // ColumnRemove
            // 
            this.ColumnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnRemove.HeaderText = "Remover";
            this.ColumnRemove.Name = "ColumnRemove";
            this.ColumnRemove.ReadOnly = true;
            this.ColumnRemove.Text = "Remover";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(81, 49);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(763, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(21, 51);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(56, 15);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 690);
            this.Controls.Add(this.panelAgenda);
            this.Controls.Add(this.panelAtributos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgenda";
            this.ShowInTaskbar = false;
            this.Text = "FormAgenda";
            this.panelAtributos.ResumeLayout(false);
            this.panelAtributos.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.panelAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAtributos;
        private System.Windows.Forms.Panel panelAgenda;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnRemove;
    }
}