namespace Exercise_6
{
    partial class diceRollForm
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
            this.die1Label = new System.Windows.Forms.Label();
            this.die2Label = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.turnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // die1Label
            // 
            this.die1Label.BackColor = System.Drawing.Color.Lime;
            this.die1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die1Label.Location = new System.Drawing.Point(178, 23);
            this.die1Label.Name = "die1Label";
            this.die1Label.Size = new System.Drawing.Size(100, 103);
            this.die1Label.TabIndex = 0;
            this.die1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // die2Label
            // 
            this.die2Label.BackColor = System.Drawing.Color.Lime;
            this.die2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die2Label.Location = new System.Drawing.Point(284, 23);
            this.die2Label.Name = "die2Label";
            this.die2Label.Size = new System.Drawing.Size(100, 103);
            this.die2Label.TabIndex = 1;
            this.die2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Aqua;
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(12, 23);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(146, 103);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(12, 219);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 36);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(183, 219);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 36);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // turnLabel
            // 
            this.turnLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(12, 162);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(372, 31);
            this.turnLabel.TabIndex = 5;
            // 
            // diceRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 267);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.die2Label);
            this.Controls.Add(this.die1Label);
            this.Name = "diceRollForm";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label die1Label;
        private System.Windows.Forms.Label die2Label;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label turnLabel;
    }
}

