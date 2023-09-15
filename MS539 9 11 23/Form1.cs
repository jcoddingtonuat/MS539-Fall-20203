using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_9_11_23
{
    public partial class Form1 : Form
    {
        int num1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("I love C#");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("Valid int");
            }
            else
            {
                MessageBox.Show("NOT Valid int");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Networking is a required skill";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox2.Text = "You are qualified";

            }
            else
            {
                textBox2.Text = " ";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "You have just started";
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = "Congrats - you are excelling";
            }
            else
                MessageBox.Show("You must make a type choice");
        }
    }
}
