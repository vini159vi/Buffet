using System;
using System.Windows.Forms;

namespace Buffet
{
    partial class FormCadastroCliente
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(6, 48);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 13);
            this.lbCPF.TabIndex = 1;
            this.lbCPF.Text = "CPF:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(6, 137);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbEndereco.TabIndex = 2;
            this.lbEndereco.Text = "Endereço:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(6, 77);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(28, 13);
            this.lbTelefone.TabIndex = 4;
            this.lbTelefone.Text = "Tel.:";
            this.lbTelefone.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(42, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(271, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(68, 132);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(177, 20);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // dateNascimento
            // 
            this.dateNascimento.CustomFormat = "dd/mm/yyyy";
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNascimento.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dateNascimento.Location = new System.Drawing.Point(117, 101);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateNascimento.Size = new System.Drawing.Size(96, 20);
            this.dateNascimento.TabIndex = 4;
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Location = new System.Drawing.Point(6, 107);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(105, 13);
            this.lbDataNasc.TabIndex = 11;
            this.lbDataNasc.Text = "Data de nascimento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblCel);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.dateNascimento);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lbEndereco);
            this.groupBox1.Controls.Add(this.lbDataNasc);
            this.groupBox1.Controls.Add(this.lbTelefone);
            this.groupBox1.Controls.Add(this.lbCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(42, 45);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(279, 132);
            this.txtNumero.Mask = "0000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PromptChar = ' ';
            this.txtNumero.Size = new System.Drawing.Size(36, 20);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(42, 74);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(251, 135);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(22, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Nº:";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(181, 77);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(28, 13);
            this.lblCel.TabIndex = 3;
            this.lblCel.Text = "Cel.:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(215, 74);
            this.txtCelular.Mask = "(99) 90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 3;
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.Location = new System.Drawing.Point(19, 171);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(121, 40);
            this.bttAdicionar.TabIndex = 1;
            this.bttAdicionar.Text = "Adicionar";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(195, 171);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(121, 40);
            this.bttCancelar.TabIndex = 2;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 221);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAdicionar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroCliente";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.Label lbDataNasc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}