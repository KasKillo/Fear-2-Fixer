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
using System.IO.Compression;
using System.Net;
using System.Diagnostics;

namespace Fear2Pc
{
    public partial class Form1 : Form
    {
        string path = "";
       

        public Form1()
        {
            InitializeComponent();
            
            //string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
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
            labelIndicator.Parent = BackgroundImage;
            labelIndicator.ForeColor = Color.White;
            GameDirectoryLabel.ForeColor = Color.Red;
            FovLabel.Visible = false;
            FovInput.Visible = false;
            WindowedLabel.Visible = false;
            WYes.Visible = false;
            WNo.Visible = false;
            VersionLabel.Text = "Version 8";
            StartGame.Visible = false;
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
                    GameDirectoryLabel.ForeColor = Color.Red;
                }
                else if(File.Exists(path + "\\FEAR2.exe"))
                {
                    GameDirectoryLabel.Text = "Game Directory Set";
                    GameDirectoryLabel.ForeColor = Color.Green;
                    CreateCFG.Visible = true;
                    MouseFixDownload.Visible = true;
                    EnableMAFix.Visible = true;
                    MouseFixDownload.Visible = true;
                    IntroSkipArchiveDownload.Visible = true;
                    IntroSkipEnable.Visible = true;
                    DF2NoHud.Visible = true;
                    EnableF2NoHud.Visible = true;
                    FovLabel.Visible = true;
                    FovInput.Visible = true;
                    WindowedLabel.Visible = true;
                    WYes.Visible = true;
                    WNo.Visible = true;
                    labelIndicator.Text = "Select a fix";
                    StartGame.Visible = true;
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

        private async void MouseFixDownload_Click(object sender, EventArgs e)
        {
            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\X3DAudio1_5.dll";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\X3DAudio1_5.dll";
            if((!File.Exists(sourceDesktop)) && !File.Exists(sourceDownloads))
            {
                System.Diagnostics.Process.Start("https://community.pcgamingwiki.com/files/file/932-fear-2-mouse-fix/");
            }
            else
            {
                labelIndicator.Text = "Mouse fix Available";
            }

            
        }

        private void EnableMAFix_Click(object sender, EventArgs e)
        {

            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\X3DAudio1_5.dll";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\X3DAudio1_5.dll";
            var destination = Path.Combine(path + "\\X3DAudio1_5.dll");

           if(File.Exists(sourceDesktop))
           {
                File.Move(sourceDesktop, destination);
                labelIndicator.Text = "Mouse Fix enabled";
                labelIndicator.ForeColor = Color.Green;
            }
           else if(File.Exists(sourceDownloads))
           {
                File.Move(sourceDownloads, destination);
                labelIndicator.Text = "Mouse Fix enabled";
                labelIndicator.ForeColor = Color.Green;
            }
            else
            {
                labelIndicator.Text = "Mouse Fix not found";
                labelIndicator.ForeColor = Color.Red;
            }

            

        }

        private void IntroSkipArchiveDownload_Click(object sender, EventArgs e)
        {
            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\videos.zip";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\videos.zip";

            if(!File.Exists(sourceDesktop) && !File.Exists(sourceDownloads))
            {
                System.Diagnostics.Process.Start("https://community.pcgamingwiki.com/files/file/738-fear-2-skip-intro/");
            }
            else
            {
                labelIndicator.Text = "Intro Skip available";
            }
        }

        private void IntroSkipEnable_Click(object sender, EventArgs e)
        {
            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\videos.zip";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\videos.zip";
            //var destination = Path.Combine(path + "\\X3DAudio1_5.dll");

            

            //check if original files still exists and deletes them
            if (File.Exists(Path.Combine(path + "\\Game\\interface\\videos\\" + "360legalsplash.vib")))
            {
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "360legalsplash.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "esrb.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "gslogo.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "legalsplash.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "legalsplashnonus.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "legal_360_nonus.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "legal_pc_nonus.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "monolithbumper.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "wbglogo2.vib"));
                File.Delete(Path.Combine(path + "\\Game\\interface\\videos\\" + "wblogo.vib"));

                if (File.Exists(sourceDownloads))
                {
                    ZipFile.ExtractToDirectory(sourceDownloads, path + "\\Game\\interface\\videos\\");
                    File.Delete(sourceDownloads);
                    labelIndicator.Text = "Intro Skip Enabled";
                    labelIndicator.ForeColor = Color.Green;
                }
                else if (File.Exists(sourceDesktop))
                {
                    ZipFile.ExtractToDirectory(sourceDesktop, path + "\\Game\\interface\\videos\\");
                    File.Delete(sourceDesktop);
                    labelIndicator.Text = "Intro Skip Enabled";
                    labelIndicator.ForeColor = Color.Green;
                }
                else if(!File.Exists(sourceDesktop) && !File.Exists(sourceDownloads))
                {
                    labelIndicator.Text = "Intro Skip Not Found";
                    labelIndicator.ForeColor = Color.Red;
                }

            }
            else
            {
                ZipFile.ExtractToDirectory(sourceDownloads, path + "\\Game\\interface\\videos\\");
                labelIndicator.Text = "Intro Skip Enabled";
            }

            //check if videos.zip still exsits and deletes it
            if (File.Exists(sourceDesktop))
            {
                File.Delete(sourceDesktop);
            }
            else
            {
                File.Delete(sourceDownloads);
            }
        }

        private void CreatorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KasKillo/Fear-2-Fixer");
            labelIndicator.Text = "Thanks for checking \n my profile";
        }

        private void DF2NoHud_Click(object sender, EventArgs e)
        {
            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Fear2NoHud.zip";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\Fear2NoHud.zip";

            if (!File.Exists(sourceDesktop) && !File.Exists(sourceDownloads))
            {
                System.Diagnostics.Process.Start("https://www.mediafire.com/file/2y6segj8qey3tb8/Fear2noHUD.zip/file");
            }
            else
            {
                labelIndicator.Text = "No Hud mod available";
            }
        }

        private void EnableF2NoHud_Click(object sender, EventArgs e)
        {
            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Fear2NoHud.zip";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\Fear2NoHud.zip";
            var ShaderFolder = new DirectoryInfo(Path.Combine(path + "\\Shaderoverride"));

            if (!File.Exists(path + "\\d3d9.dll"))
            {
                if (File.Exists(sourceDownloads))
                {
                    ZipFile.ExtractToDirectory(sourceDownloads, path);
                    File.Delete(sourceDownloads);
                    labelIndicator.Text = "No Hud Enabled";
                    labelIndicator.ForeColor = Color.Green;
                }
                else if (File.Exists(sourceDesktop))
                {
                    ZipFile.ExtractToDirectory(sourceDesktop, path);
                    File.Delete(sourceDesktop);
                    labelIndicator.Text = "No Hud Enabled";
                    labelIndicator.ForeColor = Color.Green;
                }
                else if(!File.Exists(sourceDesktop) && !File.Exists(sourceDownloads))
                {
                    labelIndicator.Text = "No Hud Mod not found";
                    labelIndicator.ForeColor = Color.Red;
                }
            }
            else
            {
                ShaderFolder.Delete(true);
                File.Delete(path + "\\d3d9.dll");
                labelIndicator.Text = "No Hud Deleted \n from the game";
                labelIndicator.ForeColor = Color.Green;
            }

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(path + "\\FEAR2.exe"));
            labelIndicator.Text = "Started F.E.A.R. 2";
            labelIndicator.ForeColor = Color.Green;
        }
    }
}
