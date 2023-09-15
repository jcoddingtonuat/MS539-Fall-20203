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
    public partial class Form2 : Form
    {
        public Form2(string tr)
        {
            InitializeComponent();
            textBox1.Text = tr;
            progressBar1.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(textBox1.Text);
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value <100)
            {
                progressBar1.Value += 25;
            }
        }
    }
}
