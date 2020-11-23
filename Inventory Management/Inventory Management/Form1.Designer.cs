namespace Inventory_Management
{

    // My name is Joshua Houk and this is my Inventory Manager Project.

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
            this.addButton = new System.Windows.Forms.Button();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pnLabel = new System.Windows.Forms.Label();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantTextBox = new System.Windows.Forms.TextBox();
            this.quantLabel = new System.Windows.Forms.Label();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.namePartNumberLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.priceUpdateTextBox = new System.Windows.Forms.TextBox();
            this.quantUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.price2Label = new System.Windows.Forms.Label();
            this.quant2Label = new System.Windows.Forms.Label();
            this.pn2Label = new System.Windows.Forms.Label();
            this.name2Label = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addGroupBox.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(58, 136);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.itemNameLabel);
            this.addGroupBox.Controls.Add(this.nameTextBox);
            this.addGroupBox.Controls.Add(this.pnLabel);
            this.addGroupBox.Controls.Add(this.partNumberTextBox);
            this.addGroupBox.Controls.Add(this.priceLabel);
            this.addGroupBox.Controls.Add(this.priceTextBox);
            this.addGroupBox.Controls.Add(this.quantTextBox);
            this.addGroupBox.Controls.Add(this.quantLabel);
            this.addGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(200, 173);
            this.addGroupBox.TabIndex = 1;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Items";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(37, 13);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // pnLabel
            // 
            this.pnLabel.AutoSize = true;
            this.pnLabel.Location = new System.Drawing.Point(6, 39);
            this.pnLabel.Name = "pnLabel";
            this.pnLabel.Size = new System.Drawing.Size(69, 13);
            this.pnLabel.TabIndex = 18;
            this.pnLabel.Text = "Part Number:";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(89, 39);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNumberTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(41, 65);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(89, 65);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // quantTextBox
            // 
            this.quantTextBox.Location = new System.Drawing.Point(89, 91);
            this.quantTextBox.Name = "quantTextBox";
            this.quantTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantTextBox.TabIndex = 6;
            // 
            // quantLabel
            // 
            this.quantLabel.AutoSize = true;
            this.quantLabel.Location = new System.Drawing.Point(26, 90);
            this.quantLabel.Name = "quantLabel";
            this.quantLabel.Size = new System.Drawing.Size(49, 13);
            this.quantLabel.TabIndex = 2;
            this.quantLabel.Text = "Quantity:";
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.Location = new System.Drawing.Point(11, 49);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.partNumberLabel.TabIndex = 1;
            this.partNumberLabel.Text = "Part Number:";
            // 
            // namePartNumberLabel
            // 
            this.namePartNumberLabel.AutoSize = true;
            this.namePartNumberLabel.Location = new System.Drawing.Point(6, 124);
            this.namePartNumberLabel.Name = "namePartNumberLabel";
            this.namePartNumberLabel.Size = new System.Drawing.Size(140, 13);
            this.namePartNumberLabel.TabIndex = 3;
            this.namePartNumberLabel.Text = "Enter Name or Part Number:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 144);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(103, 144);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(91, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(6, 17);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(120, 95);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.searchButton);
            this.productGroupBox.Controls.Add(this.searchTextBox);
            this.productGroupBox.Controls.Add(this.itemListBox);
            this.productGroupBox.Controls.Add(this.namePartNumberLabel);
            this.productGroupBox.Location = new System.Drawing.Point(229, 12);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(200, 173);
            this.productGroupBox.TabIndex = 2;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Inventory";
            // 
            // priceUpdateTextBox
            // 
            this.priceUpdateTextBox.Location = new System.Drawing.Point(94, 94);
            this.priceUpdateTextBox.Name = "priceUpdateTextBox";
            this.priceUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceUpdateTextBox.TabIndex = 14;
            // 
            // quantUpdateTextBox
            // 
            this.quantUpdateTextBox.Location = new System.Drawing.Point(94, 68);
            this.quantUpdateTextBox.Name = "quantUpdateTextBox";
            this.quantUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantUpdateTextBox.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(14, 124);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(42, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name:";
            // 
            // price2Label
            // 
            this.price2Label.AutoSize = true;
            this.price2Label.Location = new System.Drawing.Point(46, 97);
            this.price2Label.Name = "price2Label";
            this.price2Label.Size = new System.Drawing.Size(34, 13);
            this.price2Label.TabIndex = 7;
            this.price2Label.Text = "Price:";
            // 
            // quant2Label
            // 
            this.quant2Label.AutoSize = true;
            this.quant2Label.Location = new System.Drawing.Point(31, 71);
            this.quant2Label.Name = "quant2Label";
            this.quant2Label.Size = new System.Drawing.Size(49, 13);
            this.quant2Label.TabIndex = 6;
            this.quant2Label.Text = "Quantity:";
            // 
            // pn2Label
            // 
            this.pn2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn2Label.Location = new System.Drawing.Point(94, 45);
            this.pn2Label.Name = "pn2Label";
            this.pn2Label.Size = new System.Drawing.Size(100, 20);
            this.pn2Label.TabIndex = 5;
            this.pn2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name2Label
            // 
            this.name2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name2Label.Location = new System.Drawing.Point(94, 22);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(100, 20);
            this.name2Label.TabIndex = 4;
            this.name2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(105, 124);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(572, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Controls.Add(this.partNumberLabel);
            this.groupBox2.Controls.Add(this.quant2Label);
            this.groupBox2.Controls.Add(this.removeButton);
            this.groupBox2.Controls.Add(this.price2Label);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.pn2Label);
            this.groupBox2.Controls.Add(this.priceUpdateTextBox);
            this.groupBox2.Controls.Add(this.quantUpdateTextBox);
            this.groupBox2.Controls.Add(this.name2Label);
            this.groupBox2.Location = new System.Drawing.Point(447, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantTextBox;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantLabel;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label namePartNumberLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.TextBox priceUpdateTextBox;
        private System.Windows.Forms.TextBox quantUpdateTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label pnLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label price2Label;
        private System.Windows.Forms.Label quant2Label;
        private System.Windows.Forms.Label pn2Label;
        private System.Windows.Forms.Label name2Label;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

