using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int X, Y, Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Addition_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                X = int.Parse(textBox1.Text);
                Y = int.Parse(textBox2.Text);
                Result = X + Y;
                MessageBox.Show(Result.ToString());
            }
            else
                MessageBox.Show("Invalid Number");
        }
        private void Subtraction_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                X = int.Parse(textBox1.Text);
                Y = int.Parse(textBox2.Text);
                Result = X - Y;
                MessageBox.Show(Result.ToString());
            }
            else
                MessageBox.Show("Invalid Number");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Multiplication_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                X = int.Parse(textBox1.Text);
                Y = int.Parse(textBox2.Text);
                Result = X * Y;
                MessageBox.Show(Result.ToString());
            }
            else
                MessageBox.Show("Invalid Number");
        }

        private void Division_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"[1-9]+"))
            {
                X = int.Parse(textBox1.Text);
                Y = int.Parse(textBox2.Text);
                Result = X / Y;
                MessageBox.Show(Result.ToString());
            }
            else
                MessageBox.Show("Invalid Number");
        }
    }
}
