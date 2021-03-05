using System;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "No Picture Selected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PicLoc;
            OpenFileDialog Picture = new OpenFileDialog();
            Picture.InitialDirectory = "C:\\Users\\Windows\\OneDrive\\Pictures\\Screenshots";
            Picture.Filter = "JPG files (*.jpg|*.jpg|All Files (*.*)|*.*";
            Picture.Title = "Choose the picture you need to upload";
            Picture.ShowDialog();
            if ((int)DialogResult.OK == 1)
            {
                PicLoc = Picture.FileName;
                label1.Text = PicLoc;
                pictureBox1.ImageLocation = PicLoc;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
