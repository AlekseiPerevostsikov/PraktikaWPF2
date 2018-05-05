using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Praktika_wpf2_Perevostsikov
{
    /// <summary>
    /// Логика взаимодействия для AllStudents.xaml
    /// </summary>
    public partial class AllStudents : Window
    {

        ObservableCollection<Student> StudentItems = new ObservableCollection<Student>();

        public AllStudents()
        {
            InitializeComponent();
        }


        private void FormActivated(object sender, EventArgs e)
        {
            loadStudentlData();
            StudentList.SelectedIndex = 0;
        }

        public void loadStudentlData()
        {
            StudentItems.Clear();
            foreach (Student i in DB.GetAllStudents().OrderBy(a=>a.LastName).OrderBy(a=>a.FirstName))
            {
                StudentItems.Add(i);
            }
            StudentList.ItemsSource = StudentItems;
        }



        public void loadStudentDataWhenSearching()
        {
            StudentItems.Clear();
            foreach (Student i in DB.GetAllStudentByStudentLastName2(txtStudentLastName.Text))
            {
                StudentItems.Add(i);
            }
            StudentList.ItemsSource = StudentItems;
        }



       



        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtStudentLastName.Text.Length > 0)
            {
                StudentItems.Clear();
                loadStudentDataWhenSearching();
            }
            else
            {
                StudentItems.Clear();
                loadStudentlData();
            }
        }
    }
}
