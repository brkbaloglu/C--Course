namespace WindowsFormsApp4
{
    partial class Form3
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
            this.textBoxSirketId = new System.Windows.Forms.TextBox();
            this.labelSirketId = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSirketId
            // 
            this.textBoxSirketId.Location = new System.Drawing.Point(126, 35);
            this.textBoxSirketId.Name = "textBoxSirketId";
            this.textBoxSirketId.Size = new System.Drawing.Size(100, 22);
            this.textBoxSirketId.TabIndex = 18;
            // 
            // labelSirketId
            // 
            this.labelSirketId.AutoSize = true;
            this.labelSirketId.Location = new System.Drawing.Point(37, 35);
            this.labelSirketId.Name = "labelSirketId";
            this.labelSirketId.Size = new System.Drawing.Size(58, 16);
            this.labelSirketId.TabIndex = 17;
            this.labelSirketId.Text = "Şirket Id:";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(87, 96);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 16;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 201);
            this.Controls.Add(this.textBoxSirketId);
            this.Controls.Add(this.labelSirketId);
            this.Controls.Add(this.buttonSil);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSirketId;
        private System.Windows.Forms.Label labelSirketId;
        private System.Windows.Forms.Button buttonSil;
    }
}