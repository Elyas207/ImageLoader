using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ImageLoader {
    public partial class Form1 : Form {
        private const string text = "The Image has been saved to Pictures";

        public Form1()
        {
            InitializeComponent();
        }

        

        void LoadImageFromUri(string url)
            {
                var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream()) { 
                pictureBox1.Image = Bitmap.FromStream(stream);
        }

      }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            LoadImageFromUri(textbox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2 ();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random(10000);
            string path = @"C:\Users\Public\Pictures";
            pictureBox1.Image.Save(path + @"\" + Name + random + ".jpg", ImageFormat.Jpeg);
            MessageBox.Show(text);
            Process.Start(@"C:\Users\Public\Pictures");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            myForm.ShowDialog();
        }
    }

        }
    


    
