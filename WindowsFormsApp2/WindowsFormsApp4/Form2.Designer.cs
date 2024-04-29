namespace WindowsFormsApp4
{
    partial class Form2
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
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxSirketAd = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelSirketAd = new System.Windows.Forms.Label();
            this.textBoxSirketId = new System.Windows.Forms.TextBox();
            this.labelSirketId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(89, 152);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonGuncelle.TabIndex = 9;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(120, 110);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelefon.TabIndex = 8;
            // 
            // textBoxSirketAd
            // 
            this.textBoxSirketAd.Location = new System.Drawing.Point(120, 68);
            this.textBoxSirketAd.Name = "textBoxSirketAd";
            this.textBoxSirketAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxSirketAd.TabIndex = 7;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(31, 110);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(56, 16);
            this.labelTelefon.TabIndex = 6;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelSirketAd
            // 
            this.labelSirketAd.AutoSize = true;
            this.labelSirketAd.Location = new System.Drawing.Point(31, 68);
            this.labelSirketAd.Name = "labelSirketAd";
            this.labelSirketAd.Size = new System.Drawing.Size(64, 16);
            this.labelSirketAd.TabIndex = 5;
            this.labelSirketAd.Text = "Şirket Ad:";
            // 
            // textBoxSirketId
            // 
            this.textBoxSirketId.Location = new System.Drawing.Point(120, 31);
            this.textBoxSirketId.Name = "textBoxSirketId";
            this.textBoxSirketId.Size = new System.Drawing.Size(100, 22);
            this.textBoxSirketId.TabIndex = 11;
            // 
            // labelSirketId
            // 
            this.labelSirketId.AutoSize = true;
            this.labelSirketId.Location = new System.Drawing.Point(31, 31);
            this.labelSirketId.Name = "labelSirketId";
            this.labelSirketId.Size = new System.Drawing.Size(58, 16);
            this.labelSirketId.TabIndex = 10;
            this.labelSirketId.Text = "Şirket Id:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 194);
            this.Controls.Add(this.textBoxSirketId);
            this.Controls.Add(this.labelSirketId);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxSirketAd);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelSirketAd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxSirketAd;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelSirketAd;
        private System.Windows.Forms.TextBox textBoxSirketId;
        private System.Windows.Forms.Label labelSirketId;
    }
}