using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// My name is Joshua Houk and this is my Inventory Management System Project.
// Git Repo:  https://github.com/joshhouk4/CST-117

namespace Inventory_Management_System
{
    class InventoryManager
    {
        //Fields
        private List<string> listStore; //used list to Store rather then single vars


        //Constructor
        public InventoryManager()
        {
            listStore = new List<string>() { "", "", "", "" };

        }
        //Name Property
        public string Name
        {
            get { return listStore[0]; }
            set { listStore[0] = value; }
        }
        //Quant Property
        public string Quant
        {
            get { return listStore[1]; }
            set { listStore[1] = value; }
        }
        //Part Number Property
        public string PartNumber
        {
            get { return listStore[2]; }
            set { listStore[2] = value; }
        }
        //Price Property
        public string Price
        {
            get { return listStore[3]; }
            set { listStore[3] = value; }
        }
    }
}
