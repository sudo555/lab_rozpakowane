using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematyka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z, sum;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            sum = x + y + z;
            textBox4.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, z, product;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            product = x * y * z;
            textBox4.Text = product.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if( !int.TryParse(textBox1.Text, out _)) // Sprawdza czy string nie jest liczbą
            {
                if( textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                else
                {
                    textBox1.Text = "";
                }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out _)) // Sprawdza czy string nie jest liczbą
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    textBox2.SelectionStart = textBox2.Text.Length;
                }
                else
                {
                    textBox2.Text = "";
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out _)) // Sprawdza czy string nie jest liczbą
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
                    textBox3.SelectionStart = textBox3.Text.Length;
                }
                else
                {
                    textBox3.Text = "";
                }

            }
        }
    }
}
