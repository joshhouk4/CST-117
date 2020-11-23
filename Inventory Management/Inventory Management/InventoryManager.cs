using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// My name is Joshua Houk and this is my Inventory Manager Project.

namespace Inventory_Management
{
    class InventoryManager
    {
        // Fields
        private List<string> invListArray;


                                                            //Constructor
        public InventoryManager()
        {
            invListArray = new List<string>() { "", "", "", "" };
        }
                                                            //Name Property
        public string Name
        {
            get { return invListArray[0]; }
            set { invListArray[0] = value; }
        }
                                                            //Part NUmber Property
        public string PartNumber
        {
            get { return invListArray[1]; }
            set { invListArray[1] = value; }
        }
                                                            //Price Property
        public string Price
        {
            get { return invListArray[2]; }
            set { invListArray[2] = value; }
        }
                                                            //Quant Property
        public string Quant
        {
            get { return invListArray[3]; }
            set { invListArray[3] = value; }
        }
    }
}
