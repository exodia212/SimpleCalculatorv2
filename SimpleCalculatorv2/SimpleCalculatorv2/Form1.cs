using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace SimpleCalculatorv2
{
    public partial class Form1 : Form
    {
        
        string first, second, userInput = "";
        char function; //remember that a char needs to have a character associated to it, at the very least
        double result = 0.0;

        public Form1()
        {
            
            InitializeComponent(); 
            //method in vs.net that automatically created and managed by windows forms designer
            //and it defines everything you see on the form
        }

        private void button_1_Click(object sender, EventArgs e) //this should remain private void because other buttons won't be using what this button does
        {            
            calculatorDisplay.Text = ""; //this erases the previous input
            userInput += "1"; //this puts in the input from the user to the label
            calculatorDisplay.Text += userInput; //this keeps the input
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = ""; //calculator display just refers to the 
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            function = '.';
            first = userInput;
            userInput = "";
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            
            second = userInput;
            double firstNum, secondNum;
            try
            {
                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);
            }
            catch 
            {                
                calculatorDisplay.Text = "get some inputs foo";
                return; 
            }
            //add
            if (function == '+') //the 'function' is just a variable
            //these methods are used to call upon the operators
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //subtract
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //divide
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    calculatorDisplay.Text = "Nah";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
            }
            //multiply
            else if (function == 'X')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            else { return; }
        }
        private void button_divide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = ""; //userInput is used to send an output to the display, which in this 
            //case shouldn't have any output
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            function = 'X';
            first = userInput;
            userInput = "";
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            
            first = ""; //this clears the first number input from the user
            second = ""; //this clears the second number input from the user
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0"; 
        }
    }
}