namespace WindowsFormsApp4
{
    partial class Form1
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
            this.labelSirketAd = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxSirketAd = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSirketAd
            // 
            this.labelSirketAd.AutoSize = true;
            this.labelSirketAd.Location = new System.Drawing.Point(25, 46);
            this.labelSirketAd.Name = "labelSirketAd";
            this.labelSirketAd.Size = new System.Drawing.Size(64, 16);
            this.labelSirketAd.TabIndex = 0;
            this.labelSirketAd.Text = "Şirket Ad:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(25, 88);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(56, 16);
            this.labelTelefon.TabIndex = 1;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxSirketAd
            // 
            this.textBoxSirketAd.Location = new System.Drawing.Point(114, 46);
            this.textBoxSirketAd.Name = "textBoxSirketAd";
            this.textBoxSirketAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxSirketAd.TabIndex = 2;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(114, 88);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelefon.TabIndex = 3;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(139, 138);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 4;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 224);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxSirketAd);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelSirketAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSirketAd;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxSirketAd;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Button buttonEkle;
    }
}

