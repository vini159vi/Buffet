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
            this.gbDevolucao = new System.Windows.Forms.GroupBox();
            this.dtHoraDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtDiaDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lbHoraDevolucao = new System.Windows.Forms.Label();
            this.lbDiaDevolucao = new System.Windows.Forms.Label();
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
            this.checkBoxNotaFiscal = new System.Windows.Forms.CheckBox();
            this.dtPagamento = new System.Windows.Forms.DateTimePicker();
            this.lbDataPagamento = new System.Windows.Forms.Label();
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
            this.gbBuscaPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtPessoaFisica = new System.Windows.Forms.TextBox();
            this.cbBuscaPessoaFisica = new System.Windows.Forms.ComboBox();
            this.bttAvancar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.radioBttJuridica = new System.Windows.Forms.RadioButton();
            this.radioBttFisica = new System.Windows.Forms.RadioButton();
            this.gbTipoContrato = new System.Windows.Forms.GroupBox();
            this.radioBttEventosGerais = new System.Windows.Forms.RadioButton();
            this.radioBttEmpresa = new System.Windows.Forms.RadioButton();
            this.radioBtt15anos = new System.Windows.Forms.RadioButton();
            this.radioBttCasamento = new System.Windows.Forms.RadioButton();
            this.radioBttAniversario = new System.Windows.Forms.RadioButton();
            this.gbPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.cbRepresentante = new System.Windows.Forms.ComboBox();
            this.lbRepresentante = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.gbAniversario = new System.Windows.Forms.GroupBox();
            this.txtNomeAniversario = new System.Windows.Forms.TextBox();
            this.gbDevolucao.SuspendLayout();
            this.gbEvento.SuspendLayout();
            this.gbContratado.SuspendLayout();
            this.gbBuscaPessoaFisica.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbTipoContrato.SuspendLayout();
            this.gbPessoaJuridica.SuspendLayout();
            this.gbAniversario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDevolucao
            // 
            this.gbDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDevolucao.Controls.Add(this.dtHoraDevolucao);
            this.gbDevolucao.Controls.Add(this.dtDiaDevolucao);
            this.gbDevolucao.Controls.Add(this.lbHoraDevolucao);
            this.gbDevolucao.Controls.Add(this.lbDiaDevolucao);
            this.gbDevolucao.Location = new System.Drawing.Point(12, 510);
            this.gbDevolucao.Name = "gbDevolucao";
            this.gbDevolucao.Size = new System.Drawing.Size(836, 60);
            this.gbDevolucao.TabIndex = 7;
            this.gbDevolucao.TabStop = false;
            this.gbDevolucao.Text = "Devolução";
            // 
            // dtHoraDevolucao
            // 
            this.dtHoraDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraDevolucao.Location = new System.Drawing.Point(190, 20);
            this.dtHoraDevolucao.Name = "dtHoraDevolucao";
            this.dtHoraDevolucao.ShowUpDown = true;
            this.dtHoraDevolucao.Size = new System.Drawing.Size(88, 20);
            this.dtHoraDevolucao.TabIndex = 1;
            // 
            // dtDiaDevolucao
            // 
            this.dtDiaDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiaDevolucao.Location = new System.Drawing.Point(38, 20);
            this.dtDiaDevolucao.Name = "dtDiaDevolucao";
            this.dtDiaDevolucao.Size = new System.Drawing.Size(95, 20);
            this.dtDiaDevolucao.TabIndex = 0;
            // 
            // lbHoraDevolucao
            // 
            this.lbHoraDevolucao.AutoSize = true;
            this.lbHoraDevolucao.Location = new System.Drawing.Point(151, 24);
            this.lbHoraDevolucao.Name = "lbHoraDevolucao";
            this.lbHoraDevolucao.Size = new System.Drawing.Size(33, 13);
            this.lbHoraDevolucao.TabIndex = 25;
            this.lbHoraDevolucao.Text = "Hora:";
            // 
            // lbDiaDevolucao
            // 
            this.lbDiaDevolucao.AutoSize = true;
            this.lbDiaDevolucao.Location = new System.Drawing.Point(6, 24);
            this.lbDiaDevolucao.Name = "lbDiaDevolucao";
            this.lbDiaDevolucao.Size = new System.Drawing.Size(26, 13);
            this.lbDiaDevolucao.TabIndex = 24;
            this.lbDiaDevolucao.Text = "Dia:";
            // 
            // gbEvento
            // 
            this.gbEvento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbEvento.Location = new System.Drawing.Point(12, 351);
            this.gbEvento.Name = "gbEvento";
            this.gbEvento.Size = new System.Drawing.Size(836, 62);
            this.gbEvento.TabIndex = 5;
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
            this.txtCapacidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // lbHoraTermino
            // 
            this.lbHoraTermino.AutoSize = true;
            this.lbHoraTermino.Location = new System.Drawing.Point(276, 25);
            this.lbHoraTermino.Name = "lbHoraTermino";
            this.lbHoraTermino.Size = new System.Drawing.Size(85, 13);
            this.lbHoraTermino.TabIndex = 6;
            this.lbHoraTermino.Text = "Hora do término:";
            // 
            // lbCapacidade
            // 
            this.lbCapacidade.AutoSize = true;
            this.lbCapacidade.Location = new System.Drawing.Point(619, 25);
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
            this.txtConvidados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // lbConvidados
            // 
            this.lbConvidados.AutoSize = true;
            this.lbConvidados.Location = new System.Drawing.Point(452, 24);
            this.lbConvidados.Name = "lbConvidados";
            this.lbConvidados.Size = new System.Drawing.Size(95, 13);
            this.lbConvidados.TabIndex = 4;
            this.lbConvidados.Text = "Nº de convidados:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(152, 25);
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
            this.lbData.Location = new System.Drawing.Point(12, 25);
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
            this.dtDataEvento.ShowUpDown = true;
            this.dtDataEvento.Size = new System.Drawing.Size(97, 20);
            this.dtDataEvento.TabIndex = 0;
            // 
            // gbContratado
            // 
            this.gbContratado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContratado.Controls.Add(this.checkBoxNotaFiscal);
            this.gbContratado.Controls.Add(this.dtPagamento);
            this.gbContratado.Controls.Add(this.lbDataPagamento);
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
            this.gbContratado.Location = new System.Drawing.Point(12, 419);
            this.gbContratado.Name = "gbContratado";
            this.gbContratado.Size = new System.Drawing.Size(836, 85);
            this.gbContratado.TabIndex = 6;
            this.gbContratado.TabStop = false;
            this.gbContratado.Text = "Contratado";
            // 
            // checkBoxNotaFiscal
            // 
            this.checkBoxNotaFiscal.AutoSize = true;
            this.checkBoxNotaFiscal.Location = new System.Drawing.Point(659, 21);
            this.checkBoxNotaFiscal.Name = "checkBoxNotaFiscal";
            this.checkBoxNotaFiscal.Size = new System.Drawing.Size(79, 17);
            this.checkBoxNotaFiscal.TabIndex = 6;
            this.checkBoxNotaFiscal.Text = "Nota Fiscal";
            this.checkBoxNotaFiscal.UseVisualStyleBackColor = true;
            this.checkBoxNotaFiscal.CheckedChanged += new System.EventHandler(this.checkBoxNotaFiscal_CheckedChanged);
            // 
            // dtPagamento
            // 
            this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPagamento.Location = new System.Drawing.Point(734, 48);
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
            this.txtHorasAntecedencia.TabIndex = 1;
            this.txtHorasAntecedencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
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
            this.txtCopeiros.Location = new System.Drawing.Point(574, 46);
            this.txtCopeiros.Name = "txtCopeiros";
            this.txtCopeiros.Size = new System.Drawing.Size(55, 20);
            this.txtCopeiros.TabIndex = 5;
            this.txtCopeiros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // txtGarcom
            // 
            this.txtGarcom.Location = new System.Drawing.Point(574, 20);
            this.txtGarcom.Name = "txtGarcom";
            this.txtGarcom.Size = new System.Drawing.Size(55, 20);
            this.txtGarcom.TabIndex = 4;
            this.txtGarcom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
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
            this.dtHoraTerminoContratado.TabIndex = 3;
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
            this.dtHoraInicio.TabIndex = 2;
            this.dtHoraInicio.Value = new System.DateTime(2017, 12, 3, 4, 25, 0, 0);
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
            // gbBuscaPessoaFisica
            // 
            this.gbBuscaPessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscaPessoaFisica.Controls.Add(this.txtPessoaFisica);
            this.gbBuscaPessoaFisica.Controls.Add(this.cbBuscaPessoaFisica);
            this.gbBuscaPessoaFisica.Location = new System.Drawing.Point(12, 229);
            this.gbBuscaPessoaFisica.Name = "gbBuscaPessoaFisica";
            this.gbBuscaPessoaFisica.Size = new System.Drawing.Size(836, 56);
            this.gbBuscaPessoaFisica.TabIndex = 3;
            this.gbBuscaPessoaFisica.TabStop = false;
            this.gbBuscaPessoaFisica.Text = "Pessoa Fisica";
            // 
            // txtPessoaFisica
            // 
            this.txtPessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPessoaFisica.Location = new System.Drawing.Point(9, 18);
            this.txtPessoaFisica.Name = "txtPessoaFisica";
            this.txtPessoaFisica.Size = new System.Drawing.Size(819, 20);
            this.txtPessoaFisica.TabIndex = 0;
            this.txtPessoaFisica.Visible = false;
            // 
            // cbBuscaPessoaFisica
            // 
            this.cbBuscaPessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscaPessoaFisica.FormattingEnabled = true;
            this.cbBuscaPessoaFisica.Location = new System.Drawing.Point(8, 18);
            this.cbBuscaPessoaFisica.Name = "cbBuscaPessoaFisica";
            this.cbBuscaPessoaFisica.Size = new System.Drawing.Size(821, 21);
            this.cbBuscaPessoaFisica.TabIndex = 0;
            // 
            // bttAvancar
            // 
            this.bttAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttAvancar.Location = new System.Drawing.Point(149, 19);
            this.bttAvancar.Name = "bttAvancar";
            this.bttAvancar.Size = new System.Drawing.Size(125, 43);
            this.bttAvancar.TabIndex = 0;
            this.bttAvancar.Text = "Avançar";
            this.bttAvancar.UseVisualStyleBackColor = true;
            this.bttAvancar.Click += new System.EventHandler(this.bttGerarContrato_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCancelar.Location = new System.Drawing.Point(574, 19);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(125, 43);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBotoes.Controls.Add(this.bttAvancar);
            this.gbBotoes.Controls.Add(this.bttCancelar);
            this.gbBotoes.Location = new System.Drawing.Point(12, 576);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(836, 74);
            this.gbBotoes.TabIndex = 8;
            this.gbBotoes.TabStop = false;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOpcao.Controls.Add(this.radioBttJuridica);
            this.gbOpcao.Controls.Add(this.radioBttFisica);
            this.gbOpcao.Location = new System.Drawing.Point(12, 12);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(836, 56);
            this.gbOpcao.TabIndex = 0;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Opção";
            // 
            // radioBttJuridica
            // 
            this.radioBttJuridica.AutoSize = true;
            this.radioBttJuridica.Location = new System.Drawing.Point(115, 20);
            this.radioBttJuridica.Name = "radioBttJuridica";
            this.radioBttJuridica.Size = new System.Drawing.Size(99, 17);
            this.radioBttJuridica.TabIndex = 1;
            this.radioBttJuridica.TabStop = true;
            this.radioBttJuridica.Text = "Pessoa Juridica";
            this.radioBttJuridica.UseVisualStyleBackColor = true;
            this.radioBttJuridica.CheckedChanged += new System.EventHandler(this.radioBttJuridica_CheckedChanged);
            // 
            // radioBttFisica
            // 
            this.radioBttFisica.AutoSize = true;
            this.radioBttFisica.Location = new System.Drawing.Point(15, 20);
            this.radioBttFisica.Name = "radioBttFisica";
            this.radioBttFisica.Size = new System.Drawing.Size(90, 17);
            this.radioBttFisica.TabIndex = 0;
            this.radioBttFisica.TabStop = true;
            this.radioBttFisica.Text = "Pessoa Fisica";
            this.radioBttFisica.UseVisualStyleBackColor = true;
            this.radioBttFisica.CheckedChanged += new System.EventHandler(this.radioBttFisica_CheckedChanged);
            // 
            // gbTipoContrato
            // 
            this.gbTipoContrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTipoContrato.Controls.Add(this.radioBttEventosGerais);
            this.gbTipoContrato.Controls.Add(this.radioBttEmpresa);
            this.gbTipoContrato.Controls.Add(this.radioBtt15anos);
            this.gbTipoContrato.Controls.Add(this.radioBttCasamento);
            this.gbTipoContrato.Controls.Add(this.radioBttAniversario);
            this.gbTipoContrato.Location = new System.Drawing.Point(12, 74);
            this.gbTipoContrato.Name = "gbTipoContrato";
            this.gbTipoContrato.Size = new System.Drawing.Size(836, 56);
            this.gbTipoContrato.TabIndex = 1;
            this.gbTipoContrato.TabStop = false;
            this.gbTipoContrato.Text = "Tipo de Contrato";
            // 
            // radioBttEventosGerais
            // 
            this.radioBttEventosGerais.AutoSize = true;
            this.radioBttEventosGerais.Location = new System.Drawing.Point(380, 20);
            this.radioBttEventosGerais.Name = "radioBttEventosGerais";
            this.radioBttEventosGerais.Size = new System.Drawing.Size(97, 17);
            this.radioBttEventosGerais.TabIndex = 4;
            this.radioBttEventosGerais.TabStop = true;
            this.radioBttEventosGerais.Text = "Eventos Gerais";
            this.radioBttEventosGerais.UseVisualStyleBackColor = true;
            this.radioBttEventosGerais.CheckedChanged += new System.EventHandler(this.radioBttEventosGerais_CheckedChanged);
            // 
            // radioBttEmpresa
            // 
            this.radioBttEmpresa.AutoSize = true;
            this.radioBttEmpresa.Location = new System.Drawing.Point(297, 20);
            this.radioBttEmpresa.Name = "radioBttEmpresa";
            this.radioBttEmpresa.Size = new System.Drawing.Size(66, 17);
            this.radioBttEmpresa.TabIndex = 3;
            this.radioBttEmpresa.TabStop = true;
            this.radioBttEmpresa.Text = "Empresa";
            this.radioBttEmpresa.UseVisualStyleBackColor = true;
            this.radioBttEmpresa.CheckedChanged += new System.EventHandler(this.radioBttEmpresa_CheckedChanged);
            // 
            // radioBtt15anos
            // 
            this.radioBtt15anos.AutoSize = true;
            this.radioBtt15anos.Location = new System.Drawing.Point(212, 20);
            this.radioBtt15anos.Name = "radioBtt15anos";
            this.radioBtt15anos.Size = new System.Drawing.Size(64, 17);
            this.radioBtt15anos.TabIndex = 2;
            this.radioBtt15anos.TabStop = true;
            this.radioBtt15anos.Text = "15 Anos";
            this.radioBtt15anos.UseVisualStyleBackColor = true;
            this.radioBtt15anos.CheckedChanged += new System.EventHandler(this.radioBtt15anos_CheckedChanged);
            // 
            // radioBttCasamento
            // 
            this.radioBttCasamento.AutoSize = true;
            this.radioBttCasamento.Location = new System.Drawing.Point(115, 20);
            this.radioBttCasamento.Name = "radioBttCasamento";
            this.radioBttCasamento.Size = new System.Drawing.Size(78, 17);
            this.radioBttCasamento.TabIndex = 1;
            this.radioBttCasamento.TabStop = true;
            this.radioBttCasamento.Text = "Casamento";
            this.radioBttCasamento.UseVisualStyleBackColor = true;
            this.radioBttCasamento.CheckedChanged += new System.EventHandler(this.radioBttCasamento_CheckedChanged);
            // 
            // radioBttAniversario
            // 
            this.radioBttAniversario.AutoSize = true;
            this.radioBttAniversario.Location = new System.Drawing.Point(14, 20);
            this.radioBttAniversario.Name = "radioBttAniversario";
            this.radioBttAniversario.Size = new System.Drawing.Size(77, 17);
            this.radioBttAniversario.TabIndex = 0;
            this.radioBttAniversario.TabStop = true;
            this.radioBttAniversario.Text = "Aniversario";
            this.radioBttAniversario.UseVisualStyleBackColor = true;
            this.radioBttAniversario.CheckedChanged += new System.EventHandler(this.radioBttAniversario_CheckedChanged);
            // 
            // gbPessoaJuridica
            // 
            this.gbPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPessoaJuridica.Controls.Add(this.txtRepresentante);
            this.gbPessoaJuridica.Controls.Add(this.txtEmpresa);
            this.gbPessoaJuridica.Controls.Add(this.cbRepresentante);
            this.gbPessoaJuridica.Controls.Add(this.lbRepresentante);
            this.gbPessoaJuridica.Controls.Add(this.cbEmpresa);
            this.gbPessoaJuridica.Controls.Add(this.lbEmpresa);
            this.gbPessoaJuridica.Location = new System.Drawing.Point(12, 136);
            this.gbPessoaJuridica.Name = "gbPessoaJuridica";
            this.gbPessoaJuridica.Size = new System.Drawing.Size(836, 87);
            this.gbPessoaJuridica.TabIndex = 2;
            this.gbPessoaJuridica.TabStop = false;
            this.gbPessoaJuridica.Text = "Pessoa Jurídica";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepresentante.Location = new System.Drawing.Point(98, 53);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(728, 20);
            this.txtRepresentante.TabIndex = 1;
            this.txtRepresentante.Visible = false;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpresa.Location = new System.Drawing.Point(69, 26);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(757, 20);
            this.txtEmpresa.TabIndex = 0;
            this.txtEmpresa.Visible = false;
            // 
            // cbRepresentante
            // 
            this.cbRepresentante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRepresentante.FormattingEnabled = true;
            this.cbRepresentante.Location = new System.Drawing.Point(98, 53);
            this.cbRepresentante.Name = "cbRepresentante";
            this.cbRepresentante.Size = new System.Drawing.Size(728, 21);
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
            this.cbEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(69, 26);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(757, 21);
            this.cbEmpresa.TabIndex = 0;
            this.cbEmpresa.DropDownClosed += new System.EventHandler(this.cbEmpresa_DropDownClosed);
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
            // gbAniversario
            // 
            this.gbAniversario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAniversario.Controls.Add(this.txtNomeAniversario);
            this.gbAniversario.Location = new System.Drawing.Point(12, 291);
            this.gbAniversario.Name = "gbAniversario";
            this.gbAniversario.Size = new System.Drawing.Size(836, 56);
            this.gbAniversario.TabIndex = 4;
            this.gbAniversario.TabStop = false;
            this.gbAniversario.Text = "15 Anos/Aniversario";
            // 
            // txtNomeAniversario
            // 
            this.txtNomeAniversario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAniversario.Location = new System.Drawing.Point(9, 18);
            this.txtNomeAniversario.Name = "txtNomeAniversario";
            this.txtNomeAniversario.Size = new System.Drawing.Size(819, 20);
            this.txtNomeAniversario.TabIndex = 0;
            this.txtNomeAniversario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras);
            // 
            // FormContratoFísico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 690);
            this.Controls.Add(this.gbAniversario);
            this.Controls.Add(this.gbPessoaJuridica);
            this.Controls.Add(this.gbTipoContrato);
            this.Controls.Add(this.gbOpcao);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.gbBuscaPessoaFisica);
            this.Controls.Add(this.gbContratado);
            this.Controls.Add(this.gbEvento);
            this.Controls.Add(this.gbDevolucao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormContratoFísico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato de Pessoa Física";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContratoFísico_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormContratoFísico_VisibleChanged);
            this.gbDevolucao.ResumeLayout(false);
            this.gbDevolucao.PerformLayout();
            this.gbEvento.ResumeLayout(false);
            this.gbEvento.PerformLayout();
            this.gbContratado.ResumeLayout(false);
            this.gbContratado.PerformLayout();
            this.gbBuscaPessoaFisica.ResumeLayout(false);
            this.gbBuscaPessoaFisica.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            this.gbOpcao.ResumeLayout(false);
            this.gbOpcao.PerformLayout();
            this.gbTipoContrato.ResumeLayout(false);
            this.gbTipoContrato.PerformLayout();
            this.gbPessoaJuridica.ResumeLayout(false);
            this.gbPessoaJuridica.PerformLayout();
            this.gbAniversario.ResumeLayout(false);
            this.gbAniversario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDevolucao;
        private System.Windows.Forms.GroupBox gbEvento;
        private System.Windows.Forms.GroupBox gbContratado;
        private System.Windows.Forms.Label lbData;
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
        private System.Windows.Forms.Label lbQuantidadeDeGarcoes;
        private System.Windows.Forms.DateTimePicker dtHoraTerminoContratado;
        private System.Windows.Forms.Label lbHoraTerminoContratado;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.Label lbHoraInicioContratado;
        private System.Windows.Forms.DateTimePicker dtPagamento;
        private System.Windows.Forms.Label lbDataPagamento;
        private System.Windows.Forms.Label lbQuantidadeDeCopeiros;
        private System.Windows.Forms.TextBox txtHorasAntecedencia;
        private System.Windows.Forms.DateTimePicker dtHoraChegada;
        private System.Windows.Forms.Label lbHoraAntecedencia;
        private System.Windows.Forms.Label lbHoraChegada;
        private System.Windows.Forms.DateTimePicker dtHoraDevolucao;
        private System.Windows.Forms.DateTimePicker dtDiaDevolucao;
        private System.Windows.Forms.Label lbHoraDevolucao;
        private System.Windows.Forms.Label lbDiaDevolucao;
        private System.Windows.Forms.GroupBox gbBuscaPessoaFisica;
        private System.Windows.Forms.ComboBox cbBuscaPessoaFisica;
        private System.Windows.Forms.Button bttAvancar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.DateTimePicker dtDataEvento;
        private System.Windows.Forms.TextBox txtPessoaFisica;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.RadioButton radioBttJuridica;
        private System.Windows.Forms.RadioButton radioBttFisica;
        private System.Windows.Forms.GroupBox gbTipoContrato;
        private System.Windows.Forms.RadioButton radioBttEmpresa;
        private System.Windows.Forms.RadioButton radioBtt15anos;
        private System.Windows.Forms.RadioButton radioBttCasamento;
        private System.Windows.Forms.RadioButton radioBttAniversario;
        private System.Windows.Forms.GroupBox gbPessoaJuridica;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.ComboBox cbRepresentante;
        private System.Windows.Forms.Label lbRepresentante;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.CheckBox checkBoxNotaFiscal;
        private System.Windows.Forms.RadioButton radioBttEventosGerais;
        private System.Windows.Forms.GroupBox gbAniversario;
        private System.Windows.Forms.TextBox txtNomeAniversario;
    }
}