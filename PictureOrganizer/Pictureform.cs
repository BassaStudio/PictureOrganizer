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
    public partial class Pictureform : Form
    {
        FolderBrowserDialog m_tpic;
        FolderBrowserDialog m_fpic;

        int NowP = 0;

        string[] files;



        public Pictureform(FolderBrowserDialog from, FolderBrowserDialog to)
        {
            InitializeComponent();

            m_tpic = to;
            m_fpic = from;
        }

        private void Pictureform_Load(object sender, EventArgs e)
        {
            String searchFolder = m_fpic.SelectedPath.ToString();
            var filters = new String[] { "jpg", "jpeg", "png" };
            files = GetFilesFrom(searchFolder, filters, false);

            Frame.Image = Image.FromFile(files[NowP]);
        }

        //TODO: fix doubleclick

        private void nextP()
        {
            if(NowP < files.Length-1)
            {
                NowP++;
                Frame.Image = Image.FromFile(files[NowP]);
            } else
            {
                MessageBox.Show("No more Picture");
                Application.Exit();
            }

        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        

        private void Pictureform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Pictureform_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.J)
            {
                string socPath = files[NowP];
                string desPath = m_tpic.SelectedPath.ToString() + @"\" + Path.GetFileName(files[NowP]);

                System.IO.File.Copy(socPath, desPath, true);

                nextP();
            } else if(e.KeyCode == Keys.N)
            {
                nextP();
            }
        }
    }
}
