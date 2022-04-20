using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_gss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text);
            label1.Text = Convert.ToString(Convert.ToInt32(x));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "*";
            button4.Text = "/";
            label1.Text = "Тут будет ответ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text);
            label1.Text = Convert.ToString(Convert.ToInt32(x));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text);
            label1.Text = Convert.ToString(Convert.ToInt32(x));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text);
            label1.Text = Convert.ToString(Convert.ToInt32(x));
        }
    }
}
