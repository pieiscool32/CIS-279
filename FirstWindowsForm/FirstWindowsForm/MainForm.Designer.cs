namespace FirstWindowsForm
{
    partial class MainForm
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
            this.decripted = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.encrypted = new System.Windows.Forms.TextBox();
            this.decript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decripted
            // 
            this.decripted.Location = new System.Drawing.Point(69, 66);
            this.decripted.Name = "decripted";
            this.decripted.Size = new System.Drawing.Size(152, 20);
            this.decripted.TabIndex = 0;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(55, 122);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 1;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // encrypted
            // 
            this.encrypted.Location = new System.Drawing.Point(69, 178);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(152, 20);
            this.encrypted.TabIndex = 2;
            // 
            // decript
            // 
            this.decript.Location = new System.Drawing.Point(159, 122);
            this.decript.Name = "decript";
            this.decript.Size = new System.Drawing.Size(75, 23);
            this.decript.TabIndex = 3;
            this.decript.Text = "Decrypt";
            this.decript.UseVisualStyleBackColor = true;
            this.decript.Click += new System.EventHandler(this.decript_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.decript);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decripted);
            this.Name = "MainForm";
            this.Text = "First Form Made";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox decripted;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox encrypted;
        private System.Windows.Forms.Button decript;
    }
}

