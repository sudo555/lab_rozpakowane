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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Student student;
        Grade gradeI = new Grade(5.0,5.0,5.0,5.0);
        public Window1(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                tbName.Text = student.name;
                tbSurname.Text = student.surname;
                tbIndex.Text = student.index.ToString();
                tbDepartment.Text = student.department;
            }
            this.student = student ?? new Student();
        }

        public Window1()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (student != null)
            {
                student.name = tbName.Text;
                student.surname = tbSurname.Text;
                student.index = int.Parse(tbIndex.Text);
                student.department = tbDepartment.Text;
                Grade gradeI = new Grade(1, 1, 1, 1);
                student.grade.Add(gradeI);
                this.DialogResult = true;
            }
            else
            {
                this.student = student ?? new Student();
                student.name = tbName.Text;
                student.surname = tbSurname.Text;
                student.index = int.Parse(tbIndex.Text);
                student.department = tbDepartment.Text;
                List<Grade> gradeL = new List<Grade>();
                gradeL.Add(gradeI);
                student.grade = gradeL;
                this.DialogResult = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog2 = new Window2();
            if (dialog2.ShowDialog() == true)
            {
               gradeI = dialog2.grade;
            }

        }
    }
}