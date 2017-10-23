namespace Buffet.CV
{
    partial class FormContratoFísico
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
            this.gbGerais = new System.Windows.Forms.GroupBox();
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
            this.gbContratado = new System.Windows.Forms.GroupBox();
            this.lbHoraInicioContratado = new System.Windows.Forms.Label();
            this.dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtHoraTerminoContratado = new System.Windows.Forms.DateTimePicker();
            this.lbQuantidadeDe = new System.Windows.Forms.Label();
            this.txtGarcom = new System.Windows.Forms.TextBox();
            this.txtCopeiros = new System.Windows.Forms.TextBox();
            this.lbHoraChegada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.txtHorasAntecedencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lbDataPagamento = new System.Windows.Forms.Label();
            this.dtPagamento = new System.Windows.Forms.DateTimePicker();
            this.gbEvento.SuspendLayout();
            this.gbContratado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGerais
            // 
            this.gbGerais.Location = new System.Drawing.Point(12, 248);
            this.gbGerais.Name = "gbGerais";
            this.gbGerais.Size = new System.Drawing.Size(845, 225);
            this.gbGerais.TabIndex = 0;
            this.gbGerais.TabStop = false;
            this.gbGerais.Text = "Gerais";
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
            this.gbEvento.Location = new System.Drawing.Point(12, 12);
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
            this.dtHoraTermino.Size = new System.Drawing.Size(80, 20);
            this.dtHoraTermino.TabIndex = 7;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(769, 21);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(63, 20);
            this.txtCapacidade.TabIndex = 9;
            this.txtCapacidade.TextChanged += new System.EventHandler(this.txtCapacidade_TextChanged);
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
            this.txtConvidados.TabIndex = 5;
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
            this.dtHoraEvento.Size = new System.Drawing.Size(81, 20);
            this.dtHoraEvento.TabIndex = 2;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(12, 27);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(33, 13);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data:";
            this.lbData.Click += new System.EventHandler(this.label1_Click);
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
            // gbContratado
            // 
            this.gbContratado.Controls.Add(this.dtPagamento);
            this.gbContratado.Controls.Add(this.lbDataPagamento);
            this.gbContratado.Controls.Add(this.txtPreco);
            this.gbContratado.Controls.Add(this.lbPreco);
            this.gbContratado.Controls.Add(this.label2);
            this.gbContratado.Controls.Add(this.txtHorasAntecedencia);
            this.gbContratado.Controls.Add(this.dtHoraChegada);
            this.gbContratado.Controls.Add(this.label3);
            this.gbContratado.Controls.Add(this.lbHoraChegada);
            this.gbContratado.Controls.Add(this.txtCopeiros);
            this.gbContratado.Controls.Add(this.txtGarcom);
            this.gbContratado.Controls.Add(this.lbQuantidadeDe);
            this.gbContratado.Controls.Add(this.dtHoraTerminoContratado);
            this.gbContratado.Controls.Add(this.label1);
            this.gbContratado.Controls.Add(this.dtHoraInicio);
            this.gbContratado.Controls.Add(this.lbHoraInicioContratado);
            this.gbContratado.Location = new System.Drawing.Point(12, 80);
            this.gbContratado.Name = "gbContratado";
            this.gbContratado.Size = new System.Drawing.Size(845, 112);
            this.gbContratado.TabIndex = 2;
            this.gbContratado.TabStop = false;
            this.gbContratado.Text = "Contratado";
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
            // dtHoraInicio
            // 
            this.dtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraInicio.Location = new System.Drawing.Point(315, 19);
            this.dtHoraInicio.Name = "dtHoraInicio";
            this.dtHoraInicio.Size = new System.Drawing.Size(81, 20);
            this.dtHoraInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Término do serviço:";
            // 
            // dtHoraTerminoContratado
            // 
            this.dtHoraTerminoContratado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraTerminoContratado.Location = new System.Drawing.Point(315, 45);
            this.dtHoraTerminoContratado.Name = "dtHoraTerminoContratado";
            this.dtHoraTerminoContratado.Size = new System.Drawing.Size(81, 20);
            this.dtHoraTerminoContratado.TabIndex = 3;
            this.dtHoraTerminoContratado.ValueChanged += new System.EventHandler(this.dtHoraTerminoContratado_ValueChanged);
            // 
            // lbQuantidadeDe
            // 
            this.lbQuantidadeDe.AutoSize = true;
            this.lbQuantidadeDe.Location = new System.Drawing.Point(445, 23);
            this.lbQuantidadeDe.Name = "lbQuantidadeDe";
            this.lbQuantidadeDe.Size = new System.Drawing.Size(121, 13);
            this.lbQuantidadeDe.TabIndex = 4;
            this.lbQuantidadeDe.Text = "Quantidade de garçons:";
            // 
            // txtGarcom
            // 
            this.txtGarcom.Location = new System.Drawing.Point(574, 20);
            this.txtGarcom.Name = "txtGarcom";
            this.txtGarcom.Size = new System.Drawing.Size(55, 20);
            this.txtGarcom.TabIndex = 7;
            // 
            // txtCopeiros
            // 
            this.txtCopeiros.Location = new System.Drawing.Point(574, 48);
            this.txtCopeiros.Name = "txtCopeiros";
            this.txtCopeiros.Size = new System.Drawing.Size(55, 20);
            this.txtCopeiros.TabIndex = 8;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Horas de antecedência:";
            // 
            // dtHoraChegada
            // 
            this.dtHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraChegada.Location = new System.Drawing.Point(105, 20);
            this.dtHoraChegada.Name = "dtHoraChegada";
            this.dtHoraChegada.Size = new System.Drawing.Size(81, 20);
            this.dtHoraChegada.TabIndex = 11;
            // 
            // txtHorasAntecedencia
            // 
            this.txtHorasAntecedencia.Location = new System.Drawing.Point(133, 46);
            this.txtHorasAntecedencia.Name = "txtHorasAntecedencia";
            this.txtHorasAntecedencia.Size = new System.Drawing.Size(53, 20);
            this.txtHorasAntecedencia.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantidade de copeiros:";
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
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(756, 20);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(76, 20);
            this.txtPreco.TabIndex = 15;
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
            // dtPagamento
            // 
            this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPagamento.Location = new System.Drawing.Point(737, 45);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Size = new System.Drawing.Size(95, 20);
            this.dtPagamento.TabIndex = 17;
            // 
            // FormContratoFísico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 750);
            this.Controls.Add(this.gbContratado);
            this.Controls.Add(this.gbEvento);
            this.Controls.Add(this.gbGerais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormContratoFísico";
            this.Text = "Contrato de Pessoa Física";
            this.gbEvento.ResumeLayout(false);
            this.gbEvento.PerformLayout();
            this.gbContratado.ResumeLayout(false);
            this.gbContratado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGerais;
        private System.Windows.Forms.GroupBox gbEvento;
        private System.Windows.Forms.GroupBox gbContratado;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dtDataEvento;
        private System.Windows.Forms.DateTimePicker dtHoraEvento;
        private System.Windows.Forms.TextBox txtConvidados;
        private System.Windows.Forms.Label lbConvidados;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.DateTimePicker dtHoraTermino;
        private System.Windows.Forms.Label lbHoraTermino;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label lbCapacidade;
        private System.Windows.Forms.TextBox txtCopeiros;
        private System.Windows.Forms.TextBox txtGarcom;
        private System.Windows.Forms.Label lbQuantidadeDe;
        private System.Windows.Forms.DateTimePicker dtHoraTerminoContratado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.Label lbHoraInicioContratado;
        private System.Windows.Forms.DateTimePicker dtPagamento;
        private System.Windows.Forms.Label lbDataPagamento;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasAntecedencia;
        private System.Windows.Forms.DateTimePicker dtHoraChegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoraChegada;
    }
}