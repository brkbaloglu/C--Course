namespace WindowsFormsApp3
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
            this.labelKategoriler = new System.Windows.Forms.Label();
            this.labelUrunler = new System.Windows.Forms.Label();
            this.comboBoxKategoriler = new System.Windows.Forms.ComboBox();
            this.comboBoxUrunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKategoriler
            // 
            this.labelKategoriler.AutoSize = true;
            this.labelKategoriler.Location = new System.Drawing.Point(20, 30);
            this.labelKategoriler.Name = "labelKategoriler";
            this.labelKategoriler.Size = new System.Drawing.Size(72, 16);
            this.labelKategoriler.TabIndex = 0;
            this.labelKategoriler.Text = "Kategoriler";
            // 
            // labelUrunler
            // 
            this.labelUrunler.AutoSize = true;
            this.labelUrunler.Location = new System.Drawing.Point(20, 91);
            this.labelUrunler.Name = "labelUrunler";
            this.labelUrunler.Size = new System.Drawing.Size(50, 16);
            this.labelUrunler.TabIndex = 1;
            this.labelUrunler.Text = "Ürünler";
            // 
            // comboBoxKategoriler
            // 
            this.comboBoxKategoriler.FormattingEnabled = true;
            this.comboBoxKategoriler.Location = new System.Drawing.Point(23, 64);
            this.comboBoxKategoriler.Name = "comboBoxKategoriler";
            this.comboBoxKategoriler.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKategoriler.TabIndex = 2;
            // 
            // comboBoxUrunler
            // 
            this.comboBoxUrunler.FormattingEnabled = true;
            this.comboBoxUrunler.Location = new System.Drawing.Point(23, 120);
            this.comboBoxUrunler.Name = "comboBoxUrunler";
            this.comboBoxUrunler.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUrunler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birim Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok Adet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUrunler);
            this.Controls.Add(this.comboBoxKategoriler);
            this.Controls.Add(this.labelUrunler);
            this.Controls.Add(this.labelKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKategoriler;
        private System.Windows.Forms.Label labelUrunler;
        private System.Windows.Forms.ComboBox comboBoxKategoriler;
        private System.Windows.Forms.ComboBox comboBoxUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

