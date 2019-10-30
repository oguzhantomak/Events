namespace Events
{
    partial class Scope
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
            this.btnArtir = new System.Windows.Forms.Button();
            this.btnEksilt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArtir
            // 
            this.btnArtir.Location = new System.Drawing.Point(13, 17);
            this.btnArtir.Name = "btnArtir";
            this.btnArtir.Size = new System.Drawing.Size(150, 39);
            this.btnArtir.TabIndex = 0;
            this.btnArtir.Text = "Artır";
            this.btnArtir.UseVisualStyleBackColor = true;
            this.btnArtir.Click += new System.EventHandler(this.BtnArtir_Click);
            // 
            // btnEksilt
            // 
            this.btnEksilt.Location = new System.Drawing.Point(277, 17);
            this.btnEksilt.Name = "btnEksilt";
            this.btnEksilt.Size = new System.Drawing.Size(150, 39);
            this.btnEksilt.TabIndex = 0;
            this.btnEksilt.Text = "Eksilt";
            this.btnEksilt.UseVisualStyleBackColor = true;
            this.btnEksilt.Click += new System.EventHandler(this.BtnEksilt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEksilt);
            this.Controls.Add(this.btnArtir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArtir;
        private System.Windows.Forms.Button btnEksilt;
        private System.Windows.Forms.Label label1;
    }
}

