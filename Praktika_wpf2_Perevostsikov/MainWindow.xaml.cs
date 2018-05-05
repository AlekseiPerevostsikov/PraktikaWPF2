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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Praktika_wpf2_Perevostsikov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Camp controlStatuss;
        int campId;
        ObservableCollection<Camp> CampItems = new ObservableCollection<Camp>();

        public MainWindow()
        {
            InitializeComponent();

            DataInitializer data = new DataInitializer();
            //Context c = new Context();
            data.InitializeDatabase(new Context());

            //loadCamplData();
        }

        private void MainFormActivated(object sender, EventArgs e)
        {
           
            loadCamplData();
        }



        public void loadCamplData()
        {
            CampItems.Clear();
            //ObservableCollection<Camp> CampItems = new ObservableCollection<Camp>();
            foreach (Camp i in DB.GetAllCamp())
            {
                //this.hotelList.Items.Add(i);
                CampItems.Add(i);
            }
            CampList.ItemsSource = CampItems;
        }

        public void loadCamplDataWhenSearching()
        {
            CampItems.Clear();
            foreach (Camp i in DB.GetAllCampByCampName(txtCampName.Text))
            {
                //this.hotelList.Items.Add(i);
                CampItems.Add(i);
            }
            CampList.ItemsSource = CampItems;
        }

        private void txtCampName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCampName.Text.Length > 0)
            {
                //if (CampList.Items.Count>=0)
                //{
                CampItems.Clear();
                loadCamplDataWhenSearching();
                //}
                //else
                //{
                //    MessageBox.Show("Camp \"" + txtCampName.Text + "\" not found!", "Error");
                //    txtCampName.Text = "";
                //}

            }
            else
            {
                CampItems.Clear();
                loadCamplData();
            }
        }

        private void ListViewSeletctionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CampList.SelectedIndex >= 0)
            {
                controlStatuss = (Camp)CampList.SelectedItems[0];
                campId = controlStatuss.ID;
            }
        }



        private void btnAddCamp_Click(object sender, RoutedEventArgs e)
        {
            Controll.AddOrEdit = "addCamp";
            Controll.CampId = campId;
            AddOrEdit addCamp = new AddOrEdit();
            addCamp.Title = "Add Camp";
            addCamp.Show();
        }



        private void btnEditCamp_Click(object sender, RoutedEventArgs e)
        {
            if (CampList.SelectedIndex >= 0)
            {
                Controll.CampId = campId;
                Controll.AddOrEdit = "editCamp";
                AddOrEdit editCamp = new AddOrEdit();
                editCamp.Title = "Edit Camp";
                editCamp.Show();
            }
            else
            {
                MessageBox.Show("Camp not choosed!", "Error");
            }
        }

        private void btnDeleteCamp_Click(object sender, RoutedEventArgs e)
        {
            if (CampList.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Delete Camp \"" + DB.GetCampByCampId(campId).CampName + "\"?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //lbl2.Content = "1";
                }
                else
                {
                    Camp deleteCamp = DB.GetCampByCampId(campId);

                    int arv = DB.deleteCamp(deleteCamp);

                    if (arv != 0)
                    {
                        DB.Save();
                        MessageBox.Show("Was deleted!", "Succesful");
                        //MainWindow frm = new MainWindow();
                        CampList.SelectedIndex = 0;
                        
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting!", "Error");
                    }

                }
            }
            else
            {
                MessageBox.Show("Camp not choosed!", "Error");
            }
        }

        private void btnShowStudent_Click(object sender, RoutedEventArgs e)
        {
            if (CampList.SelectedIndex >= 0)
            {
                Controll.CampId = campId;
                ShowGroupAndStudents students = new ShowGroupAndStudents();
                students.Title = "Camp: " + DB.GetCampByCampId(campId).CampName;
                students.Show();
            }
            else
            {
                MessageBox.Show("Camp not choosed!", "Error");
            }
        }
    }

    public static class Controll
    {
        public static int CampId { get; set; }
        public static int StudentId { get; set; }
        public static string AddOrEdit { get; set; }

    }
}
