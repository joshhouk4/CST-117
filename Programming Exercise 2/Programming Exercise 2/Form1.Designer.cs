using System;

namespace Programming_Exercise_2
{
    partial class shapeMakerForm
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
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.fillGroupBox = new System.Windows.Forms.GroupBox();
            this.outlineRadioButton = new System.Windows.Forms.RadioButton();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.detailGroupBox = new System.Windows.Forms.GroupBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.shapePictureBox = new System.Windows.Forms.PictureBox();
            this.selectedShapeLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fillGroupBox.SuspendLayout();
            this.detailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeListBox
            // 
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle",
            "Pentagon",
            "Hexagon"});
            this.shapeListBox.Location = new System.Drawing.Point(53, 50);
            this.shapeListBox.Name = "shapeListBox";
            this.shapeListBox.Size = new System.Drawing.Size(135, 69);
            this.shapeListBox.TabIndex = 0;
            this.shapeListBox.SelectedIndexChanged += new System.EventHandler(this.shapeListBox_SelectedIndexChanged);
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(50, 34);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(78, 13);
            this.shapeLabel.TabIndex = 1;
            this.shapeLabel.Text = "Select a shape";
            this.shapeLabel.Click += new System.EventHandler(this.shapeLabel_Click);
            // 
            // fillGroupBox
            // 
            this.fillGroupBox.Controls.Add(this.outlineRadioButton);
            this.fillGroupBox.Controls.Add(this.fillRadioButton);
            this.fillGroupBox.Location = new System.Drawing.Point(53, 148);
            this.fillGroupBox.Name = "fillGroupBox";
            this.fillGroupBox.Size = new System.Drawing.Size(135, 83);
            this.fillGroupBox.TabIndex = 2;
            this.fillGroupBox.TabStop = false;
            this.fillGroupBox.Text = "Select fill mode";
            // 
            // outlineRadioButton
            // 
            this.outlineRadioButton.AutoSize = true;
            this.outlineRadioButton.Location = new System.Drawing.Point(6, 42);
            this.outlineRadioButton.Name = "outlineRadioButton";
            this.outlineRadioButton.Size = new System.Drawing.Size(58, 17);
            this.outlineRadioButton.TabIndex = 1;
            this.outlineRadioButton.Text = "Outline";
            this.outlineRadioButton.UseVisualStyleBackColor = true;
            this.outlineRadioButton.CheckedChanged += new System.EventHandler(this.outlineRadioButton_CheckedChanged);
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.AutoSize = true;
            this.fillRadioButton.Location = new System.Drawing.Point(6, 19);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(37, 17);
            this.fillRadioButton.TabIndex = 0;
            this.fillRadioButton.Text = "Fill";
            this.fillRadioButton.UseVisualStyleBackColor = true;
            this.fillRadioButton.CheckedChanged += new System.EventHandler(this.fillRadioButton_CheckedChanged);
            // 
            // detailGroupBox
            // 
            this.detailGroupBox.Controls.Add(this.dateCheckBox);
            this.detailGroupBox.Controls.Add(this.nameCheckBox);
            this.detailGroupBox.Location = new System.Drawing.Point(53, 256);
            this.detailGroupBox.Name = "detailGroupBox";
            this.detailGroupBox.Size = new System.Drawing.Size(135, 83);
            this.detailGroupBox.TabIndex = 3;
            this.detailGroupBox.TabStop = false;
            this.detailGroupBox.Text = "Select Detail";
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(6, 42);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dateCheckBox.TabIndex = 1;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(6, 19);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // shapePictureBox
            // 
            this.shapePictureBox.Location = new System.Drawing.Point(310, 50);
            this.shapePictureBox.Name = "shapePictureBox";
            this.shapePictureBox.Size = new System.Drawing.Size(264, 181);
            this.shapePictureBox.TabIndex = 4;
            this.shapePictureBox.TabStop = false;
            // 
            // selectedShapeLabel
            // 
            this.selectedShapeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedShapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedShapeLabel.Location = new System.Drawing.Point(310, 256);
            this.selectedShapeLabel.Name = "selectedShapeLabel";
            this.selectedShapeLabel.Size = new System.Drawing.Size(264, 36);
            this.selectedShapeLabel.TabIndex = 5;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(159, 357);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 44);
            this.drawButton.TabIndex = 6;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(268, 357);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 44);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(382, 357);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 44);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(310, 292);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(264, 36);
            this.dateLabel.TabIndex = 9;
            // 
            // shapeMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 422);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.selectedShapeLabel);
            this.Controls.Add(this.shapePictureBox);
            this.Controls.Add(this.detailGroupBox);
            this.Controls.Add(this.fillGroupBox);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.shapeListBox);
            this.Name = "shapeMakerForm";
            this.Text = "Shape Maker";
            this.Load += new System.EventHandler(this.shapeMakerForm_Load);
            this.fillGroupBox.ResumeLayout(false);
            this.fillGroupBox.PerformLayout();
            this.detailGroupBox.ResumeLayout(false);
            this.detailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shapeListBox;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.GroupBox fillGroupBox;
        private System.Windows.Forms.RadioButton outlineRadioButton;
        private System.Windows.Forms.RadioButton fillRadioButton;
        private System.Windows.Forms.GroupBox detailGroupBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.PictureBox shapePictureBox;
        private System.Windows.Forms.Label selectedShapeLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dateLabel;
        private readonly EventHandler nameCheckBox_CheckedChanged;
        private readonly EventHandler dateCheckBox_CheckedChanged;
    }
}

