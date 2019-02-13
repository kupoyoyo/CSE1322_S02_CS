using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thompson_Assignment3B
{
    public partial class Form1 : Form
    {
        double firstNum;
        string operation;
        public Form1()
        {
            InitializeComponent();
            input.Text = "";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
            input.Text += "0";    
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
            input.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
            input.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
            input.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
            input.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
            input.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
            input.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
            input.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
            input.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
            input.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            textBox.Text = "0";
            input.Text += "+";
            operation = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            textBox.Text = "0";
            input.Text += "-";
            operation = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            textBox.Text = "0";
            input.Text += "*";
            operation = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox.Text);
            textBox.Text = "0";
            input.Text += "/";
            operation = "/";
        }

        private void dec_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
            input.Text += ".";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            input.Text = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double secondNum = double.Parse(textBox.Text);
            double result;

            if (operation == "+")
            {
                result = firstNum + secondNum;
                textBox.Text = Convert.ToString(result);
                firstNum = result;
                input.Text += " = " + Convert.ToString(result);
            }
            if (operation == "-")
            {
                result = firstNum - secondNum;
                textBox.Text = Convert.ToString(result);
                firstNum = result;
                input.Text += " = " + Convert.ToString(result);
            }
            if (operation == "*")
            {
                result = firstNum * secondNum;
                textBox.Text = Convert.ToString(result);
                firstNum = result;
                input.Text += " = " + Convert.ToString(result);
            }
            if (operation == "/")
            {
                if (secondNum == 0)
                    textBox.Text = "Can't divide by zero";
                else
                {
                    result = firstNum / secondNum;
                    textBox.Text = Convert.ToString(result);
                    firstNum = result;
                    input.Text += " = " + Convert.ToString(result);
                }
            }
        }
    }
}
