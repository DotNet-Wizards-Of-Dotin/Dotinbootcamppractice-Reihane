using EventExample.CustomButton;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Part13_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void myButton1_BeforeClick(object sender, EventArgs e)
        {
            MessageBox.Show("Before : " + (sender as Button).Name);
        }

        private void myButton1_AfterClick(object sender, EventArgs e)
        {
            MessageBox.Show("After : " + (sender as Button).Name);
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 is clicked");
        }

        private void myButton2_AfterClick(object sender, EventArgs e)
        {
            MessageBox.Show("after 2 : congrats !!");
        }

        private void myButton2_BeforeClick(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want the After method to be executed?", null, MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
                myButton2.Condition = true;
            else
                myButton2.Condition = false;
        }
    }
}