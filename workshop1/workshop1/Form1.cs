using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workshop1
{
    public partial class Form1 : Form
    {

        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1add_Click(object sender, EventArgs e)
            
        {
            //datatype
            //string
            //int   -- จำนวนเต็ม
            //double -- ทศนิยม
            string userinput =textBoxInput.Text;
            textBoxInput.Text =  userinput +  " KKU";
            // String.Format("{0} {1} " , userinput , "KKU");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "0";
        }




        string operation;
        string number1 =string.Empty;
        ///////////////////////////     +
        private void button11_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text =string.Empty;
            //save operation
            operation = "+";

        }
        ///                             =
        private void button12_Click(object sender, EventArgs e)
        {
            string number2 = textBoxInput.Text;
            int num1 =int.Parse(number1);   
            int num2 =int.Parse(number2);
            if (operation == "+")
            {

            int output = num1+ num2;
            textBoxInput.Text = output.ToString();
            
            }
            else if (operation == "-")
            {
                int output = num1 - num2;
                textBoxInput.Text = output.ToString();

            }
            else if (operation == "x")
            {
                int output = num1 * num2;
                textBoxInput.Text = output.ToString();

            }
            else if (operation == "/")
            {
                int output = num1 / num2;
                textBoxInput.Text = output.ToString();

            }




        }
        /// /                     -
        private void button13_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            //save operation
            operation = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            //save operation
            operation = "x";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            //save operation
            operation = "/";
        }
    }
}
