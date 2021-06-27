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
        bool showprevoperation = false;
        string first_num, second_num;

        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Numbutton_Click(object sender, EventArgs e)
        {
            Cal.GetNum();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Calculator.GetOperation();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            Calculator.GetResult();
        }

        private void ReciprocalButton_Click(object sender, EventArgs e)
        {
            Calculator.GetReciprocal();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Calculator.GetSquare();
        }

        private void SquarerootButton_Click(object sender, EventArgs e)
        {
            Calculator.GetSqareroot();
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            Calculator.GetPercentage();
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {
            Calculator.GetNegative();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Calculator.Clear();
        }

        private void ClearentryButton_Click(object sender, EventArgs e)
        {
            Calculator.ClearEntry();

        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            Calculator.Erase();
        }

        private void Table1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StandardLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void TotalDisplay_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
