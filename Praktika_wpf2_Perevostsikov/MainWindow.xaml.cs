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
        ObservableCollection<Camp> CampItems = new ObservableCollection<Camp>();

        public MainWindow()
        {
            InitializeComponent();

            DataInitializer data = new DataInitializer();
            Context c = new Context();
            data.InitializeDatabase(c);

            loadCamplData();


        }


        public void loadCamplData()
        {
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
    }
}
