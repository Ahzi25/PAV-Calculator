using System;
using PAV__Calculator;

namespace PAV__Calculator 
{
    public class Calculator
    {
        public Class1()
        {
        }

        public class Calculator
        {
            Double resVal = 0;
            String operand = "";
            bool showprevoperation = false;
            string first_num, second_num;

            public static void GetNum()
            {
                Button button = (Button)sender;

                if ((TotalDisplay.Text == "0") || (showprevoperation))
                    TotalDisplay.Clear();
                showprevoperation = false;

                if (button.Text == ".")
                {
                    if (!TotalDisplay.Text.Contains("."))
                        TotalDisplay.Text += button.Text;
                }
                else
                {
                    TotalDisplay.Text += button.Text;
                }
            }

            public static void GetOperation()
            {
                Button op = (Button)sender;

                if (resVal != 0)
                {
                    EqualButton.PerformClick();
                    showprevoperation = true;
                    operand = op.Text;
                    prevOperation.Text = resVal + " " + operand;
                }

                else
                {
                    operand = op.Text;
                    resVal = Double.Parse(TotalDisplay.Text);
                    showprevoperation = true;
                    prevOperation.Text = resVal + " " + operand;
                }
                first_num = prevOperation.Text;
            }
            public static void GetResult()
            {
                switch (operand)
                {
                    case "+":
                        {
                            TotalDisplay.Text = (resVal + Double.Parse(TotalDisplay.Text)).ToString();
                            second_num = (Double.Parse(TotalDisplay.Text) - resVal).ToString();
                            prevOperation.Text = first_num + " " + second_num + " " + "=";
                            break;
                        }
                    case "-":
                        {
                            TotalDisplay.Text = (resVal - Double.Parse(TotalDisplay.Text)).ToString();
                            second_num = ((Double.Parse(TotalDisplay.Text) - resVal) * -1).ToString();
                            prevOperation.Text = first_num + " " + second_num + " " + "=";
                            break;
                        }
                    case "×":
                        {
                            TotalDisplay.Text = (resVal * Double.Parse(TotalDisplay.Text)).ToString();
                            second_num = (Double.Parse(TotalDisplay.Text) / resVal).ToString();
                            prevOperation.Text = first_num + " " + second_num + " " + "=";
                            break;
                        }
                    case "÷":
                        {
                            TotalDisplay.Text = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                            second_num = (resVal / Double.Parse(TotalDisplay.Text)).ToString();
                            prevOperation.Text = first_num + " " + second_num + " " + "=";
                            break;
                        }
                    default:
                        break;
                }
                //resVal = Double.Parse(TotalDisplay.Text);
                operand = "";
            }

            public static void GetReciprocal()
            {
                TotalDisplay.Text = (1 / Double.Parse(TotalDisplay.Text)).ToString();
            }
            public static void GetSquare()
            {
                prevOperation.Text = "sqr(" + TotalDisplay.Text + ")";
                TotalDisplay.Text = (Double.Parse(TotalDisplay.Text) * Double.Parse(TotalDisplay.Text)).ToString();
            }

            public static void GetSqareroot()
            {
                prevOperation.Text = "sqrt(" + TotalDisplay.Text + ")";
                TotalDisplay.Text = (Math.Sqrt(Double.Parse(TotalDisplay.Text))).ToString();
            }

            public static void GetNegative()
            {
                TotalDisplay.Text = (-1 * Double.Parse(TotalDisplay.Text)).ToString();
            }
            public static void GetPercentage()
            {
                TotalDisplay.Text = (Double.Parse(TotalDisplay.text) / 100).toString();
            }

            public static void Clear()
            {
                TotalDisplay.Text = "0";
                prevOperation.Text = "";
            }

            public static void ClearEntry()
            {
                TotalDisplay.Text = "0";
                resVal = 0;
            }
            public static void Erase()
            {
                if (TotalDisplay.Text != "")
                    TotalDisplay.Text = TotalDisplay.Text.Remove(TotalDisplay.Text.Length - 1);
            }

        }
    }
}

