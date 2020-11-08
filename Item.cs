using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Item
    {
        private string itemName;
        private string itemPartNumber;
        private string itemSerialNumber;
        private string itemQuantity;

        public string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string PartNumber
        {
            get { return itemPartNumber; }
            set { itemPartNumber = value; }
        }

        public string SerialNumber
        {
            get { return itemSerialNumber; }
            set { itemSerialNumber = value; }
        }

        public string Quantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }

        public Item(string itemName, string itemPartNumber, string itemSerialNumber, string itemQuantity)
        {
            this.itemName = itemName;
            this.itemPartNumber = itemPartNumber;
            this.itemSerialNumber = itemSerialNumber;
            this.itemQuantity = itemQuantity;
        }

        public Item()
        {
            itemName = "none";
            itemPartNumber = "none";
            itemSerialNumber = "none";
            itemQuantity = "none";
        }
    }
}
