using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblRed_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void lblYellow_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;

        }

        private void lblGreen_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

        }

        private void lblBlue_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void lblOrange_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;

        }

        private void Form2_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}