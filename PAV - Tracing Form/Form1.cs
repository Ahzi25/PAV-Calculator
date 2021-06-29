using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV___Tracing_Form
{
    public partial class Form1 : Form
    {
        List<string> Details = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstnameTB.Clear();
            LastnameTB.Clear();
            StreetAddressTB.Clear();
            CityTB.Clear();
            ProvinceTB.Clear();
            PostalCodeTB.Clear();
            SexTB.Clear();
            DateOfBirthTB.Clear();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            String Title = "Contact Tracing Form";
            Button confirm = (Button)sender;
            confirm.DialogResult = DialogResult.OK; 
            MessageBox.Show("Your response has been saved. Thank you!", Title);
        }
    }
}

