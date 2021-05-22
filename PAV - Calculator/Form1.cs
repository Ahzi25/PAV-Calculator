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
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            
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

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text += "5";
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
        }

        private void ClearentryButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Text = "0";

        }

        private void Table1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {

        }

        private void Numbutton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();

            Button button = (Button)sender;
            TotalDisplay.Text += button.Text;
        }
    }
}
