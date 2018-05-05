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
        public AddOrEdit()
        {
            InitializeComponent();
        }

        private void FormAddOrEditLoaded(object sender, RoutedEventArgs e)
        {

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





            if (Controll.AddOrEdit == "addStudent")
            {

                DB.Save();
            }
            else if (Controll.AddOrEdit == "editStudent")
            {

                DB.Save();
            }

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
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





            if (Controll.AddOrEdit == "addStudent")
            {
                btn.Content = "Add Student";

            }
            else if (Controll.AddOrEdit == "editStudent")
            {
                btn.Content = "Edit Student";
            }
        }
    }
}
