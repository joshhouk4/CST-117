using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_4
{
    public partial class Form1 : Form
    {
        int[,] arr;                                             // 2d int array
        string[,] board;                                        // 2d string array

        int xCount;                                             // track X count
        int oCount;                                             // track O count

        public Form1()
        {
            InitializeComponent();

            StartBoard();                                       // call method to start game
        }

        private void StartBoard()                               // method to initialize game, setup board and counter
        {
            arr = new int[3, 3];
            board = new string[3, 3];
            xCount = 0;
            oCount = 0;
        }

        private void FillArray()                                // method to fill array arr with random numbers and store O or X to the array board
        {
            Random rand = new Random();                         // create a random object

            for (int row = 0; row < 3; row++)                   // store random generated numbers in array index
            {
                for (int col = 0; col < 3; col++)
                {
                    arr[row, col] = rand.Next(0, 2);

                    if (arr[row, col] == 0)                     // O = 0, X = 1
                    {
                        board[row, col] = "O";
                        oCount++;
                    }
                    else
                    {
                        board[row, col] = "X";
                        xCount++;
                    }
                }
            }
        }

        private void SetGameTable()                             // method to set random array values to labels
        {
                                                                //display index of boards array in the lables
            array00Label.Text = board[0, 0];
            array01Label.Text = board[0, 1];
            array02Label.Text = board[0, 2];
            array10Label.Text = board[1, 0];
            array11Label.Text = board[1, 1];
            array12Label.Text = board[1, 2];
            array20Label.Text = board[2, 0];
            array21Label.Text = board[2, 1];
            array22Label.Text = board[2, 2];

        }

        private void CheckForWinner()                          // method to check for winner
        {
            if (WinByRow("X"))
            {
                resultLabel.Text = "X Wins!";
                return;
            }
            else if (WinByRow("O"))
            {
                resultLabel.Text = "O Wins!";
                return;
            }
            else if (WinByColumn("X"))
            {
                resultLabel.Text = "X Wins!";
                return;
            }
            else if (WinByColumn("O"))
            {
                resultLabel.Text = "O Wins!";
                return;
            }
            else if (WinByDiagonal("X"))
            {
                resultLabel.Text = "X Wins!";
                return;
            }
            else if (WinByDiagonal("O"))
            {
                resultLabel.Text = "O Wins!";
                return;
            }
            else
            {
                resultLabel.Text = "Its a tie!";
            }
        }
        private Boolean WinByRow(string charValue)              // method to check for row winner
        {
            for (int row = 0; row < 3; row++)
            {
                if ((board[row, 0] == board[row, 1]) && (board[row, 0] == board[row, 2]))
                {
                    if (board[row, 0].Equals(charValue))
                        return true;
                }
            }
            return false;
        }
        private Boolean WinByColumn(string charValue)           // method to check for column winner
        {
            for (int col = 0; col < 3; col++)
            {
                if ((board[0, col] == board[1, col]) && (board[1, col] == board[2, col]))
                {
                    if (board[col, 0].Equals(charValue))
                        return true;
                }
            }
            return false;
        }
        private Boolean WinByDiagonal(string charValue)         // method to check for diagonal winner
        {

            if ((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))       // check from left to to right diagonally
            {
                if (board[0, 0].Equals(charValue))
                    return true;
            }
            if ((board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]))       // check from right to left diagonally
            {
                if (board[1, 1].Equals(charValue))
                    return true;
            }
            return false;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            do                                                  // loop to fill array and keep max count of X or O
            {
                StartBoard();
                FillArray();
                if ((oCount == 4 && xCount == 5) || (oCount == 5 && xCount == 4))
                {
                    break;
                }
            } while (true);
            SetGameTable();                                     // call method to display board
            CheckForWinner();                                   // call method that checks for winner
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();                                       // close the form
        }
    }
}
