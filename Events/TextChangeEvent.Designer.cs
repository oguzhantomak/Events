namespace Events
{
    partial class TextChangeEvent
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
            this.lblYaziAlani = new System.Windows.Forms.Label();
            this.txtYaziAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYaziAlani
            // 
            this.lblYaziAlani.Location = new System.Drawing.Point(12, 59);
            this.lblYaziAlani.Name = "lblYaziAlani";
            this.lblYaziAlani.Size = new System.Drawing.Size(221, 188);
            this.lblYaziAlani.TabIndex = 0;
            // 
            // txtYaziAlani
            // 
            this.txtYaziAlani.Location = new System.Drawing.Point(13, 13);
            this.txtYaziAlani.Name = "txtYaziAlani";
            this.txtYaziAlani.Size = new System.Drawing.Size(220, 20);
            this.txtYaziAlani.TabIndex = 1;
            this.txtYaziAlani.TextChanged += new System.EventHandler(this.TxtYaziAlani_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 271);
            this.Controls.Add(this.txtYaziAlani);
            this.Controls.Add(this.lblYaziAlani);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYaziAlani;
        private System.Windows.Forms.TextBox txtYaziAlani;
    }
}