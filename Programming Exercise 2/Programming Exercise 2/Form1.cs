using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Exercise_2
{
    public partial class shapeMakerForm : Form
    {
        // My name is Joshua Houk and this is my work.
        // GitHub Repo Link:    https://github.com/joshhouk4/CST-117
        string selectedShape;

        public shapeMakerForm()
        {
            InitializeComponent();
        }

        private void shapeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShape = shapeListBox.Items[shapeListBox.SelectedIndex].ToString();
        }

        private void shapeLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void outlineRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (shapeListBox.SelectedIndex == -1)
                {
                    throw new Exception();
                }

                selectedShapeLabel.Text = selectedShape;

                if (nameCheckBox.Checked)
                    nameCheckBox.Visible = true;
                else
                    nameCheckBox.Visible = false;

                if (dateCheckBox.Checked)
                    dateCheckBox.Visible = true;
                else
                    dateCheckBox.Visible = false;

                switch (shapeListBox.SelectedIndex)
                {
                    case 0:
                        if (fillRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\filled circle.png";
                        else if (outlineRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\outline circle.png";
                        else
                            throw new Exception();
                        break;

                    case 1:
                        if (fillRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\filled triangle.png";
                        else if (outlineRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\outline triangle.png";
                        else
                            throw new Exception();
                        break;
                    case 2:
                        if (fillRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\filled rectangle.png";
                        else if (outlineRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\outline rectangle.png";
                        else
                            throw new Exception();
                        break;
                    case 3:
                        if (fillRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\filled pentagon.png";
                        else if (outlineRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\outline pentagon.png";
                        else
                            throw new Exception();
                        break;
                    case 4:
                        if (fillRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\filled hexagon.png";
                        else if (outlineRadioButton.Checked)
                            shapePictureBox.ImageLocation = @"C:\Users\Joshua\Desktop\School\CST-117\Shapes\outline hexagon.png";
                        else
                            throw new Exception();
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please select all required options");
            }
        }

        private void shapeMakerForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Today.ToString("D");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            shapePictureBox.Image = null;
            selectedShapeLabel.Visible = false;
            dateLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
