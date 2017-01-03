using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearPath
{
    public partial class MainForm : Form
    {
        private FolderBrowserDialog fbd;
        string setFolder = Properties.Settings.Default.FolderPath;

        public MainForm()
        {
            InitializeComponent();
            lbPath.Text = setFolder;
        }

        // Get folder's path
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            fbd.SelectedPath = setFolder;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FolderPath = fbd.SelectedPath.ToString();
                Properties.Settings.Default.Save();
                lbPath.Text = fbd.SelectedPath.ToString();
            }
        }

        //Clear current folder
        private void btnClearNow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, that you want to delete ALL files from directory?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.FolderPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

                MessageBox.Show("It's clear!.", "Yeah!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
