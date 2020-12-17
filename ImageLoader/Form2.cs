using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace ImageLoader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private const string text = "The Image has been saved to Pictures";
        


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpegs|*.jpg|png|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1 ();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(10000);
            string path = @"C:\Users\Public\Pictures";
            pictureBox1.Image.Save(path + @"\" + Name + rnd + ".jpg", ImageFormat.Jpeg);
            MessageBox.Show(text);
            Process.Start(@"C:\Users\Public\Pictures");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            myForm.ShowDialog();
        }
    }
}
