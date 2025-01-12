﻿using System;
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
    /// Interaction logic for ShowEmployees.xaml
    /// </summary>
    public partial class ShowEmployees : UserControl
    {
        private Model1 db = new Model1();
        public ShowEmployees()
        {
            InitializeComponent();
            LoadEmployees();

        }

        private void LoadEmployees()
        {
            var allEmployees = db.Employees.Select(e => new
            {
                e.EmployeeID,
                e.LastName,
                e.FirstName,
                e.City,
                e.Country,
                e.ReportsTo
            });
            dgEmployees.ItemsSource = allEmployees.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.contentPanel.Content = new AddEmployee();
            }
        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {
            var selected = dgEmployees.SelectedItem as Employee;
            if (selected != null)
            {
                db.Employees.Remove(selected);
                db.SaveChanges();
                LoadEmployees();
            }
        }
    }
}
