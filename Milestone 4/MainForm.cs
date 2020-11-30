using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// My name is Joshua Houk and this is my Inventory Management System Project.
// Git Repo:  https://github.com/joshhouk4/CST-117

namespace Inventory_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<InventoryManager> invList = new List<InventoryManager>();                                //List to store objects
        List<string> nameList = new List<string>();                                                   //List to store Item Names
        List<string> pnList = new List<string>();                                                 //List to store Part Numbers

        private void GetInvData(InventoryManager inv)
        {
            decimal price;
            int quant;

            //Verify there is data in the TextBoxes
            if (nameTextBox.Text != "" && partNumberTextBox.Text != "" && quantTextBox.Text != "" && priceTextBox.Text != "")
            {
                if (decimal.TryParse(priceTextBox.Text, out price) && int.TryParse(quantTextBox.Text, out quant))
                {
                    inv.Name = nameTextBox.Text;
                    inv.PartNumber = partNumberTextBox.Text;
                    inv.Quant = quant.ToString();
                    inv.Price = price.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Quantity or Price");
                }
            }

            //Find the TextBox with no data
            else
            {
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Name");
                }
                if (partNumberTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Part NUmber");
                }
                if (quantTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Quantity");
                }
                if (priceTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Price");
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InventoryManager newInv = new InventoryManager();                                     //Create a new inventory oject
            GetInvData(newInv);                                                                   //Set values in object
            invList.Add(newInv);                                                                  //Add object to a list so it can be referenced later
            itemListBox.Items.Add(newInv.Name + " " + newInv.PartNumber);                         //Concat name and Part Number
            nameList.Add(nameTextBox.Text);                                                       //Add name to list (used for search and index)
            pnList.Add(partNumberTextBox.Text);                                               //Add Part Number to list (used for search and index)

            //Clear all the TextBoxes for new data
            nameTextBox.Clear();
            partNumberTextBox.Clear();
            quantTextBox.Clear();
            priceTextBox.Clear();
            nameTextBox.Focus();
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = itemListBox.SelectedIndex;                                                //Get the position of the selected item
            if (index != -1)                                                                      //Make sure an item is selected
            {
                //Set label values
                nameLabel.Text = invList[index].Name;
                pnLabel.Text = invList[index].PartNumber;
                //Set TextBox values
                quantUpdateTextBox.Text = invList[index].Quant;
                priceUpdateTextBox.Text = invList[index].Price;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool found = false;                                                                   //bool used to indicate if search value found

            if (searchTextBox.Text != "" && nameList.Count > 0)                                   //Make sure there is data in the texbox and an item in the list
            {
                for (int x = 0; x < nameList.Count; x++)                                          //Check all the values in the name list
                {
                    if (searchTextBox.Text == nameList[x])
                    {
                        found = true;                                                             //Change bool to indicate item found

                        //Update labels and textboxes with found item
                        nameLabel.Text = invList[x].Name;
                        pnLabel.Text = invList[x].PartNumber;
                        quantUpdateTextBox.Text = invList[x].Quant;
                        priceUpdateTextBox.Text = invList[x].Price;

                        itemListBox.SelectedIndex = x;                                            //changed selected item in listbox
                    }
                }

                for (int x = 0; x < pnList.Count; x++)                                        //Check all the values in the Part Number list
                {
                    if (searchTextBox.Text == pnList[x])                                      //Check if indexed item matches textbox
                    {
                        found = true;                                                             //Change bool to indicate item found

                        //Update labels and textboxes with found item
                        nameLabel.Text = invList[x].Name;
                        pnLabel.Text = invList[x].PartNumber;
                        quantUpdateTextBox.Text = invList[x].Quant;
                        priceUpdateTextBox.Text = invList[x].Price;

                        itemListBox.SelectedIndex = x;                                            //changed selected item in listbox
                    }
                }

                if (found == false)                                                               //Let the user know the item couldn't be found
                {
                    MessageBox.Show("Product Name or Part Number cannot be found!");
                }
            }
            else                                                                                  //Invalid data or not list items
            {
                MessageBox.Show("Invalid input for Search or no items in inventory!");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = itemListBox.SelectedIndex;                                                //Get the position of the selected item
            if (index != -1)                                                                      //Make sure an item is selected
            {
                //remove items from list and clear labels and textboxes
                nameList.RemoveAt(index);
                pnList.RemoveAt(index);
                invList.RemoveAt(index);
                itemListBox.Items.RemoveAt(index);
                nameLabel.Text = "";
                pnLabel.Text = "";
                quantUpdateTextBox.Text = "";
                priceUpdateTextBox.Text = "";
                itemListBox.ClearSelected();

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int index = itemListBox.SelectedIndex;                                                //Get the position of the selected item
            if (index != -1)                                                                      //Make sure an item is selected
            {
                //update object with new price or quantity
                decimal newPrice;
                int newQuant;
                decimal.TryParse(priceUpdateTextBox.Text, out newPrice);
                int.TryParse(quantUpdateTextBox.Text, out newQuant);
                invList[index].Price = newPrice.ToString();
                invList[index].Quant = newQuant.ToString();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (invList.Count > 0)                                                            //Make sure there is actually inventory to save.
                {
                    StreamWriter outputFile;                                                      //Declare StreamWriter
                    outputFile = File.CreateText("Inventory.txt");                                //Create the file
                    outputFile.WriteLine("Product Name, Part Number, Product Quantity, Product Price");  //Data Header
                    for (int index = 0; index < invList.Count; index++)                           //for loop for list item iteration
                    {
                        outputFile.WriteLine(invList[index].Name + "," + invList[index].PartNumber + "," + invList[index].Quant + "," + invList[index].Price); //Items from object
                    }
                    outputFile.Close();                                                           //Close the file
                    MessageBox.Show("File Successfully Written!");                                //Let the user know that the operation was successful
                }
                else
                {
                    MessageBox.Show("No Inventory to Export.");                                   //Let the user know the application will not write a file due to no items.
                }
            }
            catch (Exception EX)                                                                  //Error handling
            {
                MessageBox.Show(EX.Message);                                                      //Error message
            }
        }
    }
}