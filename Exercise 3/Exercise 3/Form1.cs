using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class milesToKm : Form
    {
        public milesToKm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {          
            try
            {                
                int miles;
                decimal kilometers;

                miles = int.Parse(milesTextBox.Text);

                kilometers = (decimal)(miles * 1.609);

                kmLabel.Text = kilometers.ToString("n3");
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
