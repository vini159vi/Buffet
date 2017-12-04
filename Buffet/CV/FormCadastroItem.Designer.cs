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
            this.SuspendLayout();
            // 
            // gbAdicionarItem
            // 
            this.gbAdicionarItem.Location = new System.Drawing.Point(12, 12);
            this.gbAdicionarItem.Name = "gbAdicionarItem";
            this.gbAdicionarItem.Size = new System.Drawing.Size(836, 181);
            this.gbAdicionarItem.TabIndex = 0;
            this.gbAdicionarItem.TabStop = false;
            this.gbAdicionarItem.Text = "Adicionar Item";
            // 
            // FormCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 207);
            this.Controls.Add(this.gbAdicionarItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroItem";
            this.Text = "FormCadastroItem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdicionarItem;
    }
}