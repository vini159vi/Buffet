namespace Buffet.CV
{
    partial class FormFisico
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
            this.gbFisico = new System.Windows.Forms.GroupBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbEstadoRepresentante = new System.Windows.Forms.Label();
            this.lbBairroRepresentante = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbCidadeRepresentante = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.lbCEPRepresentante = new System.Windows.Forms.Label();
            this.lbRuaRepresentante = new System.Windows.Forms.Label();
            this.lbNumeroRepresentante = new System.Windows.Forms.Label();
            this.lbCPFRepresentante = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.lbNacionalidade = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.lbProfissao = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeRepresentante = new System.Windows.Forms.Label();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.gbFisico.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFisico
            // 
            this.gbFisico.Controls.Add(this.lblCel);
            this.gbFisico.Controls.Add(this.txtEstado);
            this.gbFisico.Controls.Add(this.txtBairro);
            this.gbFisico.Controls.Add(this.txtTelefone);
            this.gbFisico.Controls.Add(this.txtCelular);
            this.gbFisico.Controls.Add(this.lbEstadoRepresentante);
            this.gbFisico.Controls.Add(this.lbBairroRepresentante);
            this.gbFisico.Controls.Add(this.lbTelefone);
            this.gbFisico.Controls.Add(this.txtCidade);
            this.gbFisico.Controls.Add(this.lbCidadeRepresentante);
            this.gbFisico.Controls.Add(this.txtRua);
            this.gbFisico.Controls.Add(this.txtEstadoCivil);
            this.gbFisico.Controls.Add(this.lbEstadoCivil);
            this.gbFisico.Controls.Add(this.txtCEP);
            this.gbFisico.Controls.Add(this.txtNumero);
            this.gbFisico.Controls.Add(this.lbCEPRepresentante);
            this.gbFisico.Controls.Add(this.lbRuaRepresentante);
            this.gbFisico.Controls.Add(this.lbNumeroRepresentante);
            this.gbFisico.Controls.Add(this.lbCPFRepresentante);
            this.gbFisico.Controls.Add(this.txtCPF);
            this.gbFisico.Controls.Add(this.txtNacionalidade);
            this.gbFisico.Controls.Add(this.lbNacionalidade);
            this.gbFisico.Controls.Add(this.txtProfissao);
            this.gbFisico.Controls.Add(this.lbProfissao);
            this.gbFisico.Controls.Add(this.txtRG);
            this.gbFisico.Controls.Add(this.lbRG);
            this.gbFisico.Controls.Add(this.txtNome);
            this.gbFisico.Controls.Add(this.lbNomeRepresentante);
            this.gbFisico.Location = new System.Drawing.Point(10, 12);
            this.gbFisico.Name = "gbFisico";
            this.gbFisico.Size = new System.Drawing.Size(634, 162);
            this.gbFisico.TabIndex = 0;
            this.gbFisico.TabStop = false;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(460, 78);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(28, 13);
            this.lblCel.TabIndex = 4;
            this.lblCel.Text = "Cel.:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(508, 127);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(120, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(503, 101);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(126, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(351, 75);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(495, 75);
            this.txtCelular.Mask = "(99) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(133, 20);
            this.txtCelular.TabIndex = 7;
            // 
            // lbEstadoRepresentante
            // 
            this.lbEstadoRepresentante.AutoSize = true;
            this.lbEstadoRepresentante.Location = new System.Drawing.Point(459, 130);
            this.lbEstadoRepresentante.Name = "lbEstadoRepresentante";
            this.lbEstadoRepresentante.Size = new System.Drawing.Size(43, 13);
            this.lbEstadoRepresentante.TabIndex = 20;
            this.lbEstadoRepresentante.Text = "Estado:";
            // 
            // lbBairroRepresentante
            // 
            this.lbBairroRepresentante.AutoSize = true;
            this.lbBairroRepresentante.Location = new System.Drawing.Point(460, 104);
            this.lbBairroRepresentante.Name = "lbBairroRepresentante";
            this.lbBairroRepresentante.Size = new System.Drawing.Size(37, 13);
            this.lbBairroRepresentante.TabIndex = 18;
            this.lbBairroRepresentante.Text = "Bairro:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(317, 78);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(28, 13);
            this.lbTelefone.TabIndex = 21;
            this.lbTelefone.Text = "Tel.:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(194, 127);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(259, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // lbCidadeRepresentante
            // 
            this.lbCidadeRepresentante.AutoSize = true;
            this.lbCidadeRepresentante.Location = new System.Drawing.Point(145, 130);
            this.lbCidadeRepresentante.Name = "lbCidadeRepresentante";
            this.lbCidadeRepresentante.Size = new System.Drawing.Size(43, 13);
            this.lbCidadeRepresentante.TabIndex = 19;
            this.lbCidadeRepresentante.Text = "Cidade:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(42, 101);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(339, 20);
            this.txtRua.TabIndex = 8;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(77, 75);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(234, 20);
            this.txtEstadoCivil.TabIndex = 5;
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(6, 78);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lbEstadoCivil.TabIndex = 8;
            this.lbEstadoCivil.Text = "Estado Civil:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(43, 127);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(96, 20);
            this.txtCEP.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(416, 101);
            this.txtNumero.Mask = "0000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PromptChar = ' ';
            this.txtNumero.Size = new System.Drawing.Size(38, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // lbCEPRepresentante
            // 
            this.lbCEPRepresentante.AutoSize = true;
            this.lbCEPRepresentante.Location = new System.Drawing.Point(6, 130);
            this.lbCEPRepresentante.Name = "lbCEPRepresentante";
            this.lbCEPRepresentante.Size = new System.Drawing.Size(31, 13);
            this.lbCEPRepresentante.TabIndex = 18;
            this.lbCEPRepresentante.Text = "CEP:";
            // 
            // lbRuaRepresentante
            // 
            this.lbRuaRepresentante.AutoSize = true;
            this.lbRuaRepresentante.Location = new System.Drawing.Point(6, 104);
            this.lbRuaRepresentante.Name = "lbRuaRepresentante";
            this.lbRuaRepresentante.Size = new System.Drawing.Size(30, 13);
            this.lbRuaRepresentante.TabIndex = 15;
            this.lbRuaRepresentante.Text = "Rua:";
            // 
            // lbNumeroRepresentante
            // 
            this.lbNumeroRepresentante.AutoSize = true;
            this.lbNumeroRepresentante.Location = new System.Drawing.Point(388, 104);
            this.lbNumeroRepresentante.Name = "lbNumeroRepresentante";
            this.lbNumeroRepresentante.Size = new System.Drawing.Size(22, 13);
            this.lbNumeroRepresentante.TabIndex = 17;
            this.lbNumeroRepresentante.Text = "Nº:";
            // 
            // lbCPFRepresentante
            // 
            this.lbCPFRepresentante.AutoSize = true;
            this.lbCPFRepresentante.Location = new System.Drawing.Point(317, 26);
            this.lbCPFRepresentante.Name = "lbCPFRepresentante";
            this.lbCPFRepresentante.Size = new System.Drawing.Size(30, 13);
            this.lbCPFRepresentante.TabIndex = 11;
            this.lbCPFRepresentante.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(353, 23);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(401, 49);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(227, 20);
            this.txtNacionalidade.TabIndex = 4;
            // 
            // lbNacionalidade
            // 
            this.lbNacionalidade.AutoSize = true;
            this.lbNacionalidade.Location = new System.Drawing.Point(317, 52);
            this.lbNacionalidade.Name = "lbNacionalidade";
            this.lbNacionalidade.Size = new System.Drawing.Size(78, 13);
            this.lbNacionalidade.TabIndex = 6;
            this.lbNacionalidade.Text = "Nacionalidade:";
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(65, 49);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(246, 20);
            this.txtProfissao.TabIndex = 3;
            // 
            // lbProfissao
            // 
            this.lbProfissao.AutoSize = true;
            this.lbProfissao.Location = new System.Drawing.Point(6, 52);
            this.lbProfissao.Name = "lbProfissao";
            this.lbProfissao.Size = new System.Drawing.Size(53, 13);
            this.lbProfissao.TabIndex = 4;
            this.lbProfissao.Text = "Profissão:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(491, 23);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(137, 20);
            this.txtRG.TabIndex = 2;
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(459, 26);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(26, 13);
            this.lbRG.TabIndex = 2;
            this.lbRG.Text = "RG:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lbNomeRepresentante
            // 
            this.lbNomeRepresentante.AutoSize = true;
            this.lbNomeRepresentante.Location = new System.Drawing.Point(6, 26);
            this.lbNomeRepresentante.Name = "lbNomeRepresentante";
            this.lbNomeRepresentante.Size = new System.Drawing.Size(38, 13);
            this.lbNomeRepresentante.TabIndex = 0;
            this.lbNomeRepresentante.Text = "Nome:";
            // 
            // gbBotoes
            // 
            this.gbBotoes.Controls.Add(this.bttAdicionar);
            this.gbBotoes.Controls.Add(this.bttCancelar);
            this.gbBotoes.Location = new System.Drawing.Point(10, 180);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(634, 74);
            this.gbBotoes.TabIndex = 1;
            this.gbBotoes.TabStop = false;
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.Location = new System.Drawing.Point(149, 19);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(125, 43);
            this.bttAdicionar.TabIndex = 0;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(377, 19);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(125, 43);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // FormFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 262);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.gbFisico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fisico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFisico_FormClosing);
            this.gbFisico.ResumeLayout(false);
            this.gbFisico.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFisico;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lbEstadoRepresentante;
        private System.Windows.Forms.Label lbBairroRepresentante;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbCidadeRepresentante;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Label lbCEPRepresentante;
        private System.Windows.Forms.Label lbRuaRepresentante;
        private System.Windows.Forms.Label lbNumeroRepresentante;
        private System.Windows.Forms.Label lbCPFRepresentante;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label lbNacionalidade;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label lbProfissao;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeRepresentante;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Button bttCancelar;
    }
}