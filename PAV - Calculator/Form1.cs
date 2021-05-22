using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV___Calculator
{
    public partial class Form1 : Form
    {
        Double resVal = 0;
        String operand = "";
        String first_num = "";
        String sec_num = "";
        bool showprevoperation = false;

        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Numbutton_Click(object sender, EventArgs e)
        {
            if ((TotalDisplay.Text == "0") || (showprevoperation))
                TotalDisplay.Clear();

            showprevoperation = false;
            Button button = (Button)sender;
            TotalDisplay.Text += button.Text;
            
            if (resVal != 0)
            {
                sec_num = button.Text;
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text += ".";
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text != "")
                TotalDisplay.Text = TotalDisplay.Text.Remove(TotalDisplay.Text.Length - 1);
        }

        private void SquarerootButton_Click(object sender, EventArgs e)
        {

        }

        private void ReciprocalButton_Click(object sender, EventArgs e)
        {

        }

        private void SquareButton_Click(object sender, EventArgs e)
        {

        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text += "%";
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {

        }

        private void TotalDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StandardLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Text = "0";
            prevOperation.Text = "";
        }

        private void ClearentryButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Text = "0";
            resVal = 0;

        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            operand = op.Text;
            resVal = Double.Parse(TotalDisplay.Text);
            prevOperation.Text = resVal + " " + operand;
            showprevoperation = true;   
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            switch (operand)
            {
                case "+":
                    TotalDisplay.Text = (resVal + Double.Parse(TotalDisplay.Text)).ToString();
                    first_num = (Double.Parse(TotalDisplay.Text) - Byte.Parse(sec_num)).ToString();
                    prevOperation.Text = first_num + " " + "+" + " " + sec_num + " " + "=";
                    break;
                case "-":
                    TotalDisplay.Text = (resVal - Double.Parse(TotalDisplay.Text)).ToString();
                    break;
                case "*":
                    TotalDisplay.Text = (resVal * Double.Parse(TotalDisplay.Text)).ToString();
                    break;
                case "/":
                    TotalDisplay.Text = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Table1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
