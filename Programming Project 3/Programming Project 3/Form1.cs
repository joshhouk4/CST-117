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

namespace Programming_Project_3
{
    // My name is Joshua Houk and this is my Programming Project 3.
    // My GitHub Repo Link Is:   https://github.com/joshhouk4/CST-117
    public partial class wordApp : Form
    {
        public wordApp()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
                                                                                        // Clear all items if Browse button is clicked again.
            wordsListBox.Items.Clear();
            fileLabel.Text = "";
            fwLabel.Text = "";
            lwLabel.Text = "";
            mVowLabel.Text = "";
            lngWordLabel.Text = "";

            StreamReader inputFile;
            openFileDialog1.InitialDirectory = "C:\\";                                  // Set the starting path to open file.
            string stringVal;
            List<string> stringList = new List<string>();                               // List created for sorting.
            List<string> vowelList = new List<string> { "a", "e", "i", "o", "u", "y" }; // List with vowels
            int vowelCnt = 0;
            string vowelWord = "";
            int letterCnt = 0;
            string longWord = "";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] fileName = openFileDialog1.FileName.Split('\\');           // fileLabel.Text = openFileDialog1.FileName
                    fileLabel.Text = fileName.Last();                                   // Use to set file name.
                    inputFile = File.OpenText(openFileDialog1.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        stringVal = inputFile.ReadLine().ToLower();
                        stringList.Add(stringVal);
                        wordsListBox.Items.Add(stringVal);

                        int vowelNum = 0;
                        string vowelTemp = "";
                        int letterNum = 0;

                        foreach (var tmp in stringVal)                                  // Use to get each character in a word.
                        {
                                                                                        // wordsListBox.Items.Add(tmp);
                            letterNum += 1;                                             // Counts the number of characters in a word.

                            if (vowelList.Contains(tmp.ToString()))                     // Check to see if vowels are present.
                            {
                                vowelNum += 1;                                          // Counts the number of vowels found.
                                vowelTemp = stringVal.ToString();                       // Word with vowels.

                                                                                        // MessageBox.Show(tmp.ToString());  
                            }

                            if (vowelNum >= vowelCnt && vowelNum != 0)                  // Checks the number of vowels in a word.
                            {
                                vowelCnt = vowelNum;
                                vowelWord = vowelTemp;
                            }

                            if (letterNum >= letterCnt)                                 // Checks the total number of characters in a word.
                            {
                                letterCnt = letterNum;
                                longWord = stringVal;
                            }
                        }
                    }
                    inputFile.Close();                                                  // Close the open file.
                    stringList.Sort();                                                  // Sort to get items in alphbetical order.
                                                                                        // MessageBox.Show(stringList.First().ToString());
                    fwLabel.Text = stringList.First().ToString();                       // Set item in form.
                    lwLabel.Text = stringList.Last().ToString();                        // Set item in form.
                    mVowLabel.Text = vowelWord;                                         // Set item in form.
                    lngWordLabel.Text = longWord;                                       // Set item in form.
                }
                else
                {
                    MessageBox.Show("Operation Canceled!");
                    fileLabel.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
