namespace Inventory_Management
{
    partial class inventoryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addItemButton = new System.Windows.Forms.Button();
            this.editNameButton = new System.Windows.Forms.Button();
            this.editIdButton = new System.Windows.Forms.Button();
            this.editDescriptionButton = new System.Windows.Forms.Button();
            this.editPriceButton = new System.Windows.Forms.Button();
            this.editQuantOHButton = new System.Windows.Forms.Button();
            this.editLastSoldButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ID,
            this.Description,
            this.Price,
            this.Quantity,
            this.LastSold});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(644, 246);
            this.dataGridView2.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity O/H";
            this.Quantity.Name = "Quantity";
            // 
            // LastSold
            // 
            this.LastSold.HeaderText = "Last Sold";
            this.LastSold.Name = "LastSold";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(662, 27);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(126, 72);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add New Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // editNameButton
            // 
            this.editNameButton.Location = new System.Drawing.Point(45, 272);
            this.editNameButton.Name = "editNameButton";
            this.editNameButton.Size = new System.Drawing.Size(75, 23);
            this.editNameButton.TabIndex = 3;
            this.editNameButton.Text = "Edit";
            this.editNameButton.UseVisualStyleBackColor = true;
            this.editNameButton.Click += new System.EventHandler(this.editNameButton_Click);
            // 
            // editIdButton
            // 
            this.editIdButton.Location = new System.Drawing.Point(150, 272);
            this.editIdButton.Name = "editIdButton";
            this.editIdButton.Size = new System.Drawing.Size(75, 23);
            this.editIdButton.TabIndex = 4;
            this.editIdButton.Text = "Edit";
            this.editIdButton.UseVisualStyleBackColor = true;
            this.editIdButton.Click += new System.EventHandler(this.editIdButton_Click);
            // 
            // editDescriptionButton
            // 
            this.editDescriptionButton.Location = new System.Drawing.Point(250, 272);
            this.editDescriptionButton.Name = "editDescriptionButton";
            this.editDescriptionButton.Size = new System.Drawing.Size(75, 23);
            this.editDescriptionButton.TabIndex = 5;
            this.editDescriptionButton.Text = "Edit";
            this.editDescriptionButton.UseVisualStyleBackColor = true;
            this.editDescriptionButton.Click += new System.EventHandler(this.editDescriptionButton_Click);
            // 
            // editPriceButton
            // 
            this.editPriceButton.Location = new System.Drawing.Point(364, 272);
            this.editPriceButton.Name = "editPriceButton";
            this.editPriceButton.Size = new System.Drawing.Size(75, 23);
            this.editPriceButton.TabIndex = 6;
            this.editPriceButton.Text = "Edit";
            this.editPriceButton.UseVisualStyleBackColor = true;
            this.editPriceButton.Click += new System.EventHandler(this.editPriceButton_Click);
            // 
            // editQuantOHButton
            // 
            this.editQuantOHButton.Location = new System.Drawing.Point(461, 272);
            this.editQuantOHButton.Name = "editQuantOHButton";
            this.editQuantOHButton.Size = new System.Drawing.Size(75, 23);
            this.editQuantOHButton.TabIndex = 7;
            this.editQuantOHButton.Text = "Edit";
            this.editQuantOHButton.UseVisualStyleBackColor = true;
            this.editQuantOHButton.Click += new System.EventHandler(this.editQuantOHButton_Click);
            // 
            // editLastSoldButton
            // 
            this.editLastSoldButton.Location = new System.Drawing.Point(569, 272);
            this.editLastSoldButton.Name = "editLastSoldButton";
            this.editLastSoldButton.Size = new System.Drawing.Size(75, 23);
            this.editLastSoldButton.TabIndex = 8;
            this.editLastSoldButton.Text = "Edit";
            this.editLastSoldButton.UseVisualStyleBackColor = true;
            this.editLastSoldButton.Click += new System.EventHandler(this.editLastSoldButton_Click);
            // 
            // inventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editLastSoldButton);
            this.Controls.Add(this.editQuantOHButton);
            this.Controls.Add(this.editPriceButton);
            this.Controls.Add(this.editDescriptionButton);
            this.Controls.Add(this.editIdButton);
            this.Controls.Add(this.editNameButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.dataGridView2);
            this.Name = "inventoryManagement";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSold;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button editNameButton;
        private System.Windows.Forms.Button editIdButton;
        private System.Windows.Forms.Button editDescriptionButton;
        private System.Windows.Forms.Button editPriceButton;
        private System.Windows.Forms.Button editQuantOHButton;
        private System.Windows.Forms.Button editLastSoldButton;
    }
}

