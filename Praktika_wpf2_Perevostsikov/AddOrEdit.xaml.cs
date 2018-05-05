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
using System.Windows.Shapes;

namespace Praktika_wpf2_Perevostsikov
{
    /// <summary>
    /// Логика взаимодействия для AddOrEdit.xaml
    /// </summary>
    public partial class AddOrEdit : Window
    {
       
        int campId;
        int groupId;
        int studentId;

        public AddOrEdit()
        {
            InitializeComponent();




        }

        private void FormAddOrEditLoaded(object sender, RoutedEventArgs e)
        {
            campId = Controll.CampId;
            groupId = Controll.GroupId;

            Dictionary<int, string> cbGroupData = new Dictionary<int, string>();
            var groups = DB.GetAllGroups();
            foreach (var item in groups)
            {
                cbGroupData.Add(item.ID, item.GroupName+" ("+item.Camp.CampName+")");
            }



            cbExistingGroups.ItemsSource = cbGroupData;
            cbExistingGroups.DisplayMemberPath = "Value";
            cbExistingGroups.SelectedValuePath = "Key";

            //cbExistingStudents.SelectedIndex = 0;



            Dictionary<int, string> cbStudentData = new Dictionary<int, string>();
            var allStudents = DB.GetAllStudents();
            foreach (var item in allStudents)
            {
                cbStudentData.Add(item.ID, item.FirstName + " " + item.LastName + " (" + item.Phone + ")");
            }
            cbExistingStudents.ItemsSource = cbStudentData;
            cbExistingStudents.DisplayMemberPath = "Value";
            cbExistingStudents.SelectedValuePath = "Key";

            cbExistingStudents.SelectedIndex = 0;

            
            cbExistingGroups.Visibility = Visibility.Hidden;
            cbExistingStudents.Visibility = Visibility.Hidden;




            // Camp

            if (Controll.AddOrEdit == "editCamp")
            {
                Camp tempCamp = DB.GetCampByCampId(Controll.CampId);
                txt1.Text = tempCamp.CampName;
                txt2.Text = tempCamp.Description;

                btn.Content = "Update Camp";

                lbl1.Visibility = Visibility.Visible;
                lbl2.Visibility = Visibility.Visible;

                lbl3.Visibility = Visibility.Hidden;
                lbl4.Visibility = Visibility.Hidden;
                lbl5.Visibility = Visibility.Hidden;
                lbl6.Visibility = Visibility.Hidden;
                lbl7.Visibility = Visibility.Hidden;
                lbl8.Visibility = Visibility.Hidden;

                lbl1.Content = "Camp Name";
                lbl2.Content = "Camp Description";

                txt1.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;

                txt3.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt7.Visibility = Visibility.Hidden;
            }
            else if (Controll.AddOrEdit == "addCamp")
            {
                btn.Content = "Add Camp";

                lbl1.Visibility = Visibility.Visible;
                lbl2.Visibility = Visibility.Visible;

                lbl3.Visibility = Visibility.Hidden;
                lbl4.Visibility = Visibility.Hidden;
                lbl5.Visibility = Visibility.Hidden;
                lbl6.Visibility = Visibility.Hidden;
                lbl7.Visibility = Visibility.Hidden;
                lbl8.Visibility = Visibility.Hidden;

                lbl1.Content = "Camp Name";
                lbl2.Content = "Camp Description";

                txt1.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;

                txt3.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt7.Visibility = Visibility.Hidden;
            }





            //Group

            if (Controll.AddOrEdit == "editGroup")
            {
                Group tempGroup = DB.GetGroupByGroupId(Controll.GroupId);
                txt1.Text = tempGroup.GroupName;
                txt2.Text = tempGroup.Description;

                btn.Content = "Update Group";

                lbl1.Visibility = Visibility.Visible;
                lbl2.Visibility = Visibility.Visible;

                lbl3.Visibility = Visibility.Hidden;
                lbl4.Visibility = Visibility.Hidden;
                lbl5.Visibility = Visibility.Hidden;
                lbl6.Visibility = Visibility.Hidden;
                lbl7.Visibility = Visibility.Hidden;
                lbl8.Visibility = Visibility.Hidden;

                lbl1.Content = "Group Name";
                lbl2.Content = "Group Description";

                txt1.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;

                txt3.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt7.Visibility = Visibility.Hidden;
            }
            else if (Controll.AddOrEdit == "addGroup")
            {
                btn.Content = "Add Group";

                lbl1.Visibility = Visibility.Visible;
                lbl2.Visibility = Visibility.Visible;

                lbl3.Visibility = Visibility.Hidden;
                lbl4.Visibility = Visibility.Hidden;
                lbl5.Visibility = Visibility.Hidden;
                lbl6.Visibility = Visibility.Hidden;
                lbl7.Visibility = Visibility.Hidden;
                lbl8.Visibility = Visibility.Hidden;

                lbl1.Content = "Group Name";
                lbl2.Content = "Group Description";

                txt1.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;

                txt3.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt7.Visibility = Visibility.Hidden;
            }




            // Student


            if (Controll.AddOrEdit == "addStudent")
            {
                btn.Content = "Add Student";


                cbExistingStudents.Visibility = Visibility.Hidden;

                lbl1.Visibility = Visibility.Visible;
                lbl2.Visibility = Visibility.Visible;
                lbl3.Visibility = Visibility.Visible;
                lbl4.Visibility = Visibility.Visible;
                lbl5.Visibility = Visibility.Visible;
                lbl6.Visibility = Visibility.Visible;
                lbl7.Visibility = Visibility.Visible;
                lbl8.Visibility = Visibility.Visible;

                lbl1.Content = "First Name";
                lbl2.Content = "Last Name";
                lbl3.Content = "Isikukood";
                lbl4.Content = "School Name";
                lbl5.Content = "Class Number";
                lbl6.Content = "Phone";
                lbl7.Content = "Adress";
                lbl8.Content = "Group";

                txt1.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;
                txt3.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;
                txt7.Visibility = Visibility.Visible;
                cbExistingGroups.Visibility = Visibility.Visible;

                cbExistingGroups.SelectedItem = new KeyValuePair<int, string>(groupId, DB.GetGroupByGroupId(groupId).GroupName + " (" + DB.GetGroupByGroupId(groupId).Camp.CampName + ")");


            }
            else if (Controll.AddOrEdit == "editStudent")
            {
                studentId = Controll.StudentId;

                var ts = DB.GetStudentByStudentId(studentId);
                txt1.Text = ts.FirstName;
                txt2.Text = ts.LastName;
                txt3.Text = ts.Isikukood;
                txt4.Text = ts.SchoolName;
                txt5.Text = ts.ClassNumber;
                txt6.Text = ts.Phone;
                txt7.Text = ts.Adress;

                cbExistingGroups.SelectedItem = new KeyValuePair<int, string>(groupId, DB.GetGroupByGroupId(groupId).GroupName + " (" + DB.GetGroupByGroupId(groupId).Camp.CampName + ")");



                btn.Content = "Update Student";

                lbl1.Visibility = Visibility.Visible;
                lbl2.Visibility = Visibility.Visible;
                lbl3.Visibility = Visibility.Visible;
                lbl4.Visibility = Visibility.Visible;
                lbl5.Visibility = Visibility.Visible;
                lbl6.Visibility = Visibility.Visible;
                lbl7.Visibility = Visibility.Visible;
                lbl8.Visibility = Visibility.Visible;

                lbl1.Content = "First Name";
                lbl2.Content = "Last Name";
                lbl3.Content = "Isikukood";
                lbl4.Content = "School Name";
                lbl5.Content = "Class Number";
                lbl6.Content = "Phone";
                lbl7.Content = "Adress";
                lbl8.Content = "Group";

                txt1.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;
                txt3.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;
                txt7.Visibility = Visibility.Visible;
                cbExistingGroups.Visibility = Visibility.Visible;
                //cbExistingGroups.SelectedItem = DB.GetGroupByGroupId(groupId).GroupName;


            }

        }











        //button pressed


        private void btn_Click(object sender, RoutedEventArgs e)
        {

            // Camp

            if (Controll.AddOrEdit == "editCamp")
            {
                Camp updateCamp = new Camp();
                updateCamp.ID = Controll.CampId;
                updateCamp.CampName = txt1.Text;
                updateCamp.Description = txt2.Text;

                int arv = DB.updateCamp(updateCamp);

                if (arv == 1)
                {
                    MessageBox.Show("Was updated!", "Succesful");
                    DB.Save();
                }
                else
                {
                    MessageBox.Show("Error while updating!", "Error");
                }
            }
            else if (Controll.AddOrEdit == "addCamp")
            {
                Camp addCamp = new Camp();
                addCamp.ID = Controll.CampId + 1;
                addCamp.CampName = txt1.Text;
                addCamp.Description = txt2.Text;

                int arv = DB.addCamp(addCamp);

                if (arv == 1)
                {
                    MessageBox.Show("Was added!", "Succesful");
                    DB.Save();
                }
                else
                {
                    MessageBox.Show("Error while adding!", "Error");
                }
            }





            // Group

            if (Controll.AddOrEdit == "editGroup")
            {
                Group updateGroup = new Group();
                updateGroup.ID = Controll.GroupId;
                updateGroup.CampId = Controll.CampId;
                updateGroup.GroupName = txt1.Text;
                updateGroup.Description = txt2.Text;

                int arv = DB.updateGroup(updateGroup);

                if (arv == 1)
                {
                    MessageBox.Show("Was updated!", "Succesful");
                    DB.Save();
                }
                else
                {
                    MessageBox.Show("Error while updating!", "Error");
                }
            }
            else if (Controll.AddOrEdit == "addGroup")
            {
                Group addGroup = new Group();
                addGroup.ID = Controll.GroupId+1;
                addGroup.CampId = Controll.CampId;
                addGroup.GroupName = txt1.Text;
                addGroup.Description = txt2.Text;

                int arv = DB.addGroup(addGroup);

                if (arv == 1)
                {
                    MessageBox.Show("Was added!", "Succesful");
                    DB.Save();
                }
                else
                {
                    MessageBox.Show("Error while adding!", "Error");
                }
            }






            // Student


            if (Controll.AddOrEdit == "addStudent")
            {
                // studentId = ((KeyValuePair<int, string>)cbExistingStudents.SelectedItem).Key;

                Student newStudent = new Student();
                newStudent.FirstName = txt1.Text;
                newStudent.LastName = txt2.Text;
                newStudent.Isikukood = txt3.Text;
                newStudent.SchoolName = txt4.Text;
                newStudent.ClassNumber = txt5.Text;
                newStudent.Phone = txt6.Text;
                newStudent.Adress = txt7.Text;
                newStudent.GroupId = ((KeyValuePair<int, string>)cbExistingGroups.SelectedItem).Key;

                int arv = DB.addStudent(newStudent);




                if (arv == 1)
                {
                    MessageBox.Show("Was added!", "Succesful");
                    DB.Save();
                }
                else
                {
                    MessageBox.Show("Error while adding!", "Error");
                }




            }
            else if (Controll.AddOrEdit == "editStudent")
            {
                Student editStudent = new Student();
                editStudent.ID = studentId;
                editStudent.FirstName = txt1.Text;
                editStudent.LastName = txt2.Text;
                editStudent.Isikukood = txt3.Text;
                editStudent.SchoolName = txt4.Text;
                editStudent.ClassNumber = txt5.Text;
                editStudent.Phone = txt6.Text;
                editStudent.Adress = txt7.Text;

                editStudent.GroupId = ((KeyValuePair<int, string>)cbExistingGroups.SelectedItem).Key;


                int arv = DB.updateStudent(editStudent);

                if (arv == 1)
                {
                    MessageBox.Show("Was updated!", "Succesful");
                    DB.Save();
                }
                else
                {
                    MessageBox.Show("Error while updating!", "Error");
                }

            }
        }












        //private void CheckBox_cheked(object sender, RoutedEventArgs e)
        //{
        //    cbExistingStudents.Visibility = Visibility.Visible;
        //    lbl1.Content = checkStudetnAdd.IsChecked;

        //    lbl1.Visibility = Visibility.Visible;
        //    lbl2.Visibility = Visibility.Hidden;
        //    lbl3.Visibility = Visibility.Hidden;
        //    lbl4.Visibility = Visibility.Hidden;
        //    lbl5.Visibility = Visibility.Hidden;
        //    lbl6.Visibility = Visibility.Hidden;
        //    lbl7.Visibility = Visibility.Hidden;
        //    lbl8.Visibility = Visibility.Hidden;

        //    lbl1.Content = "Select Student";


        //    txt1.Visibility = Visibility.Hidden;
        //    txt2.Visibility = Visibility.Hidden;
        //    txt3.Visibility = Visibility.Hidden;
        //    txt4.Visibility = Visibility.Hidden;
        //    txt5.Visibility = Visibility.Hidden;
        //    txt6.Visibility = Visibility.Hidden;
        //    txt7.Visibility = Visibility.Hidden;
        //    cbExistingGroups.Visibility = Visibility.Hidden;
        //    cbExistingStudents.SelectedIndex = 0;

        //    newStudent = DB.GetStudentByStudentId(((KeyValuePair<int, string>)cbExistingStudents.SelectedItem).Key);

        //}

        //private void UnchekedC(object sender, RoutedEventArgs e)
        //{
        //    cbExistingStudents.Visibility = Visibility.Hidden;

        //    lbl1.Visibility = Visibility.Visible;
        //    lbl2.Visibility = Visibility.Visible;
        //    lbl3.Visibility = Visibility.Visible;
        //    lbl4.Visibility = Visibility.Visible;
        //    lbl5.Visibility = Visibility.Visible;
        //    lbl6.Visibility = Visibility.Visible;
        //    lbl7.Visibility = Visibility.Visible;
        //    lbl8.Visibility = Visibility.Visible;

        //    lbl1.Content = "First Name";
        //    lbl2.Content = "Last Name";
        //    lbl3.Content = "Isikukood";
        //    lbl4.Content = "School Name";
        //    lbl5.Content = "Class Number";
        //    lbl6.Content = "Phone";
        //    lbl7.Content = "Adress";
        //    lbl8.Content = "Group";

        //    txt1.Visibility = Visibility.Visible;
        //    txt2.Visibility = Visibility.Visible;
        //    txt3.Visibility = Visibility.Visible;
        //    txt4.Visibility = Visibility.Visible;
        //    txt5.Visibility = Visibility.Visible;
        //    txt6.Visibility = Visibility.Visible;
        //    txt7.Visibility = Visibility.Visible;
        //    cbExistingGroups.Visibility = Visibility.Visible;

            


        //}

       
    }
}
