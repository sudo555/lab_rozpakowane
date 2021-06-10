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

namespace WpfApp1
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

        private void suma_Click(object sender, RoutedEventArgs e)
        {
            double a, b, suma;
            string znacznik = "Suma =";
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            suma = a + b;
            string wynik = suma.ToString();
            
            result.Content = znacznik+ a +"+"+ b + "=" + wynik;
        }

        private void iloczyn_Click(object sender, RoutedEventArgs e)
        {
            double a, b, iloczyn;
            string znacznik1 = "Iloczyn =";
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            iloczyn = a * b;
            string wynik1 = iloczyn.ToString();
            result.Content = znacznik1 + a + "*" + b + "=" + wynik1;
        }

        private void iloraz_Click(object sender, RoutedEventArgs e)
        {
            double a, b, iloraz;
            string znacznik2 = "Iloraz =";
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            iloraz = a / b;
            string wynik2 = iloraz.ToString();
            result.Content = znacznik2 + a + "/" + b + "=" + wynik2;
        }

        private void roznica_Click(object sender, RoutedEventArgs e)
        {
            double a, b, roznica;
            string znacznik3 = "Roznica =";
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            roznica = a - b;
            string wynik3 = roznica.ToString();
            result.Content = znacznik3 + a + "-" + b + "=" + wynik3;
        }
    }
}
