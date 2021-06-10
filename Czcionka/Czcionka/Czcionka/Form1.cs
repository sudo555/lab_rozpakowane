using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czcionka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] heights = { radioButton1, radioButton2, radioButton3 };
            CheckBox[] fontStyle = { checkBox1, checkBox2, checkBox3 };
            RadioButton[] fontColor = { radioButton4, radioButton5, radioButton6 };

            // Wielkość
            if (heights[0].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, 9);
            else if (heights[1].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, 12);
            else if (heights[2].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, 16);

            // Styl czcionki
            if (fontStyle[0].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, System.Drawing.FontStyle.Bold);
            if (fontStyle[1].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, System.Drawing.FontStyle.Italic);
            if (fontStyle[2].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, System.Drawing.FontStyle.Underline);
            if (fontStyle[0].Checked & fontStyle[1].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, System.Drawing.FontStyle.Bold | FontStyle.Italic);
            if (fontStyle[0].Checked & fontStyle[2].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, System.Drawing.FontStyle.Bold | FontStyle.Underline);
            if (fontStyle[1].Checked & fontStyle[2].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, System.Drawing.FontStyle.Italic | FontStyle.Underline);
            if (fontStyle[0].Checked & fontStyle[1].Checked & fontStyle[2].Checked) textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | FontStyle.Underline);

            // Kolor czcionki
            if (fontColor[0].Checked) textBox1.ForeColor = Color.Red;
            else if (fontColor[1].Checked) textBox1.ForeColor = Color.Blue;
            else if (fontColor[2].Checked) textBox1.ForeColor = Color.Orange;
        }
    }
}
