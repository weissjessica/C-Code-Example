namespace Weiss_Jessica_Millionenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtBoxKapital = new System.Windows.Forms.TextBox();
            this.lblKapital = new System.Windows.Forms.Label();
            this.lblZins = new System.Windows.Forms.Label();
            this.txtBoxZins = new System.Windows.Forms.TextBox();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnausrechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(47, 34);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(124, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Millionenrechner";
            // 
            // txtBoxKapital
            // 
            this.txtBoxKapital.Location = new System.Drawing.Point(93, 111);
            this.txtBoxKapital.Name = "txtBoxKapital";
            this.txtBoxKapital.Size = new System.Drawing.Size(100, 26);
            this.txtBoxKapital.TabIndex = 1;            // 
            // lblKapital
            // 
            this.lblKapital.AutoSize = true;
            this.lblKapital.Location = new System.Drawing.Point(13, 117);
            this.lblKapital.Name = "lblKapital";
            this.lblKapital.Size = new System.Drawing.Size(65, 20);
            this.lblKapital.TabIndex = 2;
            this.lblKapital.Text = "Kapital: ";
            // 
            // lblZins
            // 
            this.lblZins.AutoSize = true;
            this.lblZins.Location = new System.Drawing.Point(17, 150);
            this.lblZins.Name = "lblZins";
            this.lblZins.Size = new System.Drawing.Size(43, 20);
            this.lblZins.TabIndex = 3;
            this.lblZins.Text = "Zins:";
            // 
            // txtBoxZins
            // 
            this.txtBoxZins.Location = new System.Drawing.Point(93, 150);
            this.txtBoxZins.Name = "txtBoxZins";
            this.txtBoxZins.Size = new System.Drawing.Size(100, 26);
            this.txtBoxZins.TabIndex = 2;
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(17, 248);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(76, 20);
            this.lblErgebnis.TabIndex = 5;
            this.lblErgebnis.Text = "Ergebnis:";
            // 
            // btnausrechnen
            // 
            this.btnausrechnen.Location = new System.Drawing.Point(93, 190);
            this.btnausrechnen.Name = "btnausrechnen";
            this.btnausrechnen.Size = new System.Drawing.Size(113, 38);
            this.btnausrechnen.TabIndex = 3;
            this.btnausrechnen.Text = "ausrechnen";
            this.btnausrechnen.UseVisualStyleBackColor = true;
            this.btnausrechnen.Click += new System.EventHandler(this.btnausrechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnausrechnen);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.txtBoxZins);
            this.Controls.Add(this.lblZins);
            this.Controls.Add(this.lblKapital);
            this.Controls.Add(this.txtBoxKapital);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtBoxKapital;
        private System.Windows.Forms.Label lblKapital;
        private System.Windows.Forms.Label lblZins;
        private System.Windows.Forms.TextBox txtBoxZins;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Button btnausrechnen;
    }
}

