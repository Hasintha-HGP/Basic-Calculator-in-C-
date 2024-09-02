using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string caltotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            value.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value.Text += button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            value.Text += button3.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            value.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            value.Text += button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            value.Text += button8.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            value.Text += button11.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            value.Text += button12.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            value.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if(value.Text.Length > 0)
            {
                value.Text += button14.Text;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            value.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "+";
            num1=int.Parse(value.Text);
            value.Clear();
           

        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(value.Text);
            if (option.Equals("+"))
            {
                result=num1+num2;

            }
            if (option.Equals("-"))
            {
                result = num1 - num2;

            }
            if (option.Equals("*"))
            {
                result = num1 * num2;

            }
            if (option.Equals("/"))
            {
                result = num1 / num2;

            }
            value.Text=result.ToString();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(value.Text);
            value.Clear();
        }

        private void MULTY_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(value.Text);
            value.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(value.Text);
            value.Clear();
        }
    }
}
