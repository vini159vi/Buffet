namespace Buffet.CV

{
    partial class FormMenuModern
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuModern));
            this.timerSlideInBarra = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.bttMenu = new System.Windows.Forms.Button();
            this.panelRelatorio = new System.Windows.Forms.Panel();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.pbRelatorio = new System.Windows.Forms.PictureBox();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.pbConsulta = new System.Windows.Forms.PictureBox();
            this.panelContrato = new System.Windows.Forms.Panel();
            this.lblContrato = new System.Windows.Forms.Label();
            this.pbContrato = new System.Windows.Forms.PictureBox();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.pbCadastro = new System.Windows.Forms.PictureBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.panelAgendamento = new System.Windows.Forms.Panel();
            this.pbAgenda = new System.Windows.Forms.PictureBox();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.panelCardapio = new System.Windows.Forms.Panel();
            this.pbCardapio = new System.Windows.Forms.PictureBox();
            this.lblCardapio = new System.Windows.Forms.Label();
            this.panelSlideCadastro = new System.Windows.Forms.Panel();
            this.lblCadastroRepresentante = new System.Windows.Forms.Label();
            this.lblCadastroJuridico = new System.Windows.Forms.Label();
            this.lblCadastroFisica = new System.Windows.Forms.Label();
            this.topPage = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bttMaximize = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttMinimize = new System.Windows.Forms.Button();
            this.timerSlideOutBarra = new System.Windows.Forms.Timer(this.components);
            this.timerSelecao = new System.Windows.Forms.Timer(this.components);
            this.timerCadastroOut = new System.Windows.Forms.Timer(this.components);
            this.panelWorkstation = new System.Windows.Forms.Panel();
            this.timerCadastroIn = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelatorio)).BeginInit();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsulta)).BeginInit();
            this.panelContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrato)).BeginInit();
            this.panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastro)).BeginInit();
            this.panelAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgenda)).BeginInit();
            this.panelCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardapio)).BeginInit();
            this.panelSlideCadastro.SuspendLayout();
            this.topPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelWorkstation.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSlideInBarra
            // 
            this.timerSlideInBarra.Interval = 25;
            this.timerSlideInBarra.Tick += new System.EventHandler(this.TimerSlideInBarra_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panelMenu.Controls.Add(this.panelAgendamento);
            this.panelMenu.Controls.Add(this.panelSelecao);
            this.panelMenu.Controls.Add(this.bttMenu);
            this.panelMenu.Controls.Add(this.panelRelatorio);
            this.panelMenu.Controls.Add(this.panelConsulta);
            this.panelMenu.Controls.Add(this.panelContrato);
            this.panelMenu.Controls.Add(this.panelCadastro);
            this.panelMenu.Controls.Add(this.panelCardapio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 79);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(168, 673);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSelecao
            // 
            this.panelSelecao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSelecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(125)))));
            this.panelSelecao.ForeColor = System.Drawing.Color.Transparent;
            this.panelSelecao.Location = new System.Drawing.Point(0, 446);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(8, 47);
            this.panelSelecao.TabIndex = 3;
            // 
            // bttMenu
            // 
            this.bttMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttMenu.BackgroundImage")));
            this.bttMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttMenu.FlatAppearance.BorderSize = 0;
            this.bttMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMenu.Location = new System.Drawing.Point(4, 3);
            this.bttMenu.Name = "bttMenu";
            this.bttMenu.Size = new System.Drawing.Size(43, 43);
            this.bttMenu.TabIndex = 6;
            this.bttMenu.UseVisualStyleBackColor = true;
            this.bttMenu.Click += new System.EventHandler(this.bttMenu_Click_1);
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panelRelatorio.Controls.Add(this.lblRelatorio);
            this.panelRelatorio.Controls.Add(this.pbRelatorio);
            this.panelRelatorio.Location = new System.Drawing.Point(8, 531);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.Size = new System.Drawing.Size(154, 47);
            this.panelRelatorio.TabIndex = 5;
            this.panelRelatorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelRelatorio_MouseClick);
            this.panelRelatorio.MouseLeave += new System.EventHandler(this.panelRelatorio_MouseLeave);
            this.panelRelatorio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRelatorio_MouseMove);
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.ForeColor = System.Drawing.Color.White;
            this.lblRelatorio.Location = new System.Drawing.Point(52, 10);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(102, 29);
            this.lblRelatorio.TabIndex = 15;
            this.lblRelatorio.Text = "Relatório";
            this.lblRelatorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelRelatorio_MouseClick);
            this.lblRelatorio.MouseLeave += new System.EventHandler(this.panelRelatorio_MouseLeave);
            this.lblRelatorio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRelatorio_MouseMove);
            // 
            // pbRelatorio
            // 
            this.pbRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("pbRelatorio.Image")));
            this.pbRelatorio.Location = new System.Drawing.Point(-7, 0);
            this.pbRelatorio.Name = "pbRelatorio";
            this.pbRelatorio.Size = new System.Drawing.Size(52, 47);
            this.pbRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRelatorio.TabIndex = 13;
            this.pbRelatorio.TabStop = false;
            this.pbRelatorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelRelatorio_MouseClick);
            this.pbRelatorio.MouseLeave += new System.EventHandler(this.panelRelatorio_MouseLeave);
            this.pbRelatorio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRelatorio_MouseMove);
            // 
            // panelConsulta
            // 
            this.panelConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panelConsulta.Controls.Add(this.lblConsulta);
            this.panelConsulta.Controls.Add(this.pbConsulta);
            this.panelConsulta.Location = new System.Drawing.Point(8, 446);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(158, 47);
            this.panelConsulta.TabIndex = 4;
            this.panelConsulta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelConsulta_MouseClick);
            this.panelConsulta.MouseLeave += new System.EventHandler(this.panelConsulta_MouseLeave);
            this.panelConsulta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelConsulta_MouseMove);
            // 
            // lblConsulta
            // 
            this.lblConsulta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.White;
            this.lblConsulta.Location = new System.Drawing.Point(52, 10);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(100, 29);
            this.lblConsulta.TabIndex = 14;
            this.lblConsulta.Text = "Consulta";
            this.lblConsulta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelConsulta_MouseClick);
            this.lblConsulta.MouseLeave += new System.EventHandler(this.panelConsulta_MouseLeave);
            this.lblConsulta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelConsulta_MouseMove);
            // 
            // pbConsulta
            // 
            this.pbConsulta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbConsulta.Image = ((System.Drawing.Image)(resources.GetObject("pbConsulta.Image")));
            this.pbConsulta.Location = new System.Drawing.Point(-7, 0);
            this.pbConsulta.Name = "pbConsulta";
            this.pbConsulta.Size = new System.Drawing.Size(52, 47);
            this.pbConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConsulta.TabIndex = 12;
            this.pbConsulta.TabStop = false;
            this.pbConsulta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelConsulta_MouseClick);
            this.pbConsulta.MouseLeave += new System.EventHandler(this.panelConsulta_MouseLeave);
            this.pbConsulta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelConsulta_MouseMove);
            // 
            // panelContrato
            // 
            this.panelContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panelContrato.Controls.Add(this.lblContrato);
            this.panelContrato.Controls.Add(this.pbContrato);
            this.panelContrato.Location = new System.Drawing.Point(8, 276);
            this.panelContrato.Name = "panelContrato";
            this.panelContrato.Size = new System.Drawing.Size(154, 47);
            this.panelContrato.TabIndex = 2;
            this.panelContrato.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelContrato_MouseClick);
            this.panelContrato.MouseLeave += new System.EventHandler(this.panelContrato_MouseLeave);
            this.panelContrato.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelContrato_MouseMove);
            // 
            // lblContrato
            // 
            this.lblContrato.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.ForeColor = System.Drawing.Color.White;
            this.lblContrato.Location = new System.Drawing.Point(50, 10);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(98, 29);
            this.lblContrato.TabIndex = 12;
            this.lblContrato.Text = "Contrato";
            this.lblContrato.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelContrato_MouseClick);
            this.lblContrato.MouseLeave += new System.EventHandler(this.panelContrato_MouseLeave);
            this.lblContrato.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelContrato_MouseMove);
            // 
            // pbContrato
            // 
            this.pbContrato.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbContrato.Image = ((System.Drawing.Image)(resources.GetObject("pbContrato.Image")));
            this.pbContrato.Location = new System.Drawing.Point(-7, 0);
            this.pbContrato.Name = "pbContrato";
            this.pbContrato.Size = new System.Drawing.Size(52, 47);
            this.pbContrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContrato.TabIndex = 10;
            this.pbContrato.TabStop = false;
            this.pbContrato.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelContrato_MouseClick);
            this.pbContrato.MouseLeave += new System.EventHandler(this.panelContrato_MouseLeave);
            this.pbContrato.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelContrato_MouseMove);
            // 
            // panelCadastro
            // 
            this.panelCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panelCadastro.Controls.Add(this.pbCadastro);
            this.panelCadastro.Controls.Add(this.lblCadastro);
            this.panelCadastro.Location = new System.Drawing.Point(8, 191);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(154, 47);
            this.panelCadastro.TabIndex = 1;
            this.panelCadastro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCadastro_MouseClick);
            this.panelCadastro.MouseLeave += new System.EventHandler(this.panelCadastro_MouseLeave);
            this.panelCadastro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCadastro_MouseMove);
            // 
            // pbCadastro
            // 
            this.pbCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbCadastro.Image = ((System.Drawing.Image)(resources.GetObject("pbCadastro.Image")));
            this.pbCadastro.Location = new System.Drawing.Point(-7, 0);
            this.pbCadastro.Name = "pbCadastro";
            this.pbCadastro.Size = new System.Drawing.Size(52, 47);
            this.pbCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCadastro.TabIndex = 11;
            this.pbCadastro.TabStop = false;
            this.pbCadastro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCadastro_MouseClick);
            this.pbCadastro.MouseLeave += new System.EventHandler(this.panelCadastro_MouseLeave);
            this.pbCadastro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCadastro_MouseMove);
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(49, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(101, 29);
            this.lblCadastro.TabIndex = 9;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCadastro_MouseClick);
            this.lblCadastro.MouseLeave += new System.EventHandler(this.panelCadastro_MouseLeave);
            this.lblCadastro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCadastro_MouseMove);
            // 
            // panelAgendamento
            // 
            this.panelAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panelAgendamento.Controls.Add(this.pbAgenda);
            this.panelAgendamento.Controls.Add(this.lblAgenda);
            this.panelAgendamento.Location = new System.Drawing.Point(8, 106);
            this.panelAgendamento.Name = "panelAgendamento";
            this.panelAgendamento.Size = new System.Drawing.Size(154, 47);
            this.panelAgendamento.TabIndex = 0;
            this.panelAgendamento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAgendamento_MouseClick);
            this.panelAgendamento.MouseLeave += new System.EventHandler(this.panelAgendamento_MouseLeave);
            this.panelAgendamento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAgendamento_MouseMove);
            // 
            // pbAgenda
            // 
            this.pbAgenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbAgenda.Image = ((System.Drawing.Image)(resources.GetObject("pbAgenda.Image")));
            this.pbAgenda.Location = new System.Drawing.Point(-6, 0);
            this.pbAgenda.Name = "pbAgenda";
            this.pbAgenda.Size = new System.Drawing.Size(52, 47);
            this.pbAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgenda.TabIndex = 12;
            this.pbAgenda.TabStop = false;
            this.pbAgenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAgendamento_MouseClick);
            this.pbAgenda.MouseLeave += new System.EventHandler(this.panelAgendamento_MouseLeave);
            this.pbAgenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAgendamento_MouseMove);
            // 
            // lblAgenda
            // 
            this.lblAgenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.White;
            this.lblAgenda.Location = new System.Drawing.Point(55, 9);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(86, 29);
            this.lblAgenda.TabIndex = 0;
            this.lblAgenda.Text = "Agenda";
            this.lblAgenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAgendamento_MouseClick);
            this.lblAgenda.MouseLeave += new System.EventHandler(this.panelAgendamento_MouseLeave);
            this.lblAgenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAgendamento_MouseMove);
            // 
            // panelCardapio
            // 
            this.panelCardapio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panelCardapio.Controls.Add(this.pbCardapio);
            this.panelCardapio.Controls.Add(this.lblCardapio);
            this.panelCardapio.Location = new System.Drawing.Point(8, 361);
            this.panelCardapio.Name = "panelCardapio";
            this.panelCardapio.Size = new System.Drawing.Size(154, 47);
            this.panelCardapio.TabIndex = 3;
            this.panelCardapio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCardapio_MouseClick);
            this.panelCardapio.MouseLeave += new System.EventHandler(this.panelCardapio_MouseLeave);
            this.panelCardapio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCardapio_MouseMove);
            // 
            // pbCardapio
            // 
            this.pbCardapio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbCardapio.Image = ((System.Drawing.Image)(resources.GetObject("pbCardapio.Image")));
            this.pbCardapio.Location = new System.Drawing.Point(-7, 0);
            this.pbCardapio.Name = "pbCardapio";
            this.pbCardapio.Size = new System.Drawing.Size(52, 47);
            this.pbCardapio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardapio.TabIndex = 11;
            this.pbCardapio.TabStop = false;
            this.pbCardapio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCardapio_MouseClick);
            this.pbCardapio.MouseLeave += new System.EventHandler(this.panelCardapio_MouseLeave);
            this.pbCardapio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCardapio_MouseMove);
            // 
            // lblCardapio
            // 
            this.lblCardapio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCardapio.AutoSize = true;
            this.lblCardapio.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardapio.ForeColor = System.Drawing.Color.White;
            this.lblCardapio.Location = new System.Drawing.Point(52, 10);
            this.lblCardapio.Name = "lblCardapio";
            this.lblCardapio.Size = new System.Drawing.Size(101, 29);
            this.lblCardapio.TabIndex = 13;
            this.lblCardapio.Text = "Cardápio";
            this.lblCardapio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCardapio_MouseClick);
            this.lblCardapio.MouseLeave += new System.EventHandler(this.panelCardapio_MouseLeave);
            this.lblCardapio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCardapio_MouseMove);
            // 
            // panelSlideCadastro
            // 
            this.panelSlideCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSlideCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.panelSlideCadastro.Controls.Add(this.lblCadastroRepresentante);
            this.panelSlideCadastro.Controls.Add(this.lblCadastroJuridico);
            this.panelSlideCadastro.Controls.Add(this.lblCadastroFisica);
            this.panelSlideCadastro.Location = new System.Drawing.Point(-7, 193);
            this.panelSlideCadastro.Name = "panelSlideCadastro";
            this.panelSlideCadastro.Size = new System.Drawing.Size(150, 5);
            this.panelSlideCadastro.TabIndex = 7;
            this.panelSlideCadastro.Visible = false;
            // 
            // lblCadastroRepresentante
            // 
            this.lblCadastroRepresentante.AutoSize = true;
            this.lblCadastroRepresentante.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroRepresentante.ForeColor = System.Drawing.Color.White;
            this.lblCadastroRepresentante.Location = new System.Drawing.Point(22, 57);
            this.lblCadastroRepresentante.Name = "lblCadastroRepresentante";
            this.lblCadastroRepresentante.Size = new System.Drawing.Size(106, 20);
            this.lblCadastroRepresentante.TabIndex = 14;
            this.lblCadastroRepresentante.Text = "Representante";
            // 
            // lblCadastroJuridico
            // 
            this.lblCadastroJuridico.AutoSize = true;
            this.lblCadastroJuridico.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroJuridico.ForeColor = System.Drawing.Color.White;
            this.lblCadastroJuridico.Location = new System.Drawing.Point(22, 30);
            this.lblCadastroJuridico.Name = "lblCadastroJuridico";
            this.lblCadastroJuridico.Size = new System.Drawing.Size(111, 20);
            this.lblCadastroJuridico.TabIndex = 13;
            this.lblCadastroJuridico.Text = "Pessoa Juridica";
            // 
            // lblCadastroFisica
            // 
            this.lblCadastroFisica.AutoSize = true;
            this.lblCadastroFisica.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroFisica.ForeColor = System.Drawing.Color.White;
            this.lblCadastroFisica.Location = new System.Drawing.Point(22, 3);
            this.lblCadastroFisica.Name = "lblCadastroFisica";
            this.lblCadastroFisica.Size = new System.Drawing.Size(98, 20);
            this.lblCadastroFisica.TabIndex = 12;
            this.lblCadastroFisica.Text = "Pessoa Fisica";
            // 
            // topPage
            // 
            this.topPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.topPage.Controls.Add(this.pbLogo);
            this.topPage.Controls.Add(this.bttMaximize);
            this.topPage.Controls.Add(this.bttExit);
            this.topPage.Controls.Add(this.bttMinimize);
            this.topPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topPage.Location = new System.Drawing.Point(0, 0);
            this.topPage.Name = "topPage";
            this.topPage.Size = new System.Drawing.Size(1024, 79);
            this.topPage.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(147, 76);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // bttMaximize
            // 
            this.bttMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttMaximize.BackColor = System.Drawing.Color.Transparent;
            this.bttMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttMaximize.BackgroundImage")));
            this.bttMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttMaximize.FlatAppearance.BorderSize = 0;
            this.bttMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.bttMaximize.Location = new System.Drawing.Point(926, 21);
            this.bttMaximize.Name = "bttMaximize";
            this.bttMaximize.Size = new System.Drawing.Size(34, 35);
            this.bttMaximize.TabIndex = 2;
            this.bttMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttMaximize.UseVisualStyleBackColor = false;
            this.bttMaximize.Click += new System.EventHandler(this.bttMaximize_Click);
            // 
            // bttExit
            // 
            this.bttExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttExit.BackColor = System.Drawing.Color.Transparent;
            this.bttExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttExit.BackgroundImage")));
            this.bttExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttExit.FlatAppearance.BorderSize = 0;
            this.bttExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttExit.ForeColor = System.Drawing.Color.Transparent;
            this.bttExit.Location = new System.Drawing.Point(973, 26);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(25, 24);
            this.bttExit.TabIndex = 1;
            this.bttExit.UseVisualStyleBackColor = false;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttMinimize
            // 
            this.bttMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bttMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttMinimize.BackgroundImage")));
            this.bttMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttMinimize.FlatAppearance.BorderSize = 0;
            this.bttMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.bttMinimize.Location = new System.Drawing.Point(880, 22);
            this.bttMinimize.Name = "bttMinimize";
            this.bttMinimize.Size = new System.Drawing.Size(34, 30);
            this.bttMinimize.TabIndex = 0;
            this.bttMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttMinimize.UseVisualStyleBackColor = false;
            this.bttMinimize.Click += new System.EventHandler(this.bttMinimize_Click);
            // 
            // timerSlideOutBarra
            // 
            this.timerSlideOutBarra.Interval = 25;
            this.timerSlideOutBarra.Tick += new System.EventHandler(this.TimerSlideOutBarra_Tick);
            // 
            // timerSelecao
            // 
            this.timerSelecao.Interval = 1;
            this.timerSelecao.Tick += new System.EventHandler(this.timerSelecao_Tick);
            // 
            // timerCadastroOut
            // 
            this.timerCadastroOut.Interval = 25;
            this.timerCadastroOut.Tick += new System.EventHandler(this.timerCadastroOut_Tick);
            // 
            // panelWorkstation
            // 
            this.panelWorkstation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelWorkstation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelWorkstation.Controls.Add(this.panelSlideCadastro);
            this.panelWorkstation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkstation.ForeColor = System.Drawing.Color.Black;
            this.panelWorkstation.Location = new System.Drawing.Point(168, 79);
            this.panelWorkstation.Name = "panelWorkstation";
            this.panelWorkstation.Size = new System.Drawing.Size(856, 673);
            this.panelWorkstation.TabIndex = 3;
            // 
            // timerCadastroIn
            // 
            this.timerCadastroIn.Interval = 25;
            this.timerCadastroIn.Tick += new System.EventHandler(this.timerCadastroIn_Tick);
            // 
            // FormMenuModern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 752);
            this.Controls.Add(this.panelWorkstation);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.topPage);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuModern";
            this.Text = "FormMenuModern";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.ResumeLayout(false);
            this.panelRelatorio.ResumeLayout(false);
            this.panelRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelatorio)).EndInit();
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsulta)).EndInit();
            this.panelContrato.ResumeLayout(false);
            this.panelContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrato)).EndInit();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastro)).EndInit();
            this.panelAgendamento.ResumeLayout(false);
            this.panelAgendamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgenda)).EndInit();
            this.panelCardapio.ResumeLayout(false);
            this.panelCardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardapio)).EndInit();
            this.panelSlideCadastro.ResumeLayout(false);
            this.panelSlideCadastro.PerformLayout();
            this.topPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelWorkstation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSlideInBarra;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Panel panelAgendamento;
        private System.Windows.Forms.Panel topPage;
        private System.Windows.Forms.Panel panelContrato;
        private System.Windows.Forms.Panel panelRelatorio;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Panel panelCardapio;
        private System.Windows.Forms.Timer timerSlideOutBarra;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.PictureBox pbContrato;
        private System.Windows.Forms.PictureBox pbCadastro;
        private System.Windows.Forms.PictureBox pbAgenda;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.PictureBox pbRelatorio;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.PictureBox pbConsulta;
        private System.Windows.Forms.Label lblCardapio;
        private System.Windows.Forms.PictureBox pbCardapio;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Button bttMinimize;
        private System.Windows.Forms.Button bttMaximize;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button bttMenu;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.Timer timerSelecao;
        private System.Windows.Forms.Panel panelSlideCadastro;
        private System.Windows.Forms.Label lblCadastroRepresentante;
        private System.Windows.Forms.Label lblCadastroJuridico;
        private System.Windows.Forms.Label lblCadastroFisica;
        private System.Windows.Forms.Timer timerCadastroOut;
        private System.Windows.Forms.Panel panelWorkstation;
        private System.Windows.Forms.Timer timerCadastroIn;
    }
}