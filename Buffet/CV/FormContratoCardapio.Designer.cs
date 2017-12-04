namespace Buffet.CV
{
    partial class FormContratoCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContratoCardapio));
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.gbPratosQuentes = new System.Windows.Forms.GroupBox();
            this.dgvPratosQuentes = new System.Windows.Forms.DataGridView();
            this.ColumnIDPratosQuentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomePratosQuentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorPratosQuentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.bttGerarContrato = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.gbCardapio = new System.Windows.Forms.GroupBox();
            this.radioBttTipo2 = new System.Windows.Forms.RadioButton();
            this.radioBttTipo1 = new System.Windows.Forms.RadioButton();
            this.gbSaladas = new System.Windows.Forms.GroupBox();
            this.dgvSaladas = new System.Windows.Forms.DataGridView();
            this.ColumnIDSaladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeSaladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorSaladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMesaDeFrutas = new System.Windows.Forms.GroupBox();
            this.dgvFrutas = new System.Windows.Forms.DataGridView();
            this.ColumnIDFrutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeFrutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorFrutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMesaFrios = new System.Windows.Forms.GroupBox();
            this.dgvFrios = new System.Windows.Forms.DataGridView();
            this.ColumnIDFrios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeFrios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorFrios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBebidas = new System.Windows.Forms.GroupBox();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.ColumnIDBebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeBebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorBebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbServicos = new System.Windows.Forms.GroupBox();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.ColumnIDServicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeServicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorServicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.RichTextBox();
            this.bttRemover = new System.Windows.Forms.Button();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.cellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellValorPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbPratosQuentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratosQuentes)).BeginInit();
            this.gbBotoes.SuspendLayout();
            this.gbCardapio.SuspendLayout();
            this.gbSaladas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaladas)).BeginInit();
            this.gbMesaDeFrutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).BeginInit();
            this.gbMesaFrios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrios)).BeginInit();
            this.gbBebidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            this.gbServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.gbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbItens
            // 
            this.gbItens.Controls.Add(this.dgvItens);
            this.gbItens.Location = new System.Drawing.Point(6, 55);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(398, 450);
            this.gbItens.TabIndex = 0;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellID,
            this.cellNome,
            this.cellValorPessoa,
            this.cellTipo});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItens.Location = new System.Drawing.Point(3, 16);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(392, 431);
            this.dgvItens.TabIndex = 0;
            // 
            // gbPratosQuentes
            // 
            this.gbPratosQuentes.Controls.Add(this.dgvPratosQuentes);
            this.gbPratosQuentes.Location = new System.Drawing.Point(444, 55);
            this.gbPratosQuentes.Name = "gbPratosQuentes";
            this.gbPratosQuentes.Size = new System.Drawing.Size(412, 90);
            this.gbPratosQuentes.TabIndex = 1;
            this.gbPratosQuentes.TabStop = false;
            this.gbPratosQuentes.Text = "Pratos Quentes";
            // 
            // dgvPratosQuentes
            // 
            this.dgvPratosQuentes.AllowUserToAddRows = false;
            this.dgvPratosQuentes.AllowUserToDeleteRows = false;
            this.dgvPratosQuentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPratosQuentes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPratosQuentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPratosQuentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPratosQuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPratosQuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDPratosQuentes,
            this.ColumnNomePratosQuentes,
            this.ColumnValorPratosQuentes});
            this.dgvPratosQuentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPratosQuentes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPratosQuentes.Location = new System.Drawing.Point(3, 16);
            this.dgvPratosQuentes.Name = "dgvPratosQuentes";
            this.dgvPratosQuentes.ReadOnly = true;
            this.dgvPratosQuentes.RowHeadersVisible = false;
            this.dgvPratosQuentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPratosQuentes.Size = new System.Drawing.Size(406, 71);
            this.dgvPratosQuentes.TabIndex = 1;
            // 
            // ColumnIDPratosQuentes
            // 
            this.ColumnIDPratosQuentes.HeaderText = "ID";
            this.ColumnIDPratosQuentes.Name = "ColumnIDPratosQuentes";
            this.ColumnIDPratosQuentes.ReadOnly = true;
            // 
            // ColumnNomePratosQuentes
            // 
            this.ColumnNomePratosQuentes.HeaderText = "Nome";
            this.ColumnNomePratosQuentes.Name = "ColumnNomePratosQuentes";
            this.ColumnNomePratosQuentes.ReadOnly = true;
            // 
            // ColumnValorPratosQuentes
            // 
            this.ColumnValorPratosQuentes.HeaderText = "Valor por Cabeça";
            this.ColumnValorPratosQuentes.Name = "ColumnValorPratosQuentes";
            this.ColumnValorPratosQuentes.ReadOnly = true;
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbBotoes.Controls.Add(this.bttGerarContrato);
            this.gbBotoes.Controls.Add(this.bttCancelar);
            this.gbBotoes.Location = new System.Drawing.Point(6, 603);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(842, 75);
            this.gbBotoes.TabIndex = 5;
            this.gbBotoes.TabStop = false;
            // 
            // bttGerarContrato
            // 
            this.bttGerarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttGerarContrato.Location = new System.Drawing.Point(109, 19);
            this.bttGerarContrato.Name = "bttGerarContrato";
            this.bttGerarContrato.Size = new System.Drawing.Size(125, 43);
            this.bttGerarContrato.TabIndex = 0;
            this.bttGerarContrato.Text = "Gerar Contrato";
            this.bttGerarContrato.UseVisualStyleBackColor = true;
            this.bttGerarContrato.Click += new System.EventHandler(this.bttGerarContrato_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCancelar.Location = new System.Drawing.Point(605, 19);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(125, 43);
            this.bttCancelar.TabIndex = 1;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // gbCardapio
            // 
            this.gbCardapio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbCardapio.Controls.Add(this.radioBttTipo2);
            this.gbCardapio.Controls.Add(this.radioBttTipo1);
            this.gbCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCardapio.Location = new System.Drawing.Point(6, 2);
            this.gbCardapio.Name = "gbCardapio";
            this.gbCardapio.Size = new System.Drawing.Size(850, 47);
            this.gbCardapio.TabIndex = 6;
            this.gbCardapio.TabStop = false;
            this.gbCardapio.Text = "Cardápio";
            // 
            // radioBttTipo2
            // 
            this.radioBttTipo2.AutoSize = true;
            this.radioBttTipo2.Location = new System.Drawing.Point(93, 20);
            this.radioBttTipo2.Name = "radioBttTipo2";
            this.radioBttTipo2.Size = new System.Drawing.Size(55, 17);
            this.radioBttTipo2.TabIndex = 1;
            this.radioBttTipo2.TabStop = true;
            this.radioBttTipo2.Text = "Tipo 2";
            this.radioBttTipo2.UseVisualStyleBackColor = true;
            this.radioBttTipo2.CheckedChanged += new System.EventHandler(this.radioBttTipo2_CheckedChanged);
            // 
            // radioBttTipo1
            // 
            this.radioBttTipo1.AutoSize = true;
            this.radioBttTipo1.Location = new System.Drawing.Point(23, 20);
            this.radioBttTipo1.Name = "radioBttTipo1";
            this.radioBttTipo1.Size = new System.Drawing.Size(55, 17);
            this.radioBttTipo1.TabIndex = 0;
            this.radioBttTipo1.TabStop = true;
            this.radioBttTipo1.Text = "Tipo 1";
            this.radioBttTipo1.UseVisualStyleBackColor = true;
            this.radioBttTipo1.CheckedChanged += new System.EventHandler(this.radioBttTipo1_CheckedChanged);
            // 
            // gbSaladas
            // 
            this.gbSaladas.Controls.Add(this.dgvSaladas);
            this.gbSaladas.Location = new System.Drawing.Point(444, 144);
            this.gbSaladas.Name = "gbSaladas";
            this.gbSaladas.Size = new System.Drawing.Size(412, 90);
            this.gbSaladas.TabIndex = 2;
            this.gbSaladas.TabStop = false;
            this.gbSaladas.Text = "Mesa de Saladas";
            // 
            // dgvSaladas
            // 
            this.dgvSaladas.AllowUserToAddRows = false;
            this.dgvSaladas.AllowUserToDeleteRows = false;
            this.dgvSaladas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaladas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSaladas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSaladas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvSaladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaladas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDSaladas,
            this.ColumnNomeSaladas,
            this.ColumnValorSaladas});
            this.dgvSaladas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaladas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSaladas.Location = new System.Drawing.Point(3, 16);
            this.dgvSaladas.Name = "dgvSaladas";
            this.dgvSaladas.ReadOnly = true;
            this.dgvSaladas.RowHeadersVisible = false;
            this.dgvSaladas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaladas.Size = new System.Drawing.Size(406, 71);
            this.dgvSaladas.TabIndex = 1;
            // 
            // ColumnIDSaladas
            // 
            this.ColumnIDSaladas.HeaderText = "ID";
            this.ColumnIDSaladas.Name = "ColumnIDSaladas";
            this.ColumnIDSaladas.ReadOnly = true;
            // 
            // ColumnNomeSaladas
            // 
            this.ColumnNomeSaladas.HeaderText = "Nome";
            this.ColumnNomeSaladas.Name = "ColumnNomeSaladas";
            this.ColumnNomeSaladas.ReadOnly = true;
            // 
            // ColumnValorSaladas
            // 
            this.ColumnValorSaladas.HeaderText = "Valor por Cabeça";
            this.ColumnValorSaladas.Name = "ColumnValorSaladas";
            this.ColumnValorSaladas.ReadOnly = true;
            // 
            // gbMesaDeFrutas
            // 
            this.gbMesaDeFrutas.Controls.Add(this.dgvFrutas);
            this.gbMesaDeFrutas.Location = new System.Drawing.Point(444, 234);
            this.gbMesaDeFrutas.Name = "gbMesaDeFrutas";
            this.gbMesaDeFrutas.Size = new System.Drawing.Size(412, 90);
            this.gbMesaDeFrutas.TabIndex = 2;
            this.gbMesaDeFrutas.TabStop = false;
            this.gbMesaDeFrutas.Text = "Mesa De Frutas";
            // 
            // dgvFrutas
            // 
            this.dgvFrutas.AllowUserToAddRows = false;
            this.dgvFrutas.AllowUserToDeleteRows = false;
            this.dgvFrutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrutas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFrutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFrutas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDFrutas,
            this.ColumnNomeFrutas,
            this.ColumnValorFrutas});
            this.dgvFrutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFrutas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFrutas.Location = new System.Drawing.Point(3, 16);
            this.dgvFrutas.Name = "dgvFrutas";
            this.dgvFrutas.ReadOnly = true;
            this.dgvFrutas.RowHeadersVisible = false;
            this.dgvFrutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFrutas.Size = new System.Drawing.Size(406, 71);
            this.dgvFrutas.TabIndex = 1;
            // 
            // ColumnIDFrutas
            // 
            this.ColumnIDFrutas.HeaderText = "ID";
            this.ColumnIDFrutas.Name = "ColumnIDFrutas";
            this.ColumnIDFrutas.ReadOnly = true;
            // 
            // ColumnNomeFrutas
            // 
            this.ColumnNomeFrutas.HeaderText = "Nome";
            this.ColumnNomeFrutas.Name = "ColumnNomeFrutas";
            this.ColumnNomeFrutas.ReadOnly = true;
            // 
            // ColumnValorFrutas
            // 
            this.ColumnValorFrutas.HeaderText = "Valor por Cabeça";
            this.ColumnValorFrutas.Name = "ColumnValorFrutas";
            this.ColumnValorFrutas.ReadOnly = true;
            // 
            // gbMesaFrios
            // 
            this.gbMesaFrios.Controls.Add(this.dgvFrios);
            this.gbMesaFrios.Location = new System.Drawing.Point(444, 325);
            this.gbMesaFrios.Name = "gbMesaFrios";
            this.gbMesaFrios.Size = new System.Drawing.Size(412, 90);
            this.gbMesaFrios.TabIndex = 3;
            this.gbMesaFrios.TabStop = false;
            this.gbMesaFrios.Text = "Mesa de Frios";
            // 
            // dgvFrios
            // 
            this.dgvFrios.AllowUserToAddRows = false;
            this.dgvFrios.AllowUserToDeleteRows = false;
            this.dgvFrios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFrios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFrios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvFrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDFrios,
            this.ColumnNomeFrios,
            this.ColumnValorFrios});
            this.dgvFrios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFrios.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFrios.Location = new System.Drawing.Point(3, 16);
            this.dgvFrios.Name = "dgvFrios";
            this.dgvFrios.ReadOnly = true;
            this.dgvFrios.RowHeadersVisible = false;
            this.dgvFrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFrios.Size = new System.Drawing.Size(406, 71);
            this.dgvFrios.TabIndex = 1;
            // 
            // ColumnIDFrios
            // 
            this.ColumnIDFrios.HeaderText = "ID";
            this.ColumnIDFrios.Name = "ColumnIDFrios";
            this.ColumnIDFrios.ReadOnly = true;
            // 
            // ColumnNomeFrios
            // 
            this.ColumnNomeFrios.HeaderText = "Nome";
            this.ColumnNomeFrios.Name = "ColumnNomeFrios";
            this.ColumnNomeFrios.ReadOnly = true;
            // 
            // ColumnValorFrios
            // 
            this.ColumnValorFrios.HeaderText = "Valor por Cabeça";
            this.ColumnValorFrios.Name = "ColumnValorFrios";
            this.ColumnValorFrios.ReadOnly = true;
            // 
            // gbBebidas
            // 
            this.gbBebidas.Controls.Add(this.dgvBebidas);
            this.gbBebidas.Location = new System.Drawing.Point(444, 415);
            this.gbBebidas.Name = "gbBebidas";
            this.gbBebidas.Size = new System.Drawing.Size(412, 90);
            this.gbBebidas.TabIndex = 4;
            this.gbBebidas.TabStop = false;
            this.gbBebidas.Text = "Bebidas";
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToAddRows = false;
            this.dgvBebidas.AllowUserToDeleteRows = false;
            this.dgvBebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBebidas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBebidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBebidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDBebidas,
            this.ColumnNomeBebidas,
            this.ColumnValorBebidas});
            this.dgvBebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBebidas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBebidas.Location = new System.Drawing.Point(3, 16);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.ReadOnly = true;
            this.dgvBebidas.RowHeadersVisible = false;
            this.dgvBebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBebidas.Size = new System.Drawing.Size(406, 71);
            this.dgvBebidas.TabIndex = 1;
            // 
            // ColumnIDBebidas
            // 
            this.ColumnIDBebidas.HeaderText = "ID";
            this.ColumnIDBebidas.Name = "ColumnIDBebidas";
            this.ColumnIDBebidas.ReadOnly = true;
            // 
            // ColumnNomeBebidas
            // 
            this.ColumnNomeBebidas.HeaderText = "Nome";
            this.ColumnNomeBebidas.Name = "ColumnNomeBebidas";
            this.ColumnNomeBebidas.ReadOnly = true;
            // 
            // ColumnValorBebidas
            // 
            this.ColumnValorBebidas.HeaderText = "Valor por Cabeça";
            this.ColumnValorBebidas.Name = "ColumnValorBebidas";
            this.ColumnValorBebidas.ReadOnly = true;
            // 
            // gbServicos
            // 
            this.gbServicos.Controls.Add(this.dgvServicos);
            this.gbServicos.Location = new System.Drawing.Point(444, 506);
            this.gbServicos.Name = "gbServicos";
            this.gbServicos.Size = new System.Drawing.Size(412, 90);
            this.gbServicos.TabIndex = 4;
            this.gbServicos.TabStop = false;
            this.gbServicos.Text = "Serviços";
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvServicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDServicos,
            this.ColumnNomeServicos,
            this.ColumnValorServicos});
            this.dgvServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvServicos.Location = new System.Drawing.Point(3, 16);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.RowHeadersVisible = false;
            this.dgvServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicos.Size = new System.Drawing.Size(406, 71);
            this.dgvServicos.TabIndex = 1;
            // 
            // ColumnIDServicos
            // 
            this.ColumnIDServicos.HeaderText = "ID";
            this.ColumnIDServicos.Name = "ColumnIDServicos";
            this.ColumnIDServicos.ReadOnly = true;
            // 
            // ColumnNomeServicos
            // 
            this.ColumnNomeServicos.HeaderText = "Nome";
            this.ColumnNomeServicos.Name = "ColumnNomeServicos";
            this.ColumnNomeServicos.ReadOnly = true;
            // 
            // ColumnValorServicos
            // 
            this.ColumnValorServicos.HeaderText = "Valor por Cabeça";
            this.ColumnValorServicos.Name = "ColumnValorServicos";
            this.ColumnValorServicos.ReadOnly = true;
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.txtTotal);
            this.gbTotal.Location = new System.Drawing.Point(6, 506);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(398, 90);
            this.gbTotal.TabIndex = 5;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(3, 16);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(392, 71);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "R$:";
            // 
            // bttRemover
            // 
            this.bttRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttRemover.BackgroundImage")));
            this.bttRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRemover.Location = new System.Drawing.Point(407, 352);
            this.bttRemover.Name = "bttRemover";
            this.bttRemover.Size = new System.Drawing.Size(34, 34);
            this.bttRemover.TabIndex = 8;
            this.bttRemover.UseVisualStyleBackColor = true;
            this.bttRemover.Click += new System.EventHandler(this.bttRemover_Click);
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttAdicionar.BackgroundImage")));
            this.bttAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdicionar.Location = new System.Drawing.Point(407, 209);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(34, 34);
            this.bttAdicionar.TabIndex = 7;
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // cellID
            // 
            this.cellID.HeaderText = "ID";
            this.cellID.Name = "cellID";
            this.cellID.ReadOnly = true;
            // 
            // cellNome
            // 
            this.cellNome.HeaderText = "Nome";
            this.cellNome.Name = "cellNome";
            this.cellNome.ReadOnly = true;
            // 
            // cellValorPessoa
            // 
            this.cellValorPessoa.HeaderText = "Valor por Cabeça";
            this.cellValorPessoa.Name = "cellValorPessoa";
            this.cellValorPessoa.ReadOnly = true;
            // 
            // cellTipo
            // 
            this.cellTipo.HeaderText = "Tipo";
            this.cellTipo.Name = "cellTipo";
            this.cellTipo.ReadOnly = true;
            // 
            // FormContratoCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 690);
            this.Controls.Add(this.bttRemover);
            this.Controls.Add(this.bttAdicionar);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbServicos);
            this.Controls.Add(this.gbBebidas);
            this.Controls.Add(this.gbMesaFrios);
            this.Controls.Add(this.gbMesaDeFrutas);
            this.Controls.Add(this.gbSaladas);
            this.Controls.Add(this.gbCardapio);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.gbPratosQuentes);
            this.Controls.Add(this.gbItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContratoCardapio";
            this.Text = "FormContratoCardapio";
            this.gbItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbPratosQuentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPratosQuentes)).EndInit();
            this.gbBotoes.ResumeLayout(false);
            this.gbCardapio.ResumeLayout(false);
            this.gbCardapio.PerformLayout();
            this.gbSaladas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaladas)).EndInit();
            this.gbMesaDeFrutas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).EndInit();
            this.gbMesaFrios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrios)).EndInit();
            this.gbBebidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            this.gbServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.gbTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.GroupBox gbPratosQuentes;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Button bttGerarContrato;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.GroupBox gbCardapio;
        private System.Windows.Forms.RadioButton radioBttTipo2;
        private System.Windows.Forms.RadioButton radioBttTipo1;
        private System.Windows.Forms.GroupBox gbSaladas;
        private System.Windows.Forms.GroupBox gbMesaDeFrutas;
        private System.Windows.Forms.GroupBox gbMesaFrios;
        private System.Windows.Forms.GroupBox gbBebidas;
        private System.Windows.Forms.GroupBox gbServicos;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.RichTextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvPratosQuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDPratosQuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomePratosQuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorPratosQuentes;
        private System.Windows.Forms.DataGridView dgvSaladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDSaladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeSaladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorSaladas;
        private System.Windows.Forms.DataGridView dgvFrutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDFrutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeFrutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorFrutas;
        private System.Windows.Forms.DataGridView dgvFrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDFrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeFrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorFrios;
        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorBebidas;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorServicos;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.Button bttRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellValorPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTipo;
    }
}