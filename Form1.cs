﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;            //string storing user input
        string operand1 = string.Empty;         //string storing first operand
        string operand2 = string.Empty;         //string storing second operand
        char operation;                         //char for operation
        double result = 0.0;                    //calculated result
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "7";
            this.textBox2.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "8";
            this.textBox2.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "9";
            this.textBox2.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "4";
            this.textBox2.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "5";
            this.textBox2.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "6";
            this.textBox2.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "1";
            this.textBox2.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "3";
            this.textBox2.Text += input;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox2.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox2.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox2.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox2.Text = result.ToString();
                }
                else
                {
                    textBox2.Text = "DIV/Zero!";
                }

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "0";
            this.textBox2.Text += input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += ".";
            this.textBox2.Text += input;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
