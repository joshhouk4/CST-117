namespace Inventory_Management
{
    partial class addNewItem
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
            this.newItemLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productQuantOHTextBox = new System.Windows.Forms.TextBox();
            this.lastSoldTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newItemLabel
            // 
            this.newItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemLabel.Location = new System.Drawing.Point(42, 27);
            this.newItemLabel.Name = "newItemLabel";
            this.newItemLabel.Size = new System.Drawing.Size(409, 33);
            this.newItemLabel.TabIndex = 0;
            this.newItemLabel.Text = "Please Enter the following information:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(47, 95);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.productNameTextBox.TabIndex = 1;
            this.productNameTextBox.Text = "Enter Product Name";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(47, 149);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(216, 20);
            this.productIDTextBox.TabIndex = 2;
            this.productIDTextBox.Text = "Enter Product ID";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(47, 201);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(216, 20);
            this.productDescriptionTextBox.TabIndex = 3;
            this.productDescriptionTextBox.Text = "Enter Description";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(293, 95);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(216, 20);
            this.productPriceTextBox.TabIndex = 4;
            this.productPriceTextBox.Text = "Enter Product Price";
            // 
            // productQuantOHTextBox
            // 
            this.productQuantOHTextBox.Location = new System.Drawing.Point(293, 149);
            this.productQuantOHTextBox.Name = "productQuantOHTextBox";
            this.productQuantOHTextBox.Size = new System.Drawing.Size(216, 20);
            this.productQuantOHTextBox.TabIndex = 5;
            this.productQuantOHTextBox.Text = "Enter Quantity On Hand";
            // 
            // lastSoldTextBox
            // 
            this.lastSoldTextBox.Location = new System.Drawing.Point(293, 201);
            this.lastSoldTextBox.Name = "lastSoldTextBox";
            this.lastSoldTextBox.Size = new System.Drawing.Size(216, 20);
            this.lastSoldTextBox.TabIndex = 6;
            this.lastSoldTextBox.Text = "Enter Last Time Sold";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(47, 302);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(119, 49);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(220, 302);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 49);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(390, 302);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 49);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lastSoldTextBox);
            this.Controls.Add(this.productQuantOHTextBox);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.newItemLabel);
            this.Name = "addNewItem";
            this.Text = "Add New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newItemLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productQuantOHTextBox;
        private System.Windows.Forms.TextBox lastSoldTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}