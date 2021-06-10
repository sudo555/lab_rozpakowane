using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            double equation = 0;
            double activityRatio = 0;
            RadioButton[] radioButton = { RadioButton1, RadioButton2, RadioButton3, RadioButton4, RadioButton5 };

            if(CheckBox1.IsChecked == true) // Wybrano mężczyznę
            {
                try
                {
                    equation = 66 + (13.7 * Convert.ToDouble(TextBox2.Text) + (5 * Convert.ToDouble(TextBox1.Text)) - (6.8 * Convert.ToDouble(TextBox4.Text)));
                    TextBox3.Text = "BMR: " + equation.ToString() + " kcal";
                }
                catch
                {
                    TextBox3.Text = "Błąd";
                }
                
            }
            else if (CheckBox2.IsChecked == true) // Wybrano kobietę
            {  
                try
                {
                    equation = 655 + (9.6 * Convert.ToDouble(TextBox2.Text) + (1.8 * Convert.ToDouble(TextBox1.Text)) - (4.7 * Convert.ToDouble(TextBox4.Text)));
                    TextBox3.Text = "BMR: " + equation.ToString() + " kcal";
                }
                catch
                {
                    TextBox3.Text = "Błąd";
                }
            }

            if (radioButton[0].IsChecked == true) activityRatio = 1.2;
            else if (radioButton[1].IsChecked == true) activityRatio = 1.375;
            else if (radioButton[2].IsChecked == true) activityRatio = 1.55;
            else if (radioButton[3].IsChecked == true) activityRatio = 1.725;
            else if (radioButton[4].IsChecked == true) activityRatio = 1.9;
            
            TextBox5.Text = "Całkowite spalanie: " + String.Format("{0:F2}", equation * activityRatio) + " kcal";
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(TextBox1.Text, out _)) // Sprawdza czy string nie jest liczbą
            {
                if (TextBox1.Text.Length > 0)
                {
                    TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1);
                    TextBox1.SelectionStart = TextBox1.Text.Length;
                }
                else
                {
                    TextBox1.Text = "";
                }
            }
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(TextBox2.Text, out _)) // Sprawdza czy string nie jest liczbą
            {
                if (TextBox2.Text.Length > 0)
                {
                    TextBox2.Text = TextBox2.Text.Substring(0, TextBox2.Text.Length - 1);
                    TextBox2.SelectionStart = TextBox2.Text.Length;
                }
                else
                {
                    TextBox2.Text = "";
                }
            }
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(TextBox4.Text, out _)) // Sprawdza czy string nie jest liczbą
            {
                if (TextBox4.Text.Length > 0)
                {
                    TextBox4.Text = TextBox4.Text.Substring(0, TextBox4.Text.Length - 1);
                    TextBox4.SelectionStart = TextBox4.Text.Length;
                }
                else
                {
                    TextBox4.Text = "";
                }
            }
        }

        private void CheckBox1_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox1.IsChecked == true)
            {
                if (CheckBox2.IsChecked == true) CheckBox2.IsChecked = false;
            }
        }

        private void CheckBox2_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox2.IsChecked == true)
            {
                if (CheckBox1.IsChecked == true) CheckBox1.IsChecked = false;
            }
        }
    }
}
