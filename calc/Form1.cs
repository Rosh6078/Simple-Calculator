using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double a, b, c;

        public object panel_light { get; private set; }

        private void Txt3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Mul_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            c = a * b;
            txt3.Text = c.ToString();
        }

        private void Quot_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            c = a / b;
            txt3.Text = c.ToString("0.####");
        }

        private void Modu_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            c = a % b;
            txt3.Text = c.ToString("0.####");
        }

        private void Min_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            c = a - b;
            txt3.Text = c.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txt1.Text = null ;
            txt2.Text = null;
            txt3.Text = null;
        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsNumber(chr))
            {
                e.Handled = true;
                MessageBox.Show("Enter a numeric value");
            }
        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr))
            {
                e.Handled = true;
                MessageBox.Show("Enter a numeric value");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "OFF")
            {
                button2.BackColor = Color.Green;
               
                button2.Text = "ON";

                txt1.Enabled = true;
                txt2.Enabled = true;
                add.Enabled = true;
                mul.Enabled = true;
                quot.Enabled = true;
                min.Enabled = true;
                modu.Enabled = true;
                button1.Enabled =true;
            }
            else if (button2.Text == "ON") {
                button2.BackColor = Color.IndianRed;
                
                button2.Text = "OFF";
                txt1.Enabled = false;
                txt2.Enabled = false;
                add.Enabled = false;
                mul.Enabled = false;
                quot.Enabled = false;
                min.Enabled = false;
                modu.Enabled = false;
                button1.Enabled = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            c = a + b;
            txt3.Text = c.ToString();
        }
    }
}
