namespace Exercise_3
{
    partial class milesToKm
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
            this.milesDrivenLabel = new System.Windows.Forms.Label();
            this.kmDrivenLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.kmLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesDrivenLabel
            // 
            this.milesDrivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesDrivenLabel.Location = new System.Drawing.Point(23, 76);
            this.milesDrivenLabel.Name = "milesDrivenLabel";
            this.milesDrivenLabel.Size = new System.Drawing.Size(211, 26);
            this.milesDrivenLabel.TabIndex = 0;
            this.milesDrivenLabel.Text = "Enter your miles driven:";
            // 
            // kmDrivenLabel
            // 
            this.kmDrivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmDrivenLabel.Location = new System.Drawing.Point(23, 159);
            this.kmDrivenLabel.Name = "kmDrivenLabel";
            this.kmDrivenLabel.Size = new System.Drawing.Size(211, 26);
            this.kmDrivenLabel.TabIndex = 1;
            this.kmDrivenLabel.Text = "Your kilometers driven:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(221, 75);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(220, 20);
            this.milesTextBox.TabIndex = 2;
            // 
            // kmLabel
            // 
            this.kmLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmLabel.Location = new System.Drawing.Point(221, 156);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(220, 23);
            this.kmLabel.TabIndex = 3;
            this.kmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(26, 254);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(171, 38);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(247, 254);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // milesToKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.kmDrivenLabel);
            this.Controls.Add(this.milesDrivenLabel);
            this.Name = "milesToKm";
            this.Text = "Miles to Kilometers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesDrivenLabel;
        private System.Windows.Forms.Label kmDrivenLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

