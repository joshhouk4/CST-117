using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int charFound = 0;                      // This is used to count the number of t's and e's found.
                StreamReader inputFile = File.OpenText("Exercise_10TextFile.txt");              // Open the text file.
                while (!inputFile.EndOfStream)
                {
                    string lineInfo = inputFile.ReadLine();                                     // Reads the line.
                    int cnt = 0;                                                                // Counter.

                    foreach (char letter in lineInfo)                                           // Use foreach to check each char.
                    {
                        if (letter.ToString() == " " || letter.ToString() == "." || letter.ToString() == "!" ||                 // This finds the end of a word.
                            letter.ToString() == "," || letter.ToString() == "?" || letter.ToString() == ";" ||
                            letter.ToString() == ":")
                        {


                            if ((cnt != 0 && lineInfo[cnt - 1].ToString().ToUpper() == "T") ||
                                (cnt != 0 && lineInfo[cnt - 1].ToString().ToUpper() == "E"))
                            {
                                charFound += 1;                                                           // Counter for t and e's.
                            }
                        }
                        cnt += 1;                                                   // Adds 1 for each index.
                    }
                }
                inputFile.Close();                                                  // Close the file.

                Console.WriteLine("There are " + charFound.ToString() + " words the end in t or e.");         // Write all the info in the console.
                Console.WriteLine("Press enter to close...");
                Console.Read();
            }
            catch (Exception EX)                            // Catches Errors.
            {
                Console.WriteLine(EX.Message);              // Displays the error.
                Console.Read();
            }
        }
    }
}
