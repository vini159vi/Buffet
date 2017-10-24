﻿namespace Buffet.CV
{
    partial class FormContratoJuridico
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
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.bttGerarContrato = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.gbContratado = new System.Windows.Forms.GroupBox();
            this.dtPagamento = new System.Windows.Forms.DateTimePicker();
            this.lbDataPagamento = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbQuantidadeDeCopeiros = new System.Windows.Forms.Label();
            this.txtHorasAntecedencia = new System.Windows.Forms.TextBox();
            this.dtHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.lbHoraAntecedencia = new System.Windows.Forms.Label();
            this.lbHoraChegada = new System.Windows.Forms.Label();
            this.txtCopeiros = new System.Windows.Forms.TextBox();
            this.txtGarcom = new System.Windows.Forms.TextBox();
            this.lbQuantidadeDeGarcoes = new System.Windows.Forms.Label();
            this.dtHoraTerminoContratado = new System.Windows.Forms.DateTimePicker();
            this.lbHoraTerminoContratado = new System.Windows.Forms.Label();
            this.dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lbHoraInicioContratado = new System.Windows.Forms.Label();
            this.gbEvento = new System.Windows.Forms.GroupBox();
            this.dtHoraTermino = new System.Windows.Forms.DateTimePicker();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.lbHoraTermino = new System.Windows.Forms.Label();
            this.lbCapacidade = new System.Windows.Forms.Label();
            this.txtConvidados = new System.Windows.Forms.TextBox();
            this.lbConvidados = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.dtHoraEvento = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.dtDataEvento = new System.Windows.Forms.DateTimePicker();
            this.gbDevolucao = new System.Windows.Forms.GroupBox();
            this.dtHoraDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtDiaDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lbHoraDevolucao = new System.Windows.Forms.Label();
            this.lbDiaDevolucao = new System.Windows.Forms.Label();
            this.gbPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.cbRepresentante = new System.Windows.Forms.ComboBox();
            this.lbRepresentante = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.gbBotoes.SuspendLayout();
            this.gbContratado.SuspendLayout();
            this.gbEvento.SuspendLayout();
            this.gbDevolucao.SuspendLayout();
            this.gbPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBotoes
            // 
            this.gbBotoes.Controls.Add(this.bttGerarContrato);
            this.gbBotoes.Controls.Add(this.bttCancelar);
            this.gbBotoes.Location = new System.Drawing.Point(12, 333);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(845, 74);
            this.gbBotoes.TabIndex = 4;
            this.gbBotoes.TabStop = false;
            // 
            // bttGerarContrato
            // 
            this.bttGerarContrato.Location = new System.Drawing.Point(149, 19);
            this.bttGerarContrato.Name = "bttGerarContrato";
            this.bttGerarContrato.Size = new System.Drawing.Size(125, 43);
            this.bttGerarContrato.TabIndex = 0;
            this.bttGerarContrato.Text = "Gerar Contrato";
            this.bttGerarContrato.UseVisualStyleBackColor = true;
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(574, 19);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(125, 43);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // gbContratado
            // 
            this.gbContratado.Controls.Add(this.dtPagamento);
            this.gbContratado.Controls.Add(this.lbDataPagamento);
            this.gbContratado.Controls.Add(this.txtPreco);
            this.gbContratado.Controls.Add(this.lbPreco);
            this.gbContratado.Controls.Add(this.lbQuantidadeDeCopeiros);
            this.gbContratado.Controls.Add(this.txtHorasAntecedencia);
            this.gbContratado.Controls.Add(this.dtHoraChegada);
            this.gbContratado.Controls.Add(this.lbHoraAntecedencia);
            this.gbContratado.Controls.Add(this.lbHoraChegada);
            this.gbContratado.Controls.Add(this.txtCopeiros);
            this.gbContratado.Controls.Add(this.txtGarcom);
            this.gbContratado.Controls.Add(this.lbQuantidadeDeGarcoes);
            this.gbContratado.Controls.Add(this.dtHoraTerminoContratado);
            this.gbContratado.Controls.Add(this.lbHoraTerminoContratado);
            this.gbContratado.Controls.Add(this.dtHoraInicio);
            this.gbContratado.Controls.Add(this.lbHoraInicioContratado);
            this.gbContratado.Location = new System.Drawing.Point(12, 173);
            this.gbContratado.Name = "gbContratado";
            this.gbContratado.Size = new System.Drawing.Size(845, 85);
            this.gbContratado.TabIndex = 2;
            this.gbContratado.TabStop = false;
            this.gbContratado.Text = "Contratado";
            // 
            // dtPagamento
            // 
            this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPagamento.Location = new System.Drawing.Point(737, 45);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Size = new System.Drawing.Size(95, 20);
            this.dtPagamento.TabIndex = 7;
            // 
            // lbDataPagamento
            // 
            this.lbDataPagamento.AutoSize = true;
            this.lbDataPagamento.Location = new System.Drawing.Point(656, 51);
            this.lbDataPagamento.Name = "lbDataPagamento";
            this.lbDataPagamento.Size = new System.Drawing.Size(75, 13);
            this.lbDataPagamento.TabIndex = 16;
            this.lbDataPagamento.Text = "Data de pgto.:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(756, 20);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(76, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(656, 23);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(94, 13);
            this.lbPreco.TabIndex = 14;
            this.lbPreco.Text = "Preço a pagar: R$";
            // 
            // lbQuantidadeDeCopeiros
            // 
            this.lbQuantidadeDeCopeiros.AutoSize = true;
            this.lbQuantidadeDeCopeiros.Location = new System.Drawing.Point(445, 51);
            this.lbQuantidadeDeCopeiros.Name = "lbQuantidadeDeCopeiros";
            this.lbQuantidadeDeCopeiros.Size = new System.Drawing.Size(123, 13);
            this.lbQuantidadeDeCopeiros.TabIndex = 13;
            this.lbQuantidadeDeCopeiros.Text = "Quantidade de copeiros:";
            // 
            // txtHorasAntecedencia
            // 
            this.txtHorasAntecedencia.Location = new System.Drawing.Point(133, 46);
            this.txtHorasAntecedencia.Name = "txtHorasAntecedencia";
            this.txtHorasAntecedencia.Size = new System.Drawing.Size(53, 20);
            this.txtHorasAntecedencia.TabIndex = 4;
            // 
            // dtHoraChegada
            // 
            this.dtHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraChegada.Location = new System.Drawing.Point(105, 20);
            this.dtHoraChegada.Name = "dtHoraChegada";
            this.dtHoraChegada.ShowUpDown = true;
            this.dtHoraChegada.Size = new System.Drawing.Size(81, 20);
            this.dtHoraChegada.TabIndex = 0;
            // 
            // lbHoraAntecedencia
            // 
            this.lbHoraAntecedencia.AutoSize = true;
            this.lbHoraAntecedencia.Location = new System.Drawing.Point(6, 49);
            this.lbHoraAntecedencia.Name = "lbHoraAntecedencia";
            this.lbHoraAntecedencia.Size = new System.Drawing.Size(121, 13);
            this.lbHoraAntecedencia.TabIndex = 10;
            this.lbHoraAntecedencia.Text = "Horas de antecedência:";
            // 
            // lbHoraChegada
            // 
            this.lbHoraChegada.AutoSize = true;
            this.lbHoraChegada.Location = new System.Drawing.Point(6, 26);
            this.lbHoraChegada.Name = "lbHoraChegada";
            this.lbHoraChegada.Size = new System.Drawing.Size(93, 13);
            this.lbHoraChegada.TabIndex = 9;
            this.lbHoraChegada.Text = "Hora de chegada:";
            // 
            // txtCopeiros
            // 
            this.txtCopeiros.Location = new System.Drawing.Point(574, 48);
            this.txtCopeiros.Name = "txtCopeiros";
            this.txtCopeiros.Size = new System.Drawing.Size(55, 20);
            this.txtCopeiros.TabIndex = 6;
            // 
            // txtGarcom
            // 
            this.txtGarcom.Location = new System.Drawing.Point(574, 20);
            this.txtGarcom.Name = "txtGarcom";
            this.txtGarcom.Size = new System.Drawing.Size(55, 20);
            this.txtGarcom.TabIndex = 2;
            // 
            // lbQuantidadeDeGarcoes
            // 
            this.lbQuantidadeDeGarcoes.AutoSize = true;
            this.lbQuantidadeDeGarcoes.Location = new System.Drawing.Point(445, 23);
            this.lbQuantidadeDeGarcoes.Name = "lbQuantidadeDeGarcoes";
            this.lbQuantidadeDeGarcoes.Size = new System.Drawing.Size(121, 13);
            this.lbQuantidadeDeGarcoes.TabIndex = 4;
            this.lbQuantidadeDeGarcoes.Text = "Quantidade de garçons:";
            // 
            // dtHoraTerminoContratado
            // 
            this.dtHoraTerminoContratado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraTerminoContratado.Location = new System.Drawing.Point(315, 45);
            this.dtHoraTerminoContratado.Name = "dtHoraTerminoContratado";
            this.dtHoraTerminoContratado.ShowUpDown = true;
            this.dtHoraTerminoContratado.Size = new System.Drawing.Size(81, 20);
            this.dtHoraTerminoContratado.TabIndex = 5;
            // 
            // lbHoraTerminoContratado
            // 
            this.lbHoraTerminoContratado.AutoSize = true;
            this.lbHoraTerminoContratado.Location = new System.Drawing.Point(209, 51);
            this.lbHoraTerminoContratado.Name = "lbHoraTerminoContratado";
            this.lbHoraTerminoContratado.Size = new System.Drawing.Size(100, 13);
            this.lbHoraTerminoContratado.TabIndex = 2;
            this.lbHoraTerminoContratado.Text = "Término do serviço:";
            // 
            // dtHoraInicio
            // 
            this.dtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraInicio.Location = new System.Drawing.Point(315, 19);
            this.dtHoraInicio.Name = "dtHoraInicio";
            this.dtHoraInicio.ShowUpDown = true;
            this.dtHoraInicio.Size = new System.Drawing.Size(81, 20);
            this.dtHoraInicio.TabIndex = 1;
            // 
            // lbHoraInicioContratado
            // 
            this.lbHoraInicioContratado.AutoSize = true;
            this.lbHoraInicioContratado.Location = new System.Drawing.Point(220, 25);
            this.lbHoraInicioContratado.Name = "lbHoraInicioContratado";
            this.lbHoraInicioContratado.Size = new System.Drawing.Size(89, 13);
            this.lbHoraInicioContratado.TabIndex = 0;
            this.lbHoraInicioContratado.Text = "Início do serviço:";
            // 
            // gbEvento
            // 
            this.gbEvento.Controls.Add(this.dtHoraTermino);
            this.gbEvento.Controls.Add(this.txtCapacidade);
            this.gbEvento.Controls.Add(this.lbHoraTermino);
            this.gbEvento.Controls.Add(this.lbCapacidade);
            this.gbEvento.Controls.Add(this.txtConvidados);
            this.gbEvento.Controls.Add(this.lbConvidados);
            this.gbEvento.Controls.Add(this.lbHora);
            this.gbEvento.Controls.Add(this.dtHoraEvento);
            this.gbEvento.Controls.Add(this.lbData);
            this.gbEvento.Controls.Add(this.dtDataEvento);
            this.gbEvento.Location = new System.Drawing.Point(12, 105);
            this.gbEvento.Name = "gbEvento";
            this.gbEvento.Size = new System.Drawing.Size(845, 62);
            this.gbEvento.TabIndex = 1;
            this.gbEvento.TabStop = false;
            this.gbEvento.Text = "Evento";
            // 
            // dtHoraTermino
            // 
            this.dtHoraTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraTermino.Location = new System.Drawing.Point(366, 21);
            this.dtHoraTermino.Name = "dtHoraTermino";
            this.dtHoraTermino.ShowUpDown = true;
            this.dtHoraTermino.Size = new System.Drawing.Size(80, 20);
            this.dtHoraTermino.TabIndex = 2;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(769, 21);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(63, 20);
            this.txtCapacidade.TabIndex = 4;
            // 
            // lbHoraTermino
            // 
            this.lbHoraTermino.AutoSize = true;
            this.lbHoraTermino.Location = new System.Drawing.Point(276, 27);
            this.lbHoraTermino.Name = "lbHoraTermino";
            this.lbHoraTermino.Size = new System.Drawing.Size(85, 13);
            this.lbHoraTermino.TabIndex = 6;
            this.lbHoraTermino.Text = "Hora do término:";
            // 
            // lbCapacidade
            // 
            this.lbCapacidade.AutoSize = true;
            this.lbCapacidade.Location = new System.Drawing.Point(619, 27);
            this.lbCapacidade.Name = "lbCapacidade";
            this.lbCapacidade.Size = new System.Drawing.Size(145, 13);
            this.lbCapacidade.TabIndex = 8;
            this.lbCapacidade.Text = "Capacidade máxima do local:";
            // 
            // txtConvidados
            // 
            this.txtConvidados.Location = new System.Drawing.Point(551, 21);
            this.txtConvidados.Name = "txtConvidados";
            this.txtConvidados.Size = new System.Drawing.Size(63, 20);
            this.txtConvidados.TabIndex = 3;
            // 
            // lbConvidados
            // 
            this.lbConvidados.AutoSize = true;
            this.lbConvidados.Location = new System.Drawing.Point(451, 27);
            this.lbConvidados.Name = "lbConvidados";
            this.lbConvidados.Size = new System.Drawing.Size(95, 13);
            this.lbConvidados.TabIndex = 4;
            this.lbConvidados.Text = "Nº de convidados:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(152, 27);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(33, 13);
            this.lbHora.TabIndex = 3;
            this.lbHora.Text = "Hora:";
            // 
            // dtHoraEvento
            // 
            this.dtHoraEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEvento.Location = new System.Drawing.Point(190, 21);
            this.dtHoraEvento.Name = "dtHoraEvento";
            this.dtHoraEvento.ShowUpDown = true;
            this.dtHoraEvento.Size = new System.Drawing.Size(81, 20);
            this.dtHoraEvento.TabIndex = 1;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(12, 27);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(33, 13);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data:";
            // 
            // dtDataEvento
            // 
            this.dtDataEvento.CustomFormat = "dd/MM/yyyy";
            this.dtDataEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataEvento.Location = new System.Drawing.Point(50, 21);
            this.dtDataEvento.Name = "dtDataEvento";
            this.dtDataEvento.Size = new System.Drawing.Size(97, 20);
            this.dtDataEvento.TabIndex = 0;
            // 
            // gbDevolucao
            // 
            this.gbDevolucao.Controls.Add(this.dtHoraDevolucao);
            this.gbDevolucao.Controls.Add(this.dtDiaDevolucao);
            this.gbDevolucao.Controls.Add(this.lbHoraDevolucao);
            this.gbDevolucao.Controls.Add(this.lbDiaDevolucao);
            this.gbDevolucao.Location = new System.Drawing.Point(12, 264);
            this.gbDevolucao.Name = "gbDevolucao";
            this.gbDevolucao.Size = new System.Drawing.Size(845, 60);
            this.gbDevolucao.TabIndex = 3;
            this.gbDevolucao.TabStop = false;
            this.gbDevolucao.Text = "Devolução";
            // 
            // dtHoraDevolucao
            // 
            this.dtHoraDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraDevolucao.Location = new System.Drawing.Point(190, 19);
            this.dtHoraDevolucao.Name = "dtHoraDevolucao";
            this.dtHoraDevolucao.ShowUpDown = true;
            this.dtHoraDevolucao.Size = new System.Drawing.Size(88, 20);
            this.dtHoraDevolucao.TabIndex = 1;
            // 
            // dtDiaDevolucao
            // 
            this.dtDiaDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiaDevolucao.Location = new System.Drawing.Point(38, 19);
            this.dtDiaDevolucao.Name = "dtDiaDevolucao";
            this.dtDiaDevolucao.Size = new System.Drawing.Size(95, 20);
            this.dtDiaDevolucao.TabIndex = 0;
            // 
            // lbHoraDevolucao
            // 
            this.lbHoraDevolucao.AutoSize = true;
            this.lbHoraDevolucao.Location = new System.Drawing.Point(151, 25);
            this.lbHoraDevolucao.Name = "lbHoraDevolucao";
            this.lbHoraDevolucao.Size = new System.Drawing.Size(33, 13);
            this.lbHoraDevolucao.TabIndex = 25;
            this.lbHoraDevolucao.Text = "Hora:";
            // 
            // lbDiaDevolucao
            // 
            this.lbDiaDevolucao.AutoSize = true;
            this.lbDiaDevolucao.Location = new System.Drawing.Point(6, 25);
            this.lbDiaDevolucao.Name = "lbDiaDevolucao";
            this.lbDiaDevolucao.Size = new System.Drawing.Size(26, 13);
            this.lbDiaDevolucao.TabIndex = 24;
            this.lbDiaDevolucao.Text = "Dia:";
            // 
            // gbPessoaJuridica
            // 
            this.gbPessoaJuridica.Controls.Add(this.cbRepresentante);
            this.gbPessoaJuridica.Controls.Add(this.lbRepresentante);
            this.gbPessoaJuridica.Controls.Add(this.cbEmpresa);
            this.gbPessoaJuridica.Controls.Add(this.lbEmpresa);
            this.gbPessoaJuridica.Location = new System.Drawing.Point(12, 12);
            this.gbPessoaJuridica.Name = "gbPessoaJuridica";
            this.gbPessoaJuridica.Size = new System.Drawing.Size(845, 87);
            this.gbPessoaJuridica.TabIndex = 0;
            this.gbPessoaJuridica.TabStop = false;
            this.gbPessoaJuridica.Text = "Pessoa Jurídica";
            // 
            // cbRepresentante
            // 
            this.cbRepresentante.FormattingEnabled = true;
            this.cbRepresentante.Location = new System.Drawing.Point(98, 53);
            this.cbRepresentante.Name = "cbRepresentante";
            this.cbRepresentante.Size = new System.Drawing.Size(734, 21);
            this.cbRepresentante.TabIndex = 1;
            // 
            // lbRepresentante
            // 
            this.lbRepresentante.AutoSize = true;
            this.lbRepresentante.Location = new System.Drawing.Point(12, 56);
            this.lbRepresentante.Name = "lbRepresentante";
            this.lbRepresentante.Size = new System.Drawing.Size(80, 13);
            this.lbRepresentante.TabIndex = 2;
            this.lbRepresentante.Text = "Representante:";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(69, 26);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(763, 21);
            this.cbEmpresa.TabIndex = 0;
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Location = new System.Drawing.Point(12, 29);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lbEmpresa.TabIndex = 0;
            this.lbEmpresa.Text = "Empresa:";
            // 
            // FormContratoJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 423);
            this.Controls.Add(this.gbPessoaJuridica);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.gbContratado);
            this.Controls.Add(this.gbEvento);
            this.Controls.Add(this.gbDevolucao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormContratoJuridico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato de Pessoa Jurídica";
            this.gbBotoes.ResumeLayout(false);
            this.gbContratado.ResumeLayout(false);
            this.gbContratado.PerformLayout();
            this.gbEvento.ResumeLayout(false);
            this.gbEvento.PerformLayout();
            this.gbDevolucao.ResumeLayout(false);
            this.gbDevolucao.PerformLayout();
            this.gbPessoaJuridica.ResumeLayout(false);
            this.gbPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Button bttGerarContrato;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.GroupBox gbContratado;
        private System.Windows.Forms.DateTimePicker dtPagamento;
        private System.Windows.Forms.Label lbDataPagamento;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbQuantidadeDeCopeiros;
        private System.Windows.Forms.TextBox txtHorasAntecedencia;
        private System.Windows.Forms.DateTimePicker dtHoraChegada;
        private System.Windows.Forms.Label lbHoraAntecedencia;
        private System.Windows.Forms.Label lbHoraChegada;
        private System.Windows.Forms.TextBox txtCopeiros;
        private System.Windows.Forms.TextBox txtGarcom;
        private System.Windows.Forms.Label lbQuantidadeDeGarcoes;
        private System.Windows.Forms.DateTimePicker dtHoraTerminoContratado;
        private System.Windows.Forms.Label lbHoraTerminoContratado;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.Label lbHoraInicioContratado;
        private System.Windows.Forms.GroupBox gbEvento;
        private System.Windows.Forms.DateTimePicker dtHoraTermino;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label lbHoraTermino;
        private System.Windows.Forms.Label lbCapacidade;
        private System.Windows.Forms.TextBox txtConvidados;
        private System.Windows.Forms.Label lbConvidados;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.DateTimePicker dtHoraEvento;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dtDataEvento;
        private System.Windows.Forms.GroupBox gbDevolucao;
        private System.Windows.Forms.DateTimePicker dtHoraDevolucao;
        private System.Windows.Forms.DateTimePicker dtDiaDevolucao;
        private System.Windows.Forms.Label lbHoraDevolucao;
        private System.Windows.Forms.Label lbDiaDevolucao;
        private System.Windows.Forms.GroupBox gbPessoaJuridica;
        private System.Windows.Forms.ComboBox cbRepresentante;
        private System.Windows.Forms.Label lbRepresentante;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label lbEmpresa;
    }
}