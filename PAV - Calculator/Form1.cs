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

        private void PlusButton_Click(object sender, EventArgs e)
        {

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "2";
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + ".";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {

        }

        private void EraseButton_Click(object sender, EventArgs e)
        {

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "6";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "9";
        }

        private void SquarerootButton_Click(object sender, EventArgs e)
        {

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "5";
        }

        private void ReciprocalButton_Click(object sender, EventArgs e)
        {

        }

        private void SquareButton_Click(object sender, EventArgs e)
        {

        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "8";
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "%";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "7";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "4";
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "1";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "0";
        }

        private void TotalDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StandardLabel_Click(object sender, EventArgs e)
        {

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (TotalDisplay.Text == "0")
                TotalDisplay.Clear();
            TotalDisplay.Text = TotalDisplay.Text + "3";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
     
        }

        private void ClearentryButton_Click(object sender, EventArgs e)
        {
            TotalDisplay.Clear();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void DivideButton_Click_1(object sender, EventArgs e)
        {

        }

        private void Table1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
