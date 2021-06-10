using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealneBMI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Guzik oblicz
        {
            double standardWeight = 0, idealWeight = 0, ratio = 0 ,height = 0;
            try
            {
                height = Convert.ToDouble(textBox1.Text); // Zamienia wzrost ze string na double
                standardWeight = height - 100;

                if (checkBox1.Checked) // Jeżeli waga standardowa zaznaczona
                {  
                    label3.Text = standardWeight.ToString();
                }

                if (checkBox2.Checked) // Jeżeli waga idealna zaznaczona
                {
                    if (radioButton1.Checked) ratio = 0.85;
                    if (radioButton2.Checked) ratio = 0.9;
                    idealWeight = standardWeight * ratio ;
                    label3.Text = idealWeight.ToString();
                }

            }
            catch
            {
                label3.Text = "Błąd";
            }  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Waga standardowa
        {
            if(checkBox1.Checked) 
            {
                checkBox2.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // Waga idealna
        {
            if (checkBox2.Checked)
            {
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // TextBox na wzrost
        {
            if (!int.TryParse(textBox1.Text, out _)) // Sprawdza czy string nie jest liczbą
            {
                if (textBox1.Text.Length > 0)
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
    }
}
