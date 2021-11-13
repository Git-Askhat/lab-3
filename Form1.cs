using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(input1.Text);
            double b = Convert.ToDouble(input2.Text);
            double c = Convert.ToDouble(input3.Text);
            double result = (i + b) / c;
            output1.Text = Convert.ToString(result);
        }

        private void answer2_Click(object sender, EventArgs e)
        {

            if (ten.Checked == true)
                output2.Text = Convert.ToString(Convert.ToDouble(output1.Text) * 10 / 100);
            if (twenty.Checked == true)
                output2.Text = Convert.ToString(Convert.ToDouble(output1.Text) * 20 / 100);
            if (fifty.Checked == true)
                output2.Text = Convert.ToString(Convert.ToDouble(output1.Text) * 50 / 100);
        }
    }
}
