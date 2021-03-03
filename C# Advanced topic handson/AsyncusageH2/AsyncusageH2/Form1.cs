using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncusageH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int CountCharacters()
        {
            int count = 0;
            // Create a StreamReader and point it to the file to read
            using (StreamReader reader = new StreamReader("C:\\MyFriendsList\\MyFriendsList.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                // Make the program look busy for 5 seconds
                Thread.Sleep(5000);
            }

            return count;
        }
        //private void btnProcessFile_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "Processing file. Please wait...";
        //    int count = CountCharacters();
        //    label1.Text = count.ToString() + " characters in file";
        //}

        // Make the method async by using the async keyword
        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            // Create a task to execute CountCharacters() function
            // CountCharacters() function returns int, so we created Task<int>
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            label1.Text = "Processing file. Please wait...";
            // Wait until the long running task completes
            int count = await task;
            label1.Text = count.ToString() + " characters in file";
        }
    }
}
