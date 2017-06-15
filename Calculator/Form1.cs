using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            //This eliminates the 0 from showing up in the results box before the other numbers
            if ((Result.Text == "0")||(operation_pressed))
                Result.Clear();

            //Parses the button to be text and display on the results when clicked
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        //Simple clear text results functionality for the clear button
        private void button16_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        //This is how the add, sub, multiply, division operator understands being clicked
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true;
        }

        //This controls the operator click above and how to differentiate between operations
        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    Result.Text = (value + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (value / Double.Parse(Result.Text)).ToString();
                    break;
            }
            operation_pressed = false;
        }

        //The clear button
        private void button17_Click(object sender, EventArgs e)
        {
            Result.Clear();
            value = 0;
        }
    }
}
