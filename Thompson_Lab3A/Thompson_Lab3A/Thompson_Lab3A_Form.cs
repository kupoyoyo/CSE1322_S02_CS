using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thompson_Lab3A
{
    public partial class Thompson_Lab3A_Form : Form
    {
        public Thompson_Lab3A_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Button 1 was clicked";
            MessageBox.Show("Button 1 was clicked");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Button 2 was clicked";
            MessageBox.Show("Button 2 was clicked");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Button 3 was clicked";
            MessageBox.Show("Button 3 was clicked");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Button 4 was clicked";
            MessageBox.Show("Button 4 was clicked");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Button 5 was clicked";
            MessageBox.Show("Button 5 was clicked");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Button 6 was clicked";
            MessageBox.Show("Button 6 was clicked");
        }
        private void Thompson_Lab3A_Form_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
