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
            this.radioBttServicos = new System.Windows.Forms.RadioButton();
            this.radioBttBebida = new System.Windows.Forms.RadioButton();
            this.radioBttFrios = new System.Windows.Forms.RadioButton();
            this.radioBttFrutas = new System.Windows.Forms.RadioButton();
            this.radioBttSalada = new System.Windows.Forms.RadioButton();
            this.radioBttPratoQuente = new System.Windows.Forms.RadioButton();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtValorPorCabeca = new System.Windows.Forms.TextBox();
            this.lbValorPorCabeca = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.gbAdicionarItem.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdicionarItem
            // 
            this.gbAdicionarItem.Controls.Add(this.radioBttServicos);
            this.gbAdicionarItem.Controls.Add(this.radioBttBebida);
            this.gbAdicionarItem.Controls.Add(this.radioBttFrios);
            this.gbAdicionarItem.Controls.Add(this.radioBttFrutas);
            this.gbAdicionarItem.Controls.Add(this.radioBttSalada);
            this.gbAdicionarItem.Controls.Add(this.radioBttPratoQuente);
            this.gbAdicionarItem.Location = new System.Drawing.Point(12, 12);
            this.gbAdicionarItem.Name = "gbAdicionarItem";
            this.gbAdicionarItem.Size = new System.Drawing.Size(208, 540);
            this.gbAdicionarItem.TabIndex = 0;
            this.gbAdicionarItem.TabStop = false;
            this.gbAdicionarItem.Text = "Tipo";
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
            this.radioBttServicos.CheckedChanged += new System.EventHandler(this.radioBttServicos_CheckedChanged);
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
            this.radioBttBebida.CheckedChanged += new System.EventHandler(this.radioBttBebida_CheckedChanged);
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
            this.radioBttFrios.CheckedChanged += new System.EventHandler(this.radioBttFrios_CheckedChanged);
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
            this.radioBttFrutas.CheckedChanged += new System.EventHandler(this.radioBttFrutas_CheckedChanged);
            // 
            // radioBttSalada
            // 
            this.radioBttSalada.AutoSize = true;
            this.radioBttSalada.Location = new System.Drawing.Point(9, 65);
            this.radioBttSalada.Name = "radioBttSalada";
            this.radioBttSalada.Size = new System.Drawing.Size(58, 17);
            this.radioBttSalada.TabIndex = 1;
            this.radioBttSalada.TabStop = true;
            this.radioBttSalada.Text = "Salada";
            this.radioBttSalada.UseVisualStyleBackColor = true;
            this.radioBttSalada.CheckedChanged += new System.EventHandler(this.radioBttSalada_CheckedChanged);
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
            this.radioBttPratoQuente.CheckedChanged += new System.EventHandler(this.radioBttPratoQuente_CheckedChanged);
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Location = new System.Drawing.Point(146, 30);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(152, 50);
            this.bttAdicionar.TabIndex = 0;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelar.Location = new System.Drawing.Point(576, 30);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(152, 50);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
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
            this.txtNome.Size = new System.Drawing.Size(566, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.txtValorPorCabeca);
            this.gbInformacoes.Controls.Add(this.lbValorPorCabeca);
            this.gbInformacoes.Controls.Add(this.txtNome);
            this.gbInformacoes.Controls.Add(this.lbNome);
            this.gbInformacoes.Location = new System.Drawing.Point(226, 12);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(622, 540);
            this.gbInformacoes.TabIndex = 1;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações";
            // 
            // txtValorPorCabeca
            // 
            this.txtValorPorCabeca.Location = new System.Drawing.Point(103, 62);
            this.txtValorPorCabeca.Name = "txtValorPorCabeca";
            this.txtValorPorCabeca.Size = new System.Drawing.Size(513, 20);
            this.txtValorPorCabeca.TabIndex = 2;
            this.txtValorPorCabeca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // lbValorPorCabeca
            // 
            this.lbValorPorCabeca.AutoSize = true;
            this.lbValorPorCabeca.Location = new System.Drawing.Point(6, 65);
            this.lbValorPorCabeca.Name = "lbValorPorCabeca";
            this.lbValorPorCabeca.Size = new System.Drawing.Size(91, 13);
            this.lbValorPorCabeca.TabIndex = 4;
            this.lbValorPorCabeca.Text = "Valor por cabeça:";
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.bttAdicionar);
            this.panelBotoes.Controls.Add(this.bttCancelar);
            this.panelBotoes.Location = new System.Drawing.Point(4, 558);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(844, 120);
            this.panelBotoes.TabIndex = 2;
            // 
            // FormCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 690);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.gbAdicionarItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroItem";
            this.Text = "FormCadastroItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.VisibleChanged += new System.EventHandler(this.FormCadastroItem_VisibleChanged);
            this.gbAdicionarItem.ResumeLayout(false);
            this.gbAdicionarItem.PerformLayout();
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdicionarItem;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton radioBttPratoQuente;
        private System.Windows.Forms.RadioButton radioBttSalada;
        private System.Windows.Forms.RadioButton radioBttFrutas;
        private System.Windows.Forms.RadioButton radioBttFrios;
        private System.Windows.Forms.RadioButton radioBttServicos;
        private System.Windows.Forms.RadioButton radioBttBebida;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.TextBox txtValorPorCabeca;
        private System.Windows.Forms.Label lbValorPorCabeca;
        private System.Windows.Forms.Panel panelBotoes;
    }
}