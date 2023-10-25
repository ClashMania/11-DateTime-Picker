using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            rtbx1.Clear();

            DateTime date = dateTimePicker1.Value;
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Vas datum leta je: ");
            sb1.Append(date.ToShortDateString() + "\n");
            DateTime date2 = dateTimePicker2.Value;
            sb1.Append("Vase vrijeme polaska je: ");
            sb1.Append(date2.ToShortTimeString());
            rtbx1.AppendText(sb1.ToString());

        }
    }
}
