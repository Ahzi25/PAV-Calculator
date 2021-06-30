using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PAV___Tracing_Form
{
    public partial class Form1 : Form
    {
        List<string> Details = new List<string>();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (x.Name.EndsWith("TB"))
                    {
                        x.Text = "";
                    }
                }
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    if (x.Name.EndsWith("TB"))
                    {
                        if(x.Text == "")
                        { 
                            String Title = "Contact Tracing Form";
                            Button confirm = (Button)sender;
                            confirm.DialogResult = DialogResult.OK;
                            MessageBox.Show("Please complete the form.", Title);
                            break;
                        }
                        else if(x.Text != "")
                        {
                            Details.Add(x.Text);
                            counter += 1;
                            if (counter == 8)
                            {
                                string forsaving = String.Join(",", Details);
                                TextWriter txt = new StreamWriter("C:\\Users\\paula\\source\\repos\\PAV - Calculator\\Details.txt");
                                txt.Write(forsaving + "\n");
                                txt.Close();
                                String Title = "Contact Tracing Form";
                                Button confirm = (Button)sender;
                                confirm.DialogResult = DialogResult.OK;
                                MessageBox.Show("Thank you for your response!", Title);
                                counter = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}

