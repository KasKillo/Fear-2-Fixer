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

namespace Fear2Pc
{
    public partial class Form1 : Form
    {
        string path = "";

        public Form1()
        {
            InitializeComponent();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void GDButton_Click(object sender, EventArgs e)
        {
            if (FovInput.Text.Length != 0)
            {
                FolderBrowserDialog folderbrowserdialog = new FolderBrowserDialog();
                folderbrowserdialog.ShowDialog();
                path = folderbrowserdialog.SelectedPath;
                Console.WriteLine(folderbrowserdialog.SelectedPath);

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

                if (path == "")
                {
                    label3.Text = "Game Directory Not Set";
                }
                else
                {
                    label3.Text = path;
                }

                Console.WriteLine(writer);
                writer.Close();
                stream.Close();
            }
            
        }

        private void DIGIT_ONLY(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
