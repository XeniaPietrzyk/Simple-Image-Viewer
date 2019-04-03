using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string path = "";

            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }

            Bitmap MyImage = new Bitmap(path);
            pbImage.Image = MyImage;
            
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;            
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbImage.Image.Save(saveFileDialog1.FileName);
            }             
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
            pbImage.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to exit?",
                "Disabling", MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
