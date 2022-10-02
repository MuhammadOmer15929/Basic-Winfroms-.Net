using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, sum;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                sum = num1 + num2;
                label4.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Enter Valid Number", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int num1, num2, sub;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                sub = num1 - num2;
                label4.Text = sub.ToString();
            }
            catch
            {
                MessageBox.Show("Enter Valid Number", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int num1, num2, Mul;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                Mul = num1 * num2;
                label4.Text = Mul.ToString();
            }
            catch
            {
                MessageBox.Show("Enter Valid Number", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, Div;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                Div = num1 / num2;
                label4.Text = Div.ToString();
            }
            catch
            {
                MessageBox.Show("Enter Valid Number", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            label4.Text = " ";

        }
    }
}
