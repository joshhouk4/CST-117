namespace Programming_Project_3
{
    partial class wordApp
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
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.wordsFoundLabel = new System.Windows.Forms.Label();
            this.firstWordLabel = new System.Windows.Forms.Label();
            this.fwLabel = new System.Windows.Forms.Label();
            this.lastWordLabel = new System.Windows.Forms.Label();
            this.lwLabel = new System.Windows.Forms.Label();
            this.lngWordLabel = new System.Windows.Forms.Label();
            this.mVowLabel = new System.Windows.Forms.Label();
            this.longestWordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileLabel.Location = new System.Drawing.Point(36, 30);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(100, 20);
            this.selectFileLabel.TabIndex = 0;
            this.selectFileLabel.Text = "Select a File:";
            this.selectFileLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fileLabel
            // 
            this.fileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.Location = new System.Drawing.Point(142, 30);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(247, 23);
            this.fileLabel.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(395, 30);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(126, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // wordsFoundLabel
            // 
            this.wordsFoundLabel.AutoSize = true;
            this.wordsFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsFoundLabel.Location = new System.Drawing.Point(27, 67);
            this.wordsFoundLabel.Name = "wordsFoundLabel";
            this.wordsFoundLabel.Size = new System.Drawing.Size(109, 20);
            this.wordsFoundLabel.TabIndex = 3;
            this.wordsFoundLabel.Text = "Words Found:";
            this.wordsFoundLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstWordLabel
            // 
            this.firstWordLabel.AutoSize = true;
            this.firstWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstWordLabel.Location = new System.Drawing.Point(10, 235);
            this.firstWordLabel.Name = "firstWordLabel";
            this.firstWordLabel.Size = new System.Drawing.Size(126, 20);
            this.firstWordLabel.TabIndex = 5;
            this.firstWordLabel.Text = "First Alph. Word:";
            this.firstWordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fwLabel
            // 
            this.fwLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwLabel.Location = new System.Drawing.Point(142, 232);
            this.fwLabel.Name = "fwLabel";
            this.fwLabel.Size = new System.Drawing.Size(247, 23);
            this.fwLabel.TabIndex = 6;
            // 
            // lastWordLabel
            // 
            this.lastWordLabel.AutoSize = true;
            this.lastWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastWordLabel.Location = new System.Drawing.Point(10, 270);
            this.lastWordLabel.Name = "lastWordLabel";
            this.lastWordLabel.Size = new System.Drawing.Size(126, 20);
            this.lastWordLabel.TabIndex = 7;
            this.lastWordLabel.Text = "Last Alph. Word:";
            this.lastWordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lwLabel
            // 
            this.lwLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwLabel.Location = new System.Drawing.Point(142, 267);
            this.lwLabel.Name = "lwLabel";
            this.lwLabel.Size = new System.Drawing.Size(247, 23);
            this.lwLabel.TabIndex = 8;
            // 
            // lngWordLabel
            // 
            this.lngWordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lngWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lngWordLabel.Location = new System.Drawing.Point(142, 300);
            this.lngWordLabel.Name = "lngWordLabel";
            this.lngWordLabel.Size = new System.Drawing.Size(247, 23);
            this.lngWordLabel.TabIndex = 9;
            // 
            // mVowLabel
            // 
            this.mVowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mVowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mVowLabel.Location = new System.Drawing.Point(142, 338);
            this.mVowLabel.Name = "mVowLabel";
            this.mVowLabel.Size = new System.Drawing.Size(247, 23);
            this.mVowLabel.TabIndex = 10;
            // 
            // longestWordLabel
            // 
            this.longestWordLabel.AutoSize = true;
            this.longestWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestWordLabel.Location = new System.Drawing.Point(23, 303);
            this.longestWordLabel.Name = "longestWordLabel";
            this.longestWordLabel.Size = new System.Drawing.Size(113, 20);
            this.longestWordLabel.TabIndex = 11;
            this.longestWordLabel.Text = "Longest Word:";
            this.longestWordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Most Vowels:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(142, 416);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(247, 35);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // wordsListBox
            // 
            this.wordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.ItemHeight = 20;
            this.wordsListBox.Location = new System.Drawing.Point(142, 67);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(247, 144);
            this.wordsListBox.TabIndex = 14;
            // 
            // wordApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 463);
            this.Controls.Add(this.wordsListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longestWordLabel);
            this.Controls.Add(this.mVowLabel);
            this.Controls.Add(this.lngWordLabel);
            this.Controls.Add(this.lwLabel);
            this.Controls.Add(this.lastWordLabel);
            this.Controls.Add(this.fwLabel);
            this.Controls.Add(this.firstWordLabel);
            this.Controls.Add(this.wordsFoundLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.selectFileLabel);
            this.Name = "wordApp";
            this.Text = "Word App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectFileLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label wordsFoundLabel;
        private System.Windows.Forms.Label firstWordLabel;
        private System.Windows.Forms.Label fwLabel;
        private System.Windows.Forms.Label lastWordLabel;
        private System.Windows.Forms.Label lwLabel;
        private System.Windows.Forms.Label lngWordLabel;
        private System.Windows.Forms.Label mVowLabel;
        private System.Windows.Forms.Label longestWordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox wordsListBox;
    }
}

