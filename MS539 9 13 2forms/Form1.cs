using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_9_13_2forms
{
    public partial class Form1 : Form
    {

        public Form1(string from2 = "asdf")
        {
            InitializeComponent();
            textBox1.Text = from2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2(textBox1.Text);
            f2.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            { MessageBox.Show("Dogs are great"); }
            else if (listBox1.SelectedIndex == 1)
            {
                MessageBox.Show("cute kitty");
            }
            else
            { MessageBox.Show("fish dont talk back"); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             Object selectedItem = comboBox1.SelectedItem;
            if (selectedItem.ToString() == "Freshman")
            {
                MessageBox.Show("Good start");
            }
            else if (selectedItem.ToString() == "Sophmore")
            {
                MessageBox.Show("You are 1/4 done");
            }
            else if (selectedItem.ToString() == "Junior")
            { MessageBox.Show("jr"); }
            else
            { MessageBox.Show("Almost done"); }
        }
    }
}
