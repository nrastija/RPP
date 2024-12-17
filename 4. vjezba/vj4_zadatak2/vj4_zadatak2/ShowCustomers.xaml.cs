using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for ShowCustomers.xaml
    /// </summary>
    public partial class ShowCustomers : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        public ShowCustomers()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.CompanyName,
                c.City,
                c.Country
            });

            dgvCustomers.ItemsSource = customers.ToList();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;

            if(mainWindow != null)
            {
                mainWindow.controlPanel.Content = new NewCustomer();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedCustomer = dgvCustomers.SelectedItem;

            var customerId = selectedCustomer.GetType()
                .GetProperty("CustomerID")
                .GetValue(selectedCustomer);

            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);

            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
            }

            
            LoadCustomers();
        }
    }
}
