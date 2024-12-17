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

namespace vj4_zadatak2
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

        private void LoadCountries()
        {
            var filteredCountries = (db.Customers.Select(c => c.Country)).Distinct();
            cmbCountry.ItemsSource = filteredCountries.ToList();
        }

        private void LoadCities()
        {
            var filteredCities = (db.Customers.Select(c => c.City)).Distinct();
            cmbCity.ItemsSource = filteredCities.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var newCustomer = new Customer
            {
                CustomerID = txtID.Text,
                CompanyName = txtCompany.Text,
                City = cmbCity.SelectedItem.ToString(),
                Country = cmbCountry.SelectedItem.ToString()
            };

            if (newCustomer.CustomerID == null || newCustomer.CompanyName == null ||
                newCustomer.City == null || newCustomer.Country == null)
            {
                MessageBox.Show("Molimo unesite sva polja");
                return;
            }

            db.Customers.Add(newCustomer);
            db.SaveChanges();

            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.controlPanel.Content = new ShowCustomers();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.controlPanel.Content = new ShowCustomers();
            }
        }
    }
}
