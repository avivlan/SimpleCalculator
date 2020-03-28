using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_pressed)
            {
                result.Clear();
            }
            operation_pressed = false;
            Button numBtn = (Button)sender; //convert the sender object to a button 
            result.Text = result.Text + numBtn.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            operation_pressed = true;
            Button opBtn = (Button)sender;
            operation = opBtn.Text;
            value = Double.Parse(result.Text);
            equation.Text = value + operation;

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
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
            equation.Text = "";
            value = 0;
        }
    }
    }
