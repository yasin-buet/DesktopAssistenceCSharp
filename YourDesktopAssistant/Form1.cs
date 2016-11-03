using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourDesktopAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            /*
            var dir = Directory.GetCurrentDirectory();
            
            if (File.Exists(@"E:\a.txt"))
            {
                var a = "File is found";
                Directory.GetFiles(@"E:\a.txt");
                //Process.Start(@"E:/a.txt");
            } else
                throw new FileNotFoundException();
            */



            if (checkBox1.Checked)
            {
                var domain_1 = checkBox1.Text;
                Process.Start("www." + domain_1 + ".com");
            }
            if (checkBox2.Checked)
            {
                var domain_2 = checkBox2.Text;
                Process.Start("www." + domain_2 + ".com");
            }
            if (checkBox3.Checked)
            {
                var domain_3 = checkBox3.Text;
                Process.Start("www." + domain_3 + ".com");
            }
            if (checkBox4.Checked)
            {
                var domain_4 = checkBox4.Text;
                Process.Start("www." + domain_4 + ".com");
            }
            //Process.Start(@"E:\csharp_tutorial");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox1.SelectedText = fbd.SelectedPath;

        }
    }
}
