namespace Buffet.CV
{
    partial class FormJuridico
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
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.txtEstadoEmpresa = new System.Windows.Forms.TextBox();
            this.lbEstadoEmpresa = new System.Windows.Forms.Label();
            this.txtCidadeEmpresa = new System.Windows.Forms.TextBox();
            this.lbCidadeEmpresa = new System.Windows.Forms.Label();
            this.txtCEPEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.lbCEPEmpresa = new System.Windows.Forms.Label();
            this.txtBairroEmpresa = new System.Windows.Forms.TextBox();
            this.lbBairroEmpresa = new System.Windows.Forms.Label();
            this.txtNumeroEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.lbNumeroEmpresa = new System.Windows.Forms.Label();
            this.txtRuaEmpresa = new System.Windows.Forms.TextBox();
            this.lbRuaEmpresa = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lbNomeEmpresa = new System.Windows.Forms.Label();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.gbEmpresa.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbEmpresa.Controls.Add(this.txtEstadoEmpresa);
            this.gbEmpresa.Controls.Add(this.lbEstadoEmpresa);
            this.gbEmpresa.Controls.Add(this.txtCidadeEmpresa);
            this.gbEmpresa.Controls.Add(this.lbCidadeEmpresa);
            this.gbEmpresa.Controls.Add(this.txtCEPEmpresa);
            this.gbEmpresa.Controls.Add(this.lbCEPEmpresa);
            this.gbEmpresa.Controls.Add(this.txtBairroEmpresa);
            this.gbEmpresa.Controls.Add(this.lbBairroEmpresa);
            this.gbEmpresa.Controls.Add(this.txtNumeroEmpresa);
            this.gbEmpresa.Controls.Add(this.lbNumeroEmpresa);
            this.gbEmpresa.Controls.Add(this.txtRuaEmpresa);
            this.gbEmpresa.Controls.Add(this.lbRuaEmpresa);
            this.gbEmpresa.Controls.Add(this.txtCNPJ);
            this.gbEmpresa.Controls.Add(this.lbCNPJ);
            this.gbEmpresa.Controls.Add(this.txtNomeEmpresa);
            this.gbEmpresa.Controls.Add(this.lbNomeEmpresa);
            this.gbEmpresa.Location = new System.Drawing.Point(106, 12);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(634, 112);
            this.gbEmpresa.TabIndex = 0;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Empresa";
            // 
            // txtEstadoEmpresa
            // 
            this.txtEstadoEmpresa.Location = new System.Drawing.Point(508, 76);
            this.txtEstadoEmpresa.Name = "txtEstadoEmpresa";
            this.txtEstadoEmpresa.Size = new System.Drawing.Size(120, 20);
            this.txtEstadoEmpresa.TabIndex = 7;
            this.txtEstadoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // lbEstadoEmpresa
            // 
            this.lbEstadoEmpresa.AutoSize = true;
            this.lbEstadoEmpresa.Location = new System.Drawing.Point(459, 79);
            this.lbEstadoEmpresa.Name = "lbEstadoEmpresa";
            this.lbEstadoEmpresa.Size = new System.Drawing.Size(43, 13);
            this.lbEstadoEmpresa.TabIndex = 14;
            this.lbEstadoEmpresa.Text = "Estado:";
            // 
            // txtCidadeEmpresa
            // 
            this.txtCidadeEmpresa.Location = new System.Drawing.Point(194, 76);
            this.txtCidadeEmpresa.Name = "txtCidadeEmpresa";
            this.txtCidadeEmpresa.Size = new System.Drawing.Size(259, 20);
            this.txtCidadeEmpresa.TabIndex = 6;
            this.txtCidadeEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // lbCidadeEmpresa
            // 
            this.lbCidadeEmpresa.AutoSize = true;
            this.lbCidadeEmpresa.Location = new System.Drawing.Point(145, 79);
            this.lbCidadeEmpresa.Name = "lbCidadeEmpresa";
            this.lbCidadeEmpresa.Size = new System.Drawing.Size(43, 13);
            this.lbCidadeEmpresa.TabIndex = 12;
            this.lbCidadeEmpresa.Text = "Cidade:";
            this.lbCidadeEmpresa.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCEPEmpresa
            // 
            this.txtCEPEmpresa.Location = new System.Drawing.Point(43, 76);
            this.txtCEPEmpresa.Mask = "00000-000";
            this.txtCEPEmpresa.Name = "txtCEPEmpresa";
            this.txtCEPEmpresa.Size = new System.Drawing.Size(96, 20);
            this.txtCEPEmpresa.TabIndex = 5;
            this.txtCEPEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // lbCEPEmpresa
            // 
            this.lbCEPEmpresa.AutoSize = true;
            this.lbCEPEmpresa.Location = new System.Drawing.Point(6, 79);
            this.lbCEPEmpresa.Name = "lbCEPEmpresa";
            this.lbCEPEmpresa.Size = new System.Drawing.Size(31, 13);
            this.lbCEPEmpresa.TabIndex = 10;
            this.lbCEPEmpresa.Text = "CEP:";
            // 
            // txtBairroEmpresa
            // 
            this.txtBairroEmpresa.Location = new System.Drawing.Point(502, 50);
            this.txtBairroEmpresa.Name = "txtBairroEmpresa";
            this.txtBairroEmpresa.Size = new System.Drawing.Size(126, 20);
            this.txtBairroEmpresa.TabIndex = 4;
            this.txtBairroEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // lbBairroEmpresa
            // 
            this.lbBairroEmpresa.AutoSize = true;
            this.lbBairroEmpresa.Location = new System.Drawing.Point(459, 53);
            this.lbBairroEmpresa.Name = "lbBairroEmpresa";
            this.lbBairroEmpresa.Size = new System.Drawing.Size(37, 13);
            this.lbBairroEmpresa.TabIndex = 8;
            this.lbBairroEmpresa.Text = "Bairro:";
            // 
            // txtNumeroEmpresa
            // 
            this.txtNumeroEmpresa.Location = new System.Drawing.Point(415, 50);
            this.txtNumeroEmpresa.Mask = "0000";
            this.txtNumeroEmpresa.Name = "txtNumeroEmpresa";
            this.txtNumeroEmpresa.PromptChar = ' ';
            this.txtNumeroEmpresa.Size = new System.Drawing.Size(38, 20);
            this.txtNumeroEmpresa.TabIndex = 3;
            this.txtNumeroEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // lbNumeroEmpresa
            // 
            this.lbNumeroEmpresa.AutoSize = true;
            this.lbNumeroEmpresa.Location = new System.Drawing.Point(387, 53);
            this.lbNumeroEmpresa.Name = "lbNumeroEmpresa";
            this.lbNumeroEmpresa.Size = new System.Drawing.Size(22, 13);
            this.lbNumeroEmpresa.TabIndex = 6;
            this.lbNumeroEmpresa.Text = "Nº:";
            this.lbNumeroEmpresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRuaEmpresa
            // 
            this.txtRuaEmpresa.Location = new System.Drawing.Point(42, 50);
            this.txtRuaEmpresa.Name = "txtRuaEmpresa";
            this.txtRuaEmpresa.Size = new System.Drawing.Size(339, 20);
            this.txtRuaEmpresa.TabIndex = 2;
            this.txtRuaEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // lbRuaEmpresa
            // 
            this.lbRuaEmpresa.AutoSize = true;
            this.lbRuaEmpresa.Location = new System.Drawing.Point(6, 53);
            this.lbRuaEmpresa.Name = "lbRuaEmpresa";
            this.lbRuaEmpresa.Size = new System.Drawing.Size(30, 13);
            this.lbRuaEmpresa.TabIndex = 4;
            this.lbRuaEmpresa.Text = "Rua:";
            this.lbRuaEmpresa.Click += new System.EventHandler(this.lbRua_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(502, 24);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(126, 20);
            this.txtCNPJ.TabIndex = 1;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(459, 27);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lbCNPJ.TabIndex = 2;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(109, 24);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(344, 20);
            this.txtNomeEmpresa.TabIndex = 0;
            this.txtNomeEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // lbNomeEmpresa
            // 
            this.lbNomeEmpresa.AutoSize = true;
            this.lbNomeEmpresa.Location = new System.Drawing.Point(6, 27);
            this.lbNomeEmpresa.Name = "lbNomeEmpresa";
            this.lbNomeEmpresa.Size = new System.Drawing.Size(97, 13);
            this.lbNomeEmpresa.TabIndex = 0;
            this.lbNomeEmpresa.Text = "Nome da Empresa:";
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Location = new System.Drawing.Point(149, 19);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(125, 43);
            this.bttAdicionar.TabIndex = 2;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelar.Location = new System.Drawing.Point(377, 19);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(125, 43);
            this.bttCancelar.TabIndex = 3;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttRemove_Click);
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbBotoes.Controls.Add(this.bttAdicionar);
            this.gbBotoes.Controls.Add(this.bttCancelar);
            this.gbBotoes.Location = new System.Drawing.Point(106, 130);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(634, 74);
            this.gbBotoes.TabIndex = 8;
            this.gbBotoes.TabStop = false;
            // 
            // FormJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 690);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.gbEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormJuridico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juridico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJuridico_FormClosing);
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.Label lbNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lbRuaEmpresa;
        private System.Windows.Forms.Label lbNumeroEmpresa;
        private System.Windows.Forms.TextBox txtRuaEmpresa;
        private System.Windows.Forms.MaskedTextBox txtNumeroEmpresa;
        private System.Windows.Forms.TextBox txtBairroEmpresa;
        private System.Windows.Forms.Label lbBairroEmpresa;
        private System.Windows.Forms.MaskedTextBox txtCEPEmpresa;
        private System.Windows.Forms.Label lbCEPEmpresa;
        private System.Windows.Forms.Label lbCidadeEmpresa;
        private System.Windows.Forms.TextBox txtEstadoEmpresa;
        private System.Windows.Forms.Label lbEstadoEmpresa;
        private System.Windows.Forms.TextBox txtCidadeEmpresa;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.GroupBox gbBotoes;
    }
}