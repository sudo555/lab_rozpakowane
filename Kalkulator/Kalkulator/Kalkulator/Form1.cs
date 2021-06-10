using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string equation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            equation += "1";
            textBox1.Text = equation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equation += "2";
            textBox1.Text = equation;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            equation += "3";
            textBox1.Text = equation;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            equation += "4";
            textBox1.Text = equation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            equation += "5";
            textBox1.Text = equation;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            equation += "6";
            textBox1.Text = equation;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            equation += "7";
            textBox1.Text = equation;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            equation += "8";
            textBox1.Text = equation;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            equation += "9";
            textBox1.Text = equation;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            equation += "0";
            textBox1.Text = equation;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(equation != "" )
            {
                equation += ".";
                textBox1.Text = equation;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            equation += "+";
            textBox1.Text = equation;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            equation += "-";
            textBox1.Text = equation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation += "*";
                textBox1.Text = equation;
            }
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation += "/";
                textBox1.Text = equation;
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            equation = "";
            textBox1.Text = equation;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(new DataTable().Compute(equation, null));
                if (double.IsFinite(result))
                {
                    equation = result.ToString();
                    textBox1.Text = equation;
                }
                else
                {
                    textBox1.Text = "Błąd";
                }
            }
            catch
            {
                textBox1.Text = "Błąd";
            }
            
          
            
        }
    }
}
