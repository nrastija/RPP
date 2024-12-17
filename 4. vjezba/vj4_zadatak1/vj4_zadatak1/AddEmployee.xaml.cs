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

namespace vj4_zadatak1
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : UserControl
    {
        private Model1 db = new Model1();
        public AddEmployee()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            txtReportsTo.ItemsSource = (db.Employees.Select(e => e.ReportsTo).ToList()).Distinct();
        }


        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.contentPanel.Content = new ShowEmployees();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var employee = new Employee
            {
                EmployeeID = int.Parse(txtID.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                ReportsTo = txtReportsTo.SelectedValue as int?
            };

            if (employee.ReportsTo == null || employee.EmployeeID == null || employee.FirstName == null ||
                employee.LastName == null || employee.City == null || employee.Country == null)
            {
                MessageBox.Show("Molimo ispunite sva polja");
                return;
            }

            db.Employees.Add(employee);
            db.SaveChanges();

            MessageBox.Show("Zaplosenik uspješno dodan!");

            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.contentPanel.Content = new ShowEmployees();
            }
        }
    }
}
