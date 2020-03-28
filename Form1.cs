using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private String operation = "";
        private bool operation_pressed = false;
        private Double value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || operation_pressed)
            {
                result.Clear();
            }
            operation_pressed = false;
            Button numBtn = (Button)sender; //convert the sender object to a button
            if (numBtn.Text.Equals(".")) //check for multiple decimal points
            {
                if (!result.Text.Contains("."))
                {
                    result.Text = result.Text + numBtn.Text;
                }
            }
            else
            {
                result.Text = result.Text + numBtn.Text;
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
            equation.Text = "";
            value = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button opBtn = (Button)sender;


            if (value != 0) // chain operations
            {
                equal.PerformClick();//click result button
                operation_pressed = true;
                operation = opBtn.Text;
                equation.Text = value +  " " + operation;

            }
            else
            {
                operation_pressed = true;
                operation = opBtn.Text;
                value = Double.Parse(result.Text);
                equation.Text = value + " " + operation;
            }
        }

        private void res_click(object sender, EventArgs e)
        {
            operation_pressed = false;
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            equal.Focus();
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    divide.PerformClick();
                    break;
                case "ENTER":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}