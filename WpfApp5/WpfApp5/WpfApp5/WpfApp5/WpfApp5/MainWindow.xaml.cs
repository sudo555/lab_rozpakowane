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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Grade
    {
        public double polish { get; set; }
        public double english { get; set; }
        public double math { get; set; }
        public double physic { get; set; }

        public Grade(double polish, double english, double math, double physic)
        {

            this.polish = polish;
            this.english = english;
            this.math = math;
            this.physic = physic;
        }


        public Grade((double,double,double,double)tuple)
            : this(tuple.Item1,tuple.Item2,tuple.Item3,tuple.Item4)
        { }
    }
    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int index { get; set; }
        public string department { get; set; }

        //public Grade grade { get; set; }
        public List<Grade> grade { get; set; } = new List<Grade>();

        //public Student(string name, string surname, int index, string department, List<Grade> grade)
        public Student(string name, string surname, int index, string department, List<Grade> grade)
        {
            this.name = name;
            this.surname = surname;
            this.index = index;
            this.department = department;
            this.grade = grade;

        }

        public Student()
            : this("", "", 0, "",null)
        { }

    }




    public partial class MainWindow : Window
    {
        public List<Student> students { get; set; }

        public MainWindow()
        {
            students = new List<Student>();

            List<Grade> gradeL = new List<Grade>();
            Grade gradeI = new Grade(1, 1, 1, 1);
            gradeL.Add(gradeI);

            students.Add(new Student() { name = "Jan", surname = "Kowalski", index = 1234, department = "KIS", grade = gradeL });
            students.Add(new Student() { name = "Anna", surname = "Nowak", index = 1432, department = "KIS", grade = gradeL });
            students.Add(new Student() { name = "Michal", surname = "Jacek", index = 34562, department = "KIS", grade = gradeL });
            InitializeComponent();

            mainDG.ItemsSource = students;
        }

        private void btn_add_student_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Window1();
            if (dialog.ShowDialog() == true)
            {
                students.Add(dialog.student);
            }
            mainDG.Items.Refresh();

        }

        private void btn_remove_student_Click(object sender, RoutedEventArgs e)
        {
            if (mainDG.SelectedItem is Student)
            {
                students.Remove((Student)mainDG.SelectedItem);

            }
            mainDG.Items.Refresh();

        }

    }
}
