using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class piForm : Form
    {

        // My name is Joshua Houk and this is my Approximate PI program.
        //
        public piForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numberTerms;

            if (int.TryParse(termsTextBox.Text, out numberTerms))
            {
                double pi = 4;

                //Pi is 4 after only one term, so that is displayed here
                if (numberTerms == 1)
                {
                    termsLabel.Text = "Approximate value of Pi after 1 term: ";
                }
                else if (numberTerms > 1 && numberTerms <= int.MaxValue)
                {
                    long denominator = 3;

                    //false sets symbol to subtract, true sets symbol to add.
                    bool addSubtract = false;

                    for (int i = 2; i <= numberTerms; i++)
                    {
                        switch (addSubtract)
                        {
                            //false causes subtraction, true causes addition
                            case false:
                                pi = pi - ((double)4 / denominator);
                                denominator += 2;
                                addSubtract = !addSubtract;
                                break;

                            case true:
                                pi = pi + ((double)4 / denominator);
                                denominator += 2;
                                addSubtract = !addSubtract;
                                break;

                        }
                    }
                }

                outputLabel.Text = ("Approximate value of pi after ") + termsTextBox.Text + (" terms = ") + pi.ToString();
            }
            else
            {
                //Parse has failed.
                MessageBox.Show("Invalid input for the number of terms. It must be a whole number between 1 and " + int.MaxValue.ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form.
            this.Close();
        }
    }
}
