//*************************************************************************************
//  Form1.cs
//
//  AUTHOR: DUSTIN KABAN
//  ID: T00663749
//  DATE: APRIL 16th, 2021
//  COURSE: COMP 2211, ASSIGNMENT 4: C#
//
//  WRITING:
//  This class handles saving a file using the SaveFileDialog component.
//  We save X amount of integers to a file.  Both X and the file name/location
//  is specified by the user.
//  READING:
//  This class also handles reading a file using the OpenFileDialog component.
//  We read in integers from the file, display them in a listbox and then display
//  the total and integer count to the user
//*************************************************************************************

using System;
using System.Windows.Forms;
using System.IO;

namespace RandomNumberFileWR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFile.FileName);

                bool isNumber = int.TryParse(randomNumberCountTextBox.Text, out int randomNumberCount);
                if (isNumber)
                {
                    Random random = new Random();

                    while (randomNumberCount > 0)
                    {
                        outputFile.WriteLine(random.Next(1, 101));
                        randomNumberCount--;
                    }
                }

                outputFile.Close();
                MessageBox.Show("File was Saved to: " + saveFile.FileName);
            }
            else
            {
                MessageBox.Show("You clicked the Cancel Button!");
            }
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
                int total = 0, numberCount = 0;
                bool isNumber;

                while(!inputFile.EndOfStream)
                {
                    numberCount++;
                    isNumber = int.TryParse(inputFile.ReadLine(), out int number);
                    if(isNumber)
                    {
                        total += number;
                        randomNumbersListBox.Items.Add(number);
                    }
                }

                totalLabel.Text = total.ToString();
                numberCountLabel.Text = numberCount.ToString();

                inputFile.Close();
                MessageBox.Show("You clicked the Open Button!");
            }
            else
            {
                MessageBox.Show("You clicked the Cancel Button");
            }
        }
    }
}
