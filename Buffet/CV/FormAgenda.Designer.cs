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
            this.checkBoxHistorico = new System.Windows.Forms.CheckBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelAgenda = new System.Windows.Forms.Panel();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAtributos.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.panelAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAtributos
            // 
            this.panelAtributos.Controls.Add(this.checkBoxHistorico);
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
            // checkBoxHistorico
            // 
            this.checkBoxHistorico.AutoSize = true;
            this.checkBoxHistorico.Location = new System.Drawing.Point(185, 78);
            this.checkBoxHistorico.Name = "checkBoxHistorico";
            this.checkBoxHistorico.Size = new System.Drawing.Size(119, 17);
            this.checkBoxHistorico.TabIndex = 3;
            this.checkBoxHistorico.Text = "Incluir os removidos";
            this.checkBoxHistorico.UseVisualStyleBackColor = true;
            this.checkBoxHistorico.CheckedChanged += new System.EventHandler(this.checkBoxHistorico_CheckedChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTelefone.Location = new System.Drawing.Point(21, 52);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(79, 49);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(765, 20);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(61, 75);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(102, 20);
            this.dtData.TabIndex = 2;
            this.dtData.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblData.Location = new System.Drawing.Point(21, 75);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.bttAdicionar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoes.Location = new System.Drawing.Point(0, 111);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(860, 63);
            this.panelBotoes.TabIndex = 2;
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Location = new System.Drawing.Point(121, 15);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(619, 32);
            this.bttAdicionar.TabIndex = 0;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(783, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNome.Location = new System.Drawing.Point(21, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
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
            this.ColumnID,
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
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnRemove;
        private System.Windows.Forms.CheckBox checkBoxHistorico;
    }
}