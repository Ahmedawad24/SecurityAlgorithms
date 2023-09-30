/*
 * Created by SharpDevelop.
 * User: Gia
 * Date: 3/17/2018
 * Time: 9:12 AM
 * 
 */
namespace Playfair
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupInput;
		private System.Windows.Forms.GroupBox groupKey;
		private System.Windows.Forms.GroupBox groupOutput;
		private System.Windows.Forms.Button buttonEncrypt;
		private System.Windows.Forms.Button buttonDecrypt;
		private System.Windows.Forms.TextBox inputMessage;
		private System.Windows.Forms.TextBox textBoxKey;
		private System.Windows.Forms.TextBox inputKey;
		private System.Windows.Forms.TextBox output;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.inputMessage = new System.Windows.Forms.TextBox();
            this.groupKey = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.inputKey = new System.Windows.Forms.TextBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.groupInput.SuspendLayout();
            this.groupKey.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.inputMessage);
            this.groupInput.Location = new System.Drawing.Point(16, 15);
            this.groupInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupInput.Name = "groupInput";
            this.groupInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupInput.Size = new System.Drawing.Size(315, 123);
            this.groupInput.TabIndex = 0;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Input";
            // 
            // inputMessage
            // 
            this.inputMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputMessage.Location = new System.Drawing.Point(8, 23);
            this.inputMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputMessage.Multiline = true;
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(297, 91);
            this.inputMessage.TabIndex = 0;
            // 
            // groupKey
            // 
            this.groupKey.Controls.Add(this.textBoxKey);
            this.groupKey.Controls.Add(this.inputKey);
            this.groupKey.Location = new System.Drawing.Point(339, 15);
            this.groupKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupKey.Name = "groupKey";
            this.groupKey.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupKey.Size = new System.Drawing.Size(355, 169);
            this.groupKey.TabIndex = 1;
            this.groupKey.TabStop = false;
            this.groupKey.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(89, 55);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(181, 105);
            this.textBoxKey.TabIndex = 2;
            this.textBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // inputKey
            // 
            this.inputKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputKey.Location = new System.Drawing.Point(8, 23);
            this.inputKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(337, 22);
            this.inputKey.TabIndex = 1;
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.output);
            this.groupOutput.Location = new System.Drawing.Point(16, 191);
            this.groupOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupOutput.Size = new System.Drawing.Size(677, 153);
            this.groupOutput.TabIndex = 2;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(8, 23);
            this.output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(660, 121);
            this.output.TabIndex = 0;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(24, 145);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(131, 38);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(180, 145);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(143, 38);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 358);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupKey);
            this.Controls.Add(this.groupInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Playfair";
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupKey.ResumeLayout(false);
            this.groupKey.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
