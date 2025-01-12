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

namespace vj4_zadatak3
{
    /// <summary>
    /// Interaction logic for ShowEmployees.xaml
    /// </summary>
    public partial class ShowEmployees : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        public ShowEmployees()
        {
            InitializeComponent();
            GetAllEmployees();
        }

        private void GetAllEmployees()
        {
            dgvEmployees.ItemsSource = db.Employees.ToList(); 
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var employee = dgvEmployees.SelectedItem as Employee;

            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }

            GetAllEmployees();
        }
    }
}
