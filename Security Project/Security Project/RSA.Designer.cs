
namespace RSA_Encryption_Decryption
{
    partial class RSA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.notice = new System.Windows.Forms.Label();
            this.NProduct = new System.Windows.Forms.Label();
            this.CalculateNButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EUProduct = new System.Windows.Forms.Label();
            this.EUButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.eProduct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eButton = new System.Windows.Forms.Button();
            this.EText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.DButton = new System.Windows.Forms.Button();
            this.EncryptText = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptText = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PLabel.Location = new System.Drawing.Point(8, 26);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(50, 28);
            this.PLabel.TabIndex = 0;
            this.PLabel.Text = "P = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Q = ";
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NLabel.Location = new System.Drawing.Point(8, 119);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(54, 28);
            this.NLabel.TabIndex = 2;
            this.NLabel.Text = "N = ";
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(65, 30);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(68, 23);
            this.PTextBox.TabIndex = 3;
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(65, 73);
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(68, 23);
            this.QTextBox.TabIndex = 4;
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notice.Location = new System.Drawing.Point(8, 0);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(262, 17);
            this.notice.TabIndex = 5;
            this.notice.Text = "[Note: P and Q MUST be prime numbers]";
            // 
            // NProduct
            // 
            this.NProduct.AutoSize = true;
            this.NProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NProduct.Location = new System.Drawing.Point(56, 128);
            this.NProduct.Name = "NProduct";
            this.NProduct.Size = new System.Drawing.Size(15, 17);
            this.NProduct.TabIndex = 6;
            this.NProduct.Text = "0";
            this.NProduct.Click += new System.EventHandler(this.NProduct_Click);
            // 
            // CalculateNButton
            // 
            this.CalculateNButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CalculateNButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateNButton.ForeColor = System.Drawing.Color.Black;
            this.CalculateNButton.Location = new System.Drawing.Point(54, 162);
            this.CalculateNButton.Name = "CalculateNButton";
            this.CalculateNButton.Size = new System.Drawing.Size(103, 23);
            this.CalculateNButton.TabIndex = 7;
            this.CalculateNButton.Text = "Calculate N";
            this.CalculateNButton.UseVisualStyleBackColor = false;
            this.CalculateNButton.Click += new System.EventHandler(this.CalculateNButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eu Function = ";
            // 
            // EUProduct
            // 
            this.EUProduct.AutoSize = true;
            this.EUProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EUProduct.Location = new System.Drawing.Point(149, 210);
            this.EUProduct.Name = "EUProduct";
            this.EUProduct.Size = new System.Drawing.Size(15, 17);
            this.EUProduct.TabIndex = 9;
            this.EUProduct.Text = "0";
            // 
            // EUButton
            // 
            this.EUButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EUButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EUButton.Location = new System.Drawing.Point(56, 242);
            this.EUButton.Name = "EUButton";
            this.EUButton.Size = new System.Drawing.Size(110, 23);
            this.EUButton.TabIndex = 10;
            this.EUButton.Text = "Calculate EU";
            this.EUButton.UseVisualStyleBackColor = false;
            this.EUButton.Click += new System.EventHandler(this.EUButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "e = ";
            // 
            // eProduct
            // 
            this.eProduct.AutoSize = true;
            this.eProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eProduct.Location = new System.Drawing.Point(56, 287);
            this.eProduct.Name = "eProduct";
            this.eProduct.Size = new System.Drawing.Size(15, 17);
            this.eProduct.TabIndex = 12;
            this.eProduct.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(147, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "so that:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(207, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "gcd(e , EU(N)) = 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(207, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "1 < e < Eu (N)";
            // 
            // eButton
            // 
            this.eButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.eButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eButton.Location = new System.Drawing.Point(58, 340);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(108, 23);
            this.eButton.TabIndex = 16;
            this.eButton.Text = "Calculate e";
            this.eButton.UseVisualStyleBackColor = false;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // EText
            // 
            this.EText.Location = new System.Drawing.Point(77, 300);
            this.EText.Name = "EText";
            this.EText.Size = new System.Drawing.Size(54, 23);
            this.EText.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "D = ";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DLabel.Location = new System.Drawing.Point(63, 377);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(24, 28);
            this.DLabel.TabIndex = 19;
            this.DLabel.Text = "0";
            // 
            // DButton
            // 
            this.DButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DButton.Location = new System.Drawing.Point(58, 408);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(128, 23);
            this.DButton.TabIndex = 20;
            this.DButton.Text = "Genarate D";
            this.DButton.UseVisualStyleBackColor = false;
            this.DButton.Click += new System.EventHandler(this.DButton_Click);
            // 
            // EncryptText
            // 
            this.EncryptText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptText.Location = new System.Drawing.Point(430, 103);
            this.EncryptText.Multiline = true;
            this.EncryptText.Name = "EncryptText";
            this.EncryptText.Size = new System.Drawing.Size(358, 67);
            this.EncryptText.TabIndex = 21;
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EncryptButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptButton.Location = new System.Drawing.Point(558, 198);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(92, 67);
            this.EncryptButton.TabIndex = 22;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptText
            // 
            this.DecryptText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecryptText.Location = new System.Drawing.Point(430, 286);
            this.DecryptText.Multiline = true;
            this.DecryptText.Name = "DecryptText";
            this.DecryptText.Size = new System.Drawing.Size(358, 67);
            this.DecryptText.TabIndex = 23;
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DecryptButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecryptButton.Location = new System.Drawing.Point(558, 364);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(92, 67);
            this.DecryptButton.TabIndex = 24;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(347, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Please insert Message to Encrypt or Ciphertext to Decrypt :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.DecryptText);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.EncryptText);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EText);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EUButton);
            this.Controls.Add(this.EUProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateNButton);
            this.Controls.Add(this.NProduct);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Label NProduct;
        private System.Windows.Forms.Button CalculateNButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EUProduct;
        private System.Windows.Forms.Button EUButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label eProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.TextBox EText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.TextBox EncryptText;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox DecryptText;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label label8;
    }
}

