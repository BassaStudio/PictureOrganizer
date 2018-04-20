using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureOrganizer
{
    public partial class main : Form
    {
        Pictureform picf;

        FolderBrowserDialog toP;
        FolderBrowserDialog foP;

        public main()
        {
            InitializeComponent();
        }

        private void TbrwB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pic = getPath();
            if(pic != null) { 
                Totxt.Text = pic.SelectedPath.ToString();
                toP = pic;
            }
        }

        private void FbrwB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pic = getPath();
            if(pic != null) { 
               FromTxt.Text = pic.SelectedPath.ToString();
               foP = pic;
            }
        }

        private FolderBrowserDialog getPath()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd;
                }
            }

            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(foP != null || toP != null) {
                picf = new Pictureform(foP, toP);
                picf.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("You need to select folders");
            }
            
        }
    }
}
