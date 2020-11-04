using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_6
{
    public partial class diceRollForm : Form
    {
        // My name is Joshua Houk and this is my exercise 6 in CST 117.
        // GitHub Repo:     https://github.com/joshhouk4/CST-117
        public diceRollForm()
        {
            InitializeComponent();
            clearButton.Enabled = false;                                    // Disable the clear button.
        }
        
        int clickCounter = 0;                                               // Set up a clickCounter.

        private void rollButton_Click(object sender, EventArgs e)
        {
            int sides = new Random().Next(4, 21);                           // Establish the sides of the dice.
            var rng = new Random();                                         // Set up random number generator.

            var die1 = new Dice(sides, rng);                                // Set up die 1 sides and rng.
            var die2 = new Dice(sides, rng);                                // Set up die 2 sides and rng.

            int roll1 = die1.rollDie();                                     // Roll die 1.
            int roll2 = die2.rollDie();                                     // Roll die 2.

            die1Label.Text = roll1.ToString();                              // Convert the die 1 roll to a string and display it in die1Label.
            die2Label.Text = roll2.ToString();                              // Convert the die 2 roll to a string and display it in die2Label.

            clickCounter++;                                                 // clickCounter for the number of turns.

            if (roll1 == 1 && roll2 == 1)                                   // Boolean for snake eyes.
            {
                turnLabel.Text = "It took " + clickCounter + " roll(s) to get snake eyes!";
                clearButton.Enabled = true;
                rollButton.Enabled = false;
            }
        }

        class Dice                                                          // Establish our dice class.
        {
            private int sides;                                              // Int for sides.
            private Random random;                                          // Set up our Random.

            public Dice(int sides, Random rng)                              // Set up our sides of the die and the random number.
            {
                this.sides = sides;
                this.random = rng;
            }

            public int rollDie()                                            // Roll the die.
            {
                return this.random.Next(1, this.sides + 1);                 // Return our rolled die value.
            }
        }

        private void clearButton_Click(object sender, EventArgs e)          // Clear all the labels in the program, enable you to roll again, and clear the clickCounter.
        {
            die1Label.Text = "";
            die2Label.Text = "";
            turnLabel.Text = "";
            rollButton.Enabled = true;
            clearButton.Enabled = false;
            clickCounter = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();                                                   // Close the form.
        }
    }
}
