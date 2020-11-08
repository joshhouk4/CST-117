using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class manageInverntory : Form
    {

        public manageInverntory()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name;
            string partnumber;
            string serialnumber;
            string quantity;
            name = nameTextBox.Text;
            partnumber = partNumberTextBox.Text;
            serialnumber = serialNumberTextBox.Text;
            quantity = quantityTextBox.Text;
            Item item1 = new Item(name, partnumber, serialnumber, quantity);
            MessageBox.Show(string.Format(" The item added was {0}, {1}, {2} ", item1.Name, item1.PartNumber, item1.SerialNumber));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            partNumberTextBox.Text = "";
            serialNumberTextBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
