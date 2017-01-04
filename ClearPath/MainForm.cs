using Microsoft.Win32;
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
        const string ProgramName = "ClearMachine";
        string setFolder = Properties.Settings.Default.FolderPath;

        private FolderBrowserDialog fbd;

        public MainForm()
        {
            InitializeComponent();
            lbPath.Text = setFolder;
            cbOnWinStart.Checked = Properties.Settings.Default.OnWinStart;
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

        //Minimize Window to tray
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                nfiMain.Visible = true;
            }
        }

        //Maximize Window
        private void nfiMain_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            nfiMain.Visible = false;
        }

        //Minimize window to tray on button Accept
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbOnWinStart.Checked == true)
            {
                //Set autoloading
                SetAutorunValue(true);
                Properties.Settings.Default.OnWinStart = true;
            }
            else
            {
                //Unset autoloading
                SetAutorunValue(false);
                Properties.Settings.Default.OnWinStart = false;
            }

            this.Hide();
            nfiMain.Visible = true;
        }

        //Added autoloading ro register
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(ProgramName, ExePath);
                else
                    reg.DeleteValue(ProgramName);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
