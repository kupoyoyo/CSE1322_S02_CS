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

namespace Thompson_Lab6B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L_saveComplete.Text = "";
        }

        private void B_openFile_Click(object sender, EventArgs e)
        {
            T_fileOutput.Text = "";
            StreamReader sr = new StreamReader(T_fileSearch.Text);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                T_fileOutput.Text += s;
            }
            sr.Close();
        }

        private void B_saveFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(T_fileSearch.Text);
            sw.Write(T_fileOutput.Text);
            sw.Close();
            L_saveComplete.Text = "Save to " + T_fileSearch.Text + " complete";
        }
    }
}
