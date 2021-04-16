
namespace RandomNumberFileWR
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.randomNumberCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.numberCountLabel = new System.Windows.Forms.Label();
            this.numberCountLabelTitle = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalLabelTitle = new System.Windows.Forms.Label();
            this.randomNumbersListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveToFileButton);
            this.groupBox1.Controls.Add(this.randomNumberCountTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write To File";
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(107, 119);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(141, 51);
            this.saveToFileButton.TabIndex = 2;
            this.saveToFileButton.Text = "Save To File";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // randomNumberCountTextBox
            // 
            this.randomNumberCountTextBox.Location = new System.Drawing.Point(185, 73);
            this.randomNumberCountTextBox.Name = "randomNumberCountTextBox";
            this.randomNumberCountTextBox.Size = new System.Drawing.Size(100, 23);
            this.randomNumberCountTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number Count:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readFileButton);
            this.groupBox2.Controls.Add(this.numberCountLabel);
            this.groupBox2.Controls.Add(this.numberCountLabelTitle);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.totalLabelTitle);
            this.groupBox2.Controls.Add(this.randomNumbersListBox);
            this.groupBox2.Location = new System.Drawing.Point(411, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read From File";
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(117, 163);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(129, 38);
            this.readFileButton.TabIndex = 5;
            this.readFileButton.Text = "Read File Info";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // numberCountLabel
            // 
            this.numberCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberCountLabel.Location = new System.Drawing.Point(117, 123);
            this.numberCountLabel.Name = "numberCountLabel";
            this.numberCountLabel.Size = new System.Drawing.Size(100, 23);
            this.numberCountLabel.TabIndex = 4;
            // 
            // numberCountLabelTitle
            // 
            this.numberCountLabelTitle.AutoSize = true;
            this.numberCountLabelTitle.Location = new System.Drawing.Point(113, 105);
            this.numberCountLabelTitle.Name = "numberCountLabelTitle";
            this.numberCountLabelTitle.Size = new System.Drawing.Size(90, 15);
            this.numberCountLabelTitle.TabIndex = 3;
            this.numberCountLabelTitle.Text = "Number Count:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(117, 48);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 2;
            // 
            // totalLabelTitle
            // 
            this.totalLabelTitle.AutoSize = true;
            this.totalLabelTitle.Location = new System.Drawing.Point(113, 32);
            this.totalLabelTitle.Name = "totalLabelTitle";
            this.totalLabelTitle.Size = new System.Drawing.Size(35, 15);
            this.totalLabelTitle.TabIndex = 1;
            this.totalLabelTitle.Text = "Total:";
            // 
            // randomNumbersListBox
            // 
            this.randomNumbersListBox.FormattingEnabled = true;
            this.randomNumbersListBox.ItemHeight = 15;
            this.randomNumbersListBox.Location = new System.Drawing.Point(26, 32);
            this.randomNumbersListBox.Name = "randomNumbersListBox";
            this.randomNumbersListBox.Size = new System.Drawing.Size(67, 169);
            this.randomNumbersListBox.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialbog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.TextBox randomNumberCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox randomNumbersListBox;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Label numberCountLabel;
        private System.Windows.Forms.Label numberCountLabelTitle;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalLabelTitle;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

