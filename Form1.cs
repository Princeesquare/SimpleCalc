using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double x,y,z, res;
            if (textBox1.Text != null && textBox2.Text == "" && textBox3.Text == "")
            {
                x = Convert.ToDouble(textBox1.Text);
                res = Math.Sin(x);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
           else if (textBox1.Text != null && textBox2.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                res = Math.Sin(x) * Math.Sin(y);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
            else if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);
                res = Math.Sin(x) * Math.Sin(y) * Math.Sin(z);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double x, y, z, res;
            if (textBox1.Text != null && textBox2.Text == "" && textBox3.Text == "")
            {
                x = Convert.ToDouble(textBox1.Text);
                res = Math.Cos(x);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
            else if (textBox1.Text != null && textBox2.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                res = Math.Cos(x) * Math.Cos(y);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
            else if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);
                res = Math.Cos(x) * Math.Cos(y) * Math.Cos(z);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }

        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double x, y, z, res;
            if (textBox1.Text != null && textBox2.Text == "" && textBox3.Text == "")
            {
                x = Convert.ToDouble(textBox1.Text);
                res = Math.Tan(x);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
            else if (textBox1.Text != null && textBox2.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                res = Math.Tan(x) * Math.Tan(y);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
            else if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);
                res = Math.Tan(x) * Math.Tan(y) * Math.Tan(z);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
        }

        private void Exp_Click(object sender, EventArgs e)
        {
            double x, y, z, res;
            if (textBox1.Text != null && textBox2.Text == "" && textBox3.Text == "")
            {
                x = Convert.ToDouble(textBox1.Text);
                res = Math.Exp(x);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
            else if (textBox1.Text != null && textBox2.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                res = Math.Exp(x) * Math.Exp(y);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
            else if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);
                res = Math.Exp(x) * Math.Exp(y) * Math.Exp(z);
                MessageBox.Show(res.ToString());
                result.Text = result.Text + res.ToString();
            }
        }
    }
}
