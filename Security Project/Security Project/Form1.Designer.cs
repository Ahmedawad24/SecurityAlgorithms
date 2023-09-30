
namespace Security_Project
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
            this.playfairButton = new System.Windows.Forms.Button();
            this.SDESButton = new System.Windows.Forms.Button();
            this.SAESButton = new System.Windows.Forms.Button();
            this.simplifiedRC4Button = new System.Windows.Forms.Button();
            this.RSAButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playfairButton
            // 
            this.playfairButton.Location = new System.Drawing.Point(13, 121);
            this.playfairButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playfairButton.Name = "playfairButton";
            this.playfairButton.Size = new System.Drawing.Size(404, 28);
            this.playfairButton.TabIndex = 0;
            this.playfairButton.Text = "Playfair";
            this.playfairButton.UseVisualStyleBackColor = true;
            this.playfairButton.Click += new System.EventHandler(this.playfairButton_Click);
            // 
            // SDESButton
            // 
            this.SDESButton.Location = new System.Drawing.Point(13, 13);
            this.SDESButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SDESButton.Name = "SDESButton";
            this.SDESButton.Size = new System.Drawing.Size(404, 28);
            this.SDESButton.TabIndex = 1;
            this.SDESButton.Text = "S-DES";
            this.SDESButton.UseVisualStyleBackColor = true;
            this.SDESButton.Click += new System.EventHandler(this.SDESButton_Click);
            // 
            // SAESButton
            // 
            this.SAESButton.Location = new System.Drawing.Point(13, 85);
            this.SAESButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SAESButton.Name = "SAESButton";
            this.SAESButton.Size = new System.Drawing.Size(404, 28);
            this.SAESButton.TabIndex = 2;
            this.SAESButton.Text = "S-AES";
            this.SAESButton.UseVisualStyleBackColor = true;
            this.SAESButton.Click += new System.EventHandler(this.SAESButton_Click);
            // 
            // simplifiedRC4Button
            // 
            this.simplifiedRC4Button.Location = new System.Drawing.Point(13, 49);
            this.simplifiedRC4Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simplifiedRC4Button.Name = "simplifiedRC4Button";
            this.simplifiedRC4Button.Size = new System.Drawing.Size(404, 28);
            this.simplifiedRC4Button.TabIndex = 3;
            this.simplifiedRC4Button.Text = "Simplified RC4";
            this.simplifiedRC4Button.UseVisualStyleBackColor = true;
            this.simplifiedRC4Button.Click += new System.EventHandler(this.simplifiedRC4Button_Click);
            // 
            // RSAButton
            // 
            this.RSAButton.Location = new System.Drawing.Point(10, 157);
            this.RSAButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RSAButton.Name = "RSAButton";
            this.RSAButton.Size = new System.Drawing.Size(404, 28);
            this.RSAButton.TabIndex = 4;
            this.RSAButton.Text = "RSA";
            this.RSAButton.UseVisualStyleBackColor = true;
            this.RSAButton.Click += new System.EventHandler(this.RSAButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 200);
            this.Controls.Add(this.RSAButton);
            this.Controls.Add(this.simplifiedRC4Button);
            this.Controls.Add(this.SAESButton);
            this.Controls.Add(this.SDESButton);
            this.Controls.Add(this.playfairButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playfairButton;
        private System.Windows.Forms.Button SDESButton;
        private System.Windows.Forms.Button SAESButton;
        private System.Windows.Forms.Button simplifiedRC4Button;
        private System.Windows.Forms.Button RSAButton;
    }
}

