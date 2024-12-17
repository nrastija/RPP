using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace vj4_zadatak3
{
    /// <summary>
    /// Interaction logic for NewEmployee.xaml
    /// </summary>
    public partial class NewEmployee : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        public NewEmployee()
        {
            InitializeComponent();
            LoadAllReports();
        }

        private void LoadAllReports()
        {
            var reportsTo = (db.Employees.Select(e => e.ReportsTo)).Distinct();
            cmbReportsTo.ItemsSource = reportsTo.ToList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this) as MainWindow;

            if (window != null)
            {
                {
                    window.controlPanel.Content = new ShowEmployees();
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var newEmployee = new Employee
            {
                EmployeeID = int.Parse(txtID.Text),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Title = txtTitle.Text,
                City = txtCity.Text,
                ReportsTo = cmbReportsTo.SelectedItem as int?
            };

            if (newEmployee.EmployeeID == null || newEmployee.LastName == null || newEmployee.FirstName == null ||
                newEmployee.Title == null || newEmployee.City == null || newEmployee.ReportsTo == null)
            {
                MessageBox.Show("Potrebno je unesti sve vrijednosti");
                return;
            }

            db.Employees.Add(newEmployee);
            db.SaveChanges();

            var window = Window.GetWindow(this) as MainWindow;
            if (window != null)
            {
                window.controlPanel.Content = new ShowEmployees();
            }
        }
    }
}

