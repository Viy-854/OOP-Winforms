using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sum = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text);
            label1.Text = sum + "";
            int diff = Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text);
            label2.Text = diff + "";
            int prod = Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text);
            label3.Text = prod + "";
            int quo = Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text);
            label4.Text = quo + "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
