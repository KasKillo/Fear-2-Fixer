using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace Fear2Pc
{
    public partial class Form1 : Form
    {
        string path = "";
        string MouseFixUrl = "https://download1495.mediafire.com/hdnat9tjz4yg/91xrtfdy9wcrnb0/X3DAudio1_5.dll";
        WebClient client;
       

        public Form1()
        {
            InitializeComponent();
            //string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void GDButton_Click(object sender, EventArgs e)
        {
            if (FovInput.Text.Length != 0)
            {
                FolderBrowserDialog folderbrowserdialog = new FolderBrowserDialog();
                folderbrowserdialog.ShowDialog();
                path = folderbrowserdialog.SelectedPath;
                

                if (path == "")
                {
                    GameDirectoryLabel.Text = "Game Directory Not Set";
                }
                else
                {
                    GameDirectoryLabel.Text = path;
                    CreateCFG.Visible = true;
                    MouseFixDownload.Visible = true;
                    EnableMAFix.Visible = true;
                    MouseFixDownload.Visible = true;
                }

                Console.WriteLine(folderbrowserdialog.SelectedPath);
            }
            
        }

        private void DIGIT_ONLY(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CreateCFG_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(Path.Combine(path + "\\autoexec.cfg"), FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(stream);

            Console.WriteLine(stream.ToString());


            writer.WriteLine("FovY " + FovInput.Text);
            if (WYes.Checked == true)
            {
                writer.WriteLine("Windowed 1");
            }
            else
            {
                writer.WriteLine("Windowed 0");
            }



            Console.WriteLine(writer);
            writer.Close();
            stream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VersionLabel.Parent = BackgroundImage;
            VersionLabel.ForeColor = Color.White;
            GameDirectoryLabel.Parent = BackgroundImage;
            GameDirectoryLabel.ForeColor = Color.White;
            FovLabel.Parent = BackgroundImage;
            FovLabel.ForeColor = Color.White;
            WindowedLabel.Parent = BackgroundImage;
            WindowedLabel.ForeColor = Color.White;
            WYes.Parent = BackgroundImage;
            WYes.ForeColor = Color.White;
            WNo.Parent = BackgroundImage;
            WNo.ForeColor = Color.White;
            CreatorLabel.Parent = BackgroundImage;
            CreatorLabel.ForeColor = Color.White;
        }

        private async void MouseFixDownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://download1495.mediafire.com/hdnat9tjz4yg/91xrtfdy9wcrnb0/X3DAudio1_5.dll");
        }

        private void EnableMAFix_Click(object sender, EventArgs e)
        {

            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\X3DAudio1_5.dll";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\X3DAudio1_5.dll";
            var destination = Path.Combine(path + "\\X3DAudio1_5.dll");

           if(File.Exists(sourceDesktop))
           {
                File.Move(sourceDesktop, destination);
            }
            else if(File.Exists(sourceDownloads))
            {
                File.Move(sourceDownloads, destination);
            }

        }

        private void CreatorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KASY24");
        }
    }
}
