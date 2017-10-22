namespace Buffet.CV
{
    partial class FormContrato
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
            this.gbContratante = new System.Windows.Forms.GroupBox();
            this.gbEvento = new System.Windows.Forms.GroupBox();
            this.gbContratado = new System.Windows.Forms.GroupBox();
            this.dtHoraEvento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContratante
            // 
            this.gbContratante.Location = new System.Drawing.Point(12, 241);
            this.gbContratante.Name = "gbContratante";
            this.gbContratante.Size = new System.Drawing.Size(845, 225);
            this.gbContratante.TabIndex = 0;
            this.gbContratante.TabStop = false;
            this.gbContratante.Text = "Contratante";
            // 
            // gbEvento
            // 
            this.gbEvento.Controls.Add(this.label1);
            this.gbEvento.Controls.Add(this.dtHoraEvento);
            this.gbEvento.Location = new System.Drawing.Point(12, 12);
            this.gbEvento.Name = "gbEvento";
            this.gbEvento.Size = new System.Drawing.Size(845, 223);
            this.gbEvento.TabIndex = 1;
            this.gbEvento.TabStop = false;
            this.gbEvento.Text = "Evento";
            // 
            // gbContratado
            // 
            this.gbContratado.Location = new System.Drawing.Point(12, 472);
            this.gbContratado.Name = "gbContratado";
            this.gbContratado.Size = new System.Drawing.Size(845, 192);
            this.gbContratado.TabIndex = 2;
            this.gbContratado.TabStop = false;
            this.gbContratado.Text = "Contratado";
            // 
            // dtHoraEvento
            // 
            this.dtHoraEvento.CustomFormat = "dd/MM/yyyy";
            this.dtHoraEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraEvento.Location = new System.Drawing.Point(45, 19);
            this.dtHoraEvento.Name = "dtHoraEvento";
            this.dtHoraEvento.Size = new System.Drawing.Size(109, 20);
            this.dtHoraEvento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // FormContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 774);
            this.Controls.Add(this.gbContratado);
            this.Controls.Add(this.gbEvento);
            this.Controls.Add(this.gbContratante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormContrato";
            this.Text = "Contrato";
            this.gbEvento.ResumeLayout(false);
            this.gbEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContratante;
        private System.Windows.Forms.GroupBox gbEvento;
        private System.Windows.Forms.GroupBox gbContratado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtHoraEvento;
    }
}