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

namespace vj4_zadatak4
{
    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        public NewCustomer()
        {
            InitializeComponent();
            LoadCities();
            LoadCountries();
        }

        private void LoadCities()
        {
            var cities = (db.Customers.Select(c => c.City)).Distinct();
            CmbCity.ItemsSource = cities.ToList();
        }

        private void LoadCountries()
        {
            var countries = (db.Customers.Select(c => c.Country)).Distinct();
            CmbCountry.ItemsSource = countries.ToList();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            ShowCustomersWindow();
        }

        private void ShowCustomersWindow()
        {
            var window = Window.GetWindow(this) as MainWindow;

            if (window != null)
            {
                window.ControlPanel.Content = new ShowCustomers();
            }
        }
    }
}
