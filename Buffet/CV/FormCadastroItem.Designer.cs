namespace Buffet.CV
{
    partial class FormCadastroItem
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
            this.gbAdicionarItem = new System.Windows.Forms.GroupBox();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.radioBttPratoQuente = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioBttFrutas = new System.Windows.Forms.RadioButton();
            this.radioBttFrios = new System.Windows.Forms.RadioButton();
            this.radioBttBebida = new System.Windows.Forms.RadioButton();
            this.radioBttServicos = new System.Windows.Forms.RadioButton();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.lbValorPorCabeca = new System.Windows.Forms.Label();
            this.txtValorPorCabeca = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbAdicionarItem.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdicionarItem
            // 
            this.gbAdicionarItem.Controls.Add(this.radioBttServicos);
            this.gbAdicionarItem.Controls.Add(this.radioBttBebida);
            this.gbAdicionarItem.Controls.Add(this.radioBttFrios);
            this.gbAdicionarItem.Controls.Add(this.radioBttFrutas);
            this.gbAdicionarItem.Controls.Add(this.radioButton1);
            this.gbAdicionarItem.Controls.Add(this.radioBttPratoQuente);
            this.gbAdicionarItem.Location = new System.Drawing.Point(12, 12);
            this.gbAdicionarItem.Name = "gbAdicionarItem";
            this.gbAdicionarItem.Size = new System.Drawing.Size(208, 181);
            this.gbAdicionarItem.TabIndex = 0;
            this.gbAdicionarItem.TabStop = false;
            this.gbAdicionarItem.Text = "Tipo";
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.Location = new System.Drawing.Point(91, 199);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(152, 50);
            this.bttAdicionar.TabIndex = 2;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(317, 199);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(152, 50);
            this.bttCancelar.TabIndex = 3;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 31);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 20);
            this.txtNome.TabIndex = 0;
            // 
            // radioBttPratoQuente
            // 
            this.radioBttPratoQuente.AutoSize = true;
            this.radioBttPratoQuente.Location = new System.Drawing.Point(9, 29);
            this.radioBttPratoQuente.Name = "radioBttPratoQuente";
            this.radioBttPratoQuente.Size = new System.Drawing.Size(88, 17);
            this.radioBttPratoQuente.TabIndex = 0;
            this.radioBttPratoQuente.TabStop = true;
            this.radioBttPratoQuente.Text = "Prato Quente";
            this.radioBttPratoQuente.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Salada";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioBttFrutas
            // 
            this.radioBttFrutas.AutoSize = true;
            this.radioBttFrutas.Location = new System.Drawing.Point(9, 104);
            this.radioBttFrutas.Name = "radioBttFrutas";
            this.radioBttFrutas.Size = new System.Drawing.Size(54, 17);
            this.radioBttFrutas.TabIndex = 2;
            this.radioBttFrutas.TabStop = true;
            this.radioBttFrutas.Text = "Frutas";
            this.radioBttFrutas.UseVisualStyleBackColor = true;
            // 
            // radioBttFrios
            // 
            this.radioBttFrios.AutoSize = true;
            this.radioBttFrios.Location = new System.Drawing.Point(128, 29);
            this.radioBttFrios.Name = "radioBttFrios";
            this.radioBttFrios.Size = new System.Drawing.Size(47, 17);
            this.radioBttFrios.TabIndex = 3;
            this.radioBttFrios.TabStop = true;
            this.radioBttFrios.Text = "Frios";
            this.radioBttFrios.UseVisualStyleBackColor = true;
            // 
            // radioBttBebida
            // 
            this.radioBttBebida.AutoSize = true;
            this.radioBttBebida.Location = new System.Drawing.Point(128, 65);
            this.radioBttBebida.Name = "radioBttBebida";
            this.radioBttBebida.Size = new System.Drawing.Size(58, 17);
            this.radioBttBebida.TabIndex = 4;
            this.radioBttBebida.TabStop = true;
            this.radioBttBebida.Text = "Bebida";
            this.radioBttBebida.UseVisualStyleBackColor = true;
            // 
            // radioBttServicos
            // 
            this.radioBttServicos.AutoSize = true;
            this.radioBttServicos.Location = new System.Drawing.Point(128, 104);
            this.radioBttServicos.Name = "radioBttServicos";
            this.radioBttServicos.Size = new System.Drawing.Size(66, 17);
            this.radioBttServicos.TabIndex = 5;
            this.radioBttServicos.TabStop = true;
            this.radioBttServicos.Text = "Serviços";
            this.radioBttServicos.UseVisualStyleBackColor = true;
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.txtCodigo);
            this.gbInformacoes.Controls.Add(this.lbCodigo);
            this.gbInformacoes.Controls.Add(this.txtValorPorCabeca);
            this.gbInformacoes.Controls.Add(this.lbValorPorCabeca);
            this.gbInformacoes.Controls.Add(this.txtNome);
            this.gbInformacoes.Controls.Add(this.lbNome);
            this.gbInformacoes.Location = new System.Drawing.Point(226, 12);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(322, 181);
            this.gbInformacoes.TabIndex = 1;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações";
            // 
            // lbValorPorCabeca
            // 
            this.lbValorPorCabeca.AutoSize = true;
            this.lbValorPorCabeca.Location = new System.Drawing.Point(6, 106);
            this.lbValorPorCabeca.Name = "lbValorPorCabeca";
            this.lbValorPorCabeca.Size = new System.Drawing.Size(91, 13);
            this.lbValorPorCabeca.TabIndex = 4;
            this.lbValorPorCabeca.Text = "Valor por cabeça:";
            // 
            // txtValorPorCabeca
            // 
            this.txtValorPorCabeca.Location = new System.Drawing.Point(103, 103);
            this.txtValorPorCabeca.Name = "txtValorPorCabeca";
            this.txtValorPorCabeca.Size = new System.Drawing.Size(100, 20);
            this.txtValorPorCabeca.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 67);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(43, 13);
            this.lbCodigo.TabIndex = 6;
            this.lbCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // FormCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAdicionar);
            this.Controls.Add(this.gbAdicionarItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroItem";
            this.Text = "FormCadastroItem";
            this.gbAdicionarItem.ResumeLayout(false);
            this.gbAdicionarItem.PerformLayout();
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdicionarItem;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton radioBttPratoQuente;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioBttFrutas;
        private System.Windows.Forms.RadioButton radioBttFrios;
        private System.Windows.Forms.RadioButton radioBttServicos;
        private System.Windows.Forms.RadioButton radioBttBebida;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.TextBox txtValorPorCabeca;
        private System.Windows.Forms.Label lbValorPorCabeca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
    }
}