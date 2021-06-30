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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string text = File.ReadAllText("C:\\Users\\paula\\source\\repos\\PAV - Tracing Form\\Details.txt");
            MessageBox.Show(text);
            var data = text.Split(",");
            dataGridView1.Rows.Add(data);
        }
    }
}
