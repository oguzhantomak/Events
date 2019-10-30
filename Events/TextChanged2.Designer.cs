namespace Events
{
    partial class TextChanged2
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
            this.txtMetinAlani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalanKarakter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMetinAlani
            // 
            this.txtMetinAlani.Location = new System.Drawing.Point(13, 13);
            this.txtMetinAlani.Multiline = true;
            this.txtMetinAlani.Name = "txtMetinAlani";
            this.txtMetinAlani.Size = new System.Drawing.Size(477, 95);
            this.txtMetinAlani.TabIndex = 0;
            this.txtMetinAlani.TextChanged += new System.EventHandler(this.TxtMetinAlani_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalan Karakter Sayısı: ";
            // 
            // lblKalanKarakter
            // 
            this.lblKalanKarakter.AutoSize = true;
            this.lblKalanKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanKarakter.Location = new System.Drawing.Point(159, 115);
            this.lblKalanKarakter.Name = "lblKalanKarakter";
            this.lblKalanKarakter.Size = new System.Drawing.Size(45, 25);
            this.lblKalanKarakter.TabIndex = 1;
            this.lblKalanKarakter.Text = "500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 174);
            this.Controls.Add(this.lblKalanKarakter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetinAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetinAlani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalanKarakter;
    }
}