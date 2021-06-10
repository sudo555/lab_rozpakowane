using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Grade grade;
        public Window2()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, RoutedEventArgs e)
        {
            this.grade = grade ?? new Grade(5,5,5,5);
            grade.polish = Convert.ToDouble(polishGrade.Text.Replace('.',','));
            grade.english = Convert.ToDouble(englishGrade.Text.Replace('.', ','));
            grade.math = Convert.ToDouble(mathGrade.Text.Replace('.', ','));
            grade.physic = Convert.ToDouble(physicGrade.Text.Replace('.', ','));
            this.DialogResult = true;
        }
    }
}
