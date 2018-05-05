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
    /// Логика взаимодействия для ShowStudents.xaml
    /// </summary>
    public partial class ShowGroupAndStudents : Window
    {
        Group controllStatussGroup;
        Student controlStatuss;
        int campId;
        int studentId;
        int groupId;
        ObservableCollection<Student> StudentItems = new ObservableCollection<Student>();
        ObservableCollection<Group> GroupItems = new ObservableCollection<Group>();


        public ShowGroupAndStudents()
        {
            InitializeComponent();

            campId = Controll.CampId;
        }

        private void FormActivated(object sender, EventArgs e)
        {
            loadGroupData();
            loadStudentlData();
            StudentList.SelectedIndex = 0;
            GroupList.SelectedIndex = 0;
        }



        //load data


        public void loadGroupData()
        {
            GroupItems.Clear();
            // ObservableCollection<Student> studentItems = new ObservableCollection<Student>();
            foreach (Group i in DB.GetAllGroupsByCampId(campId))
            {
                //this.hotelList.Items.Add(i);
                GroupItems.Add(i);
            }
            GroupList.ItemsSource = GroupItems;
        }



        public void loadStudentlData()
        {
            StudentItems.Clear();
            // ObservableCollection<Student> studentItems = new ObservableCollection<Student>();
            foreach (Student i in DB.GetAllStudentsByGroupId(groupId))
            {
                //this.hotelList.Items.Add(i);
                StudentItems.Add(i);
            }
            StudentList.ItemsSource = StudentItems;
        }




        // searching data


        public void loadGroupDataWhenSearching()
        {
            GroupItems.Clear();
            foreach (Group i in DB.GetAllGroupsByGroupName(txtGroupName.Text, campId))
            {
                GroupItems.Add(i);
            }
            GroupList.ItemsSource = GroupItems;
        }


        public void loadStudentDataWhenSearching()
        {
            StudentItems.Clear();
            foreach (Student i in DB.GetAllStudentByStudentLastName(txtStudentLastName.Text, groupId))
            {
                StudentItems.Add(i);
            }
            StudentList.ItemsSource = StudentItems;
        }





        //when listview selection changed


        private void GroupListViewSeletctionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GroupList.SelectedIndex >= 0)
            {
                controllStatussGroup = (Group)GroupList.SelectedItems[0];
                groupId = controllStatussGroup.ID;
                loadStudentlData();
                StudentList.SelectedIndex = 0;
            }
        }



        private void ListViewSeletctionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentList.SelectedIndex >= 0)
            {
                controlStatuss = (Student)StudentList.SelectedItems[0];
                studentId = controlStatuss.ID;

            }
        }





        // when input in txtBox


        private void GroupTextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtGroupName.Text.Length > 0)
            {
                GroupList.SelectedIndex = 0;
                GroupItems.Clear();
                loadGroupDataWhenSearching();
                StudentItems.Clear();
                loadStudentlData();

                if (GroupList.Items.Count == 0)
                {
                    StudentList.ItemsSource = null;
                }
            }
            else
            {
                GroupItems.Clear();
                loadGroupData();
                loadStudentlData();
            }
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








        //buttons Group



        private void btnAddGroup_Click(object sender, RoutedEventArgs e)
        {
            if (GroupList.SelectedIndex >= 0)
            {
                Controll.GroupId = groupId;
                Controll.CampId = campId;

                Controll.AddOrEdit = "addGroup";
                AddOrEdit editStud = new AddOrEdit();
                editStud.Title = "Add Group";
                editStud.Show();
            }
            else
            {
                MessageBox.Show("Group not choosed!", "Error");
            }
        }

        private void btnEditGroup_Click(object sender, RoutedEventArgs e)
        {
            if (GroupList.SelectedIndex >= 0)
            {
                Controll.GroupId = groupId;
                Controll.CampId = campId;

                Controll.AddOrEdit = "editGroup";
                AddOrEdit editStud = new AddOrEdit();
                editStud.Title = "Edit Group";
                editStud.Show();
            }
            else
            {
                MessageBox.Show("Group not choosed!", "Error");
            }
        }

        private void btnDeleteGroup_Click(object sender, RoutedEventArgs e)
        {
            if (GroupList.SelectedIndex >= 0)
            {
                Controll.GroupId = groupId;

                if (MessageBox.Show("Delete Group \"" + DB.GetGroupByGroupId(groupId).GroupName + "\"?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                }
                else
                {
                    Group deleteGroup = DB.GetGroupByGroupId(groupId);

                    int arv = DB.deleteGroup(deleteGroup);

                    if (arv != 0)
                    {
                        DB.Save();
                        MessageBox.Show("Was deleted!", "Succesful");
                        GroupList.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Error while deleting!", "Error");
                    }

                }
            }
            else
            {
                MessageBox.Show("Group not choosed!", "Error");
            }
        }







        //buttons Students


        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (GroupList.SelectedIndex >= 0)
            {
                Controll.AddOrEdit = "addStudent";
                Controll.GroupId = groupId;
                AddOrEdit addStu = new AddOrEdit();
                addStu.Title = "Add Student";
                addStu.Show();
            }
            else
            {
                MessageBox.Show("Camp not choosed!", "Error");
            }
        }

        private void btnEditStudent_Click(object sender, RoutedEventArgs e)
        {
            if (StudentList.SelectedIndex >= 0)
            {
                Controll.AddOrEdit = "editStudent";
                Controll.GroupId = groupId;
                Controll.StudentId = studentId;
                AddOrEdit editStud = new AddOrEdit();
                editStud.Title = "Edit Student";
                editStud.Show();
            }
            else
            {
                MessageBox.Show("Student not choosed!", "Error");
            }

        }

        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (StudentList.SelectedIndex >= 0)
            {
                Controll.GroupId = groupId;
                Controll.StudentId = studentId;


                if (MessageBox.Show("Delete Student \"" + DB.GetStudentByStudentId(studentId).LastName + " " + DB.GetStudentByStudentId(studentId).FirstName + "\"?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                }
                else
                {
                    Student deleteStudent = DB.GetStudentByStudentId(studentId);

                    int arv = DB.deleteStudent(deleteStudent);

                    if (arv != 0)
                    {
                        DB.Save();
                        MessageBox.Show("Was deleted!", "Succesful");
                        StudentList.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Error while deleting!", "Error");
                    }

                }
            }
            else
            {
                MessageBox.Show("Student not choosed!", "Error");
            }
        }
    }
}
