
namespace Security_Project
{
    partial class SDESForm
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
            this.textLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.p10Label = new System.Windows.Forms.Label();
            this.p10TextBox = new System.Windows.Forms.TextBox();
            this.p8Label = new System.Windows.Forms.Label();
            this.p8TextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.epLabel = new System.Windows.Forms.Label();
            this.epTextBox = new System.Windows.Forms.TextBox();
            this.p4Label = new System.Windows.Forms.Label();
            this.p4TextBox = new System.Windows.Forms.TextBox();
            this.s0Label = new System.Windows.Forms.Label();
            this.s0DataGridView = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s1Label = new System.Windows.Forms.Label();
            this.s1DataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.s0DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(16, 20);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(44, 17);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Text:";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(73, 16);
            this.textTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.textTextBox.MaxLength = 8;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(280, 22);
            this.textTextBox.TabIndex = 1;
            this.textTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTextBox_KeyPress);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(16, 53);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(40, 17);
            this.keyLabel.TabIndex = 2;
            this.keyLabel.Text = "Key:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(73, 49);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.keyTextBox.MaxLength = 10;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(280, 22);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTextBox_KeyPress);
            // 
            // p10Label
            // 
            this.p10Label.AutoSize = true;
            this.p10Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10Label.Location = new System.Drawing.Point(16, 85);
            this.p10Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p10Label.Name = "p10Label";
            this.p10Label.Size = new System.Drawing.Size(41, 17);
            this.p10Label.TabIndex = 4;
            this.p10Label.Text = "P10:";
            // 
            // p10TextBox
            // 
            this.p10TextBox.Location = new System.Drawing.Point(73, 81);
            this.p10TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.p10TextBox.MaxLength = 20;
            this.p10TextBox.Name = "p10TextBox";
            this.p10TextBox.Size = new System.Drawing.Size(280, 22);
            this.p10TextBox.TabIndex = 5;
            this.p10TextBox.Text = "3 5 2 7 4 10 1 9 8 6";
            this.p10TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p10TextBox_KeyPress);
            // 
            // p8Label
            // 
            this.p8Label.AutoSize = true;
            this.p8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p8Label.Location = new System.Drawing.Point(16, 117);
            this.p8Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p8Label.Name = "p8Label";
            this.p8Label.Size = new System.Drawing.Size(32, 17);
            this.p8Label.TabIndex = 6;
            this.p8Label.Text = "P8:";
            // 
            // p8TextBox
            // 
            this.p8TextBox.Location = new System.Drawing.Point(73, 113);
            this.p8TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.p8TextBox.MaxLength = 16;
            this.p8TextBox.Name = "p8TextBox";
            this.p8TextBox.Size = new System.Drawing.Size(280, 22);
            this.p8TextBox.TabIndex = 7;
            this.p8TextBox.Text = "6 3 7 4 8 5 10 9";
            this.p8TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p8TextBox_KeyPress);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(16, 149);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(27, 17);
            this.ipLabel.TabIndex = 8;
            this.ipLabel.Text = "IP:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(73, 145);
            this.ipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipTextBox.MaxLength = 15;
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(280, 22);
            this.ipTextBox.TabIndex = 9;
            this.ipTextBox.Text = "2 6 3 1 4 8 5 7";
            this.ipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipTextBox_KeyPress);
            // 
            // epLabel
            // 
            this.epLabel.AutoSize = true;
            this.epLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epLabel.Location = new System.Drawing.Point(16, 182);
            this.epLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.epLabel.Name = "epLabel";
            this.epLabel.Size = new System.Drawing.Size(33, 17);
            this.epLabel.TabIndex = 10;
            this.epLabel.Text = "EP:";
            // 
            // epTextBox
            // 
            this.epTextBox.Location = new System.Drawing.Point(73, 178);
            this.epTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.epTextBox.MaxLength = 15;
            this.epTextBox.Name = "epTextBox";
            this.epTextBox.Size = new System.Drawing.Size(280, 22);
            this.epTextBox.TabIndex = 11;
            this.epTextBox.Text = "4 1 2 3 2 3 4 1";
            this.epTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epTextBox_KeyPress);
            // 
            // p4Label
            // 
            this.p4Label.AutoSize = true;
            this.p4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4Label.Location = new System.Drawing.Point(16, 214);
            this.p4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p4Label.Name = "p4Label";
            this.p4Label.Size = new System.Drawing.Size(32, 17);
            this.p4Label.TabIndex = 12;
            this.p4Label.Text = "P4:";
            // 
            // p4TextBox
            // 
            this.p4TextBox.Location = new System.Drawing.Point(73, 210);
            this.p4TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.p4TextBox.MaxLength = 7;
            this.p4TextBox.Name = "p4TextBox";
            this.p4TextBox.Size = new System.Drawing.Size(280, 22);
            this.p4TextBox.TabIndex = 13;
            this.p4TextBox.Text = "2 4 3 1";
            this.p4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p4TextBox_KeyPress);
            // 
            // s0Label
            // 
            this.s0Label.AutoSize = true;
            this.s0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s0Label.Location = new System.Drawing.Point(16, 247);
            this.s0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s0Label.Name = "s0Label";
            this.s0Label.Size = new System.Drawing.Size(32, 17);
            this.s0Label.TabIndex = 14;
            this.s0Label.Text = "S0:";
            // 
            // s0DataGridView
            // 
            this.s0DataGridView.AllowUserToAddRows = false;
            this.s0DataGridView.AllowUserToDeleteRows = false;
            this.s0DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.s0DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3});
            this.s0DataGridView.Location = new System.Drawing.Point(20, 267);
            this.s0DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.s0DataGridView.Name = "s0DataGridView";
            this.s0DataGridView.RowHeadersWidth = 51;
            this.s0DataGridView.Size = new System.Drawing.Size(335, 133);
            this.s0DataGridView.TabIndex = 15;
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column0.HeaderText = "0";
            this.Column0.MinimumWidth = 6;
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // s1Label
            // 
            this.s1Label.AutoSize = true;
            this.s1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1Label.Location = new System.Drawing.Point(20, 414);
            this.s1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s1Label.Name = "s1Label";
            this.s1Label.Size = new System.Drawing.Size(32, 17);
            this.s1Label.TabIndex = 16;
            this.s1Label.Text = "S1:";
            // 
            // s1DataGridView
            // 
            this.s1DataGridView.AllowUserToAddRows = false;
            this.s1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.s1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.s1DataGridView.Location = new System.Drawing.Point(20, 434);
            this.s1DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.s1DataGridView.Name = "s1DataGridView";
            this.s1DataGridView.RowHeadersWidth = 51;
            this.s1DataGridView.Size = new System.Drawing.Size(335, 133);
            this.s1DataGridView.TabIndex = 17;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "0";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "1";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "2";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "3";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // encryptButton
            // 
            this.encryptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.encryptButton.Location = new System.Drawing.Point(0, 617);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(1091, 28);
            this.encryptButton.TabIndex = 18;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.decryptButton.Location = new System.Drawing.Point(0, 589);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(1091, 28);
            this.decryptButton.TabIndex = 19;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStep,
            this.ColumnBefore,
            this.ColumnAfter});
            this.resultsDataGridView.Location = new System.Drawing.Point(362, 16);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.RowHeadersWidth = 51;
            this.resultsDataGridView.RowTemplate.Height = 24;
            this.resultsDataGridView.Size = new System.Drawing.Size(717, 551);
            this.resultsDataGridView.TabIndex = 20;
            // 
            // ColumnStep
            // 
            this.ColumnStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStep.HeaderText = "Step";
            this.ColumnStep.MinimumWidth = 6;
            this.ColumnStep.Name = "ColumnStep";
            this.ColumnStep.ReadOnly = true;
            // 
            // ColumnBefore
            // 
            this.ColumnBefore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBefore.HeaderText = "Before";
            this.ColumnBefore.MinimumWidth = 6;
            this.ColumnBefore.Name = "ColumnBefore";
            this.ColumnBefore.ReadOnly = true;
            // 
            // ColumnAfter
            // 
            this.ColumnAfter.HeaderText = "After";
            this.ColumnAfter.MinimumWidth = 6;
            this.ColumnAfter.Name = "ColumnAfter";
            this.ColumnAfter.ReadOnly = true;
            this.ColumnAfter.Width = 125;
            // 
            // SDESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 645);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.s1DataGridView);
            this.Controls.Add(this.s1Label);
            this.Controls.Add(this.s0DataGridView);
            this.Controls.Add(this.s0Label);
            this.Controls.Add(this.p4TextBox);
            this.Controls.Add(this.p4Label);
            this.Controls.Add(this.epTextBox);
            this.Controls.Add(this.epLabel);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.p8TextBox);
            this.Controls.Add(this.p8Label);
            this.Controls.Add(this.p10TextBox);
            this.Controls.Add(this.p10Label);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.textLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SDESForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDESForm";
            this.Load += new System.EventHandler(this.SDESForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s0DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label p10Label;
        private System.Windows.Forms.TextBox p10TextBox;
        private System.Windows.Forms.Label p8Label;
        private System.Windows.Forms.TextBox p8TextBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label epLabel;
        private System.Windows.Forms.TextBox epTextBox;
        private System.Windows.Forms.Label p4Label;
        private System.Windows.Forms.TextBox p4TextBox;
        private System.Windows.Forms.Label s0Label;
        private System.Windows.Forms.DataGridView s0DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label s1Label;
        private System.Windows.Forms.DataGridView s1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAfter;
    }
}