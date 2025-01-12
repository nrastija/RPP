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

namespace vj4_zadatak4
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
            GetAllCustomers();
        }

        private void GetAllCustomers()
        {
            var customers = db.Customers.ToList();
            DgvCustomers.ItemsSource = customers;
        }

        private void BtnDelete_Click(object sender, object e)
        {
            var customer = DgvCustomers.SelectedItem as Customer;

            if (customer == null)
            {
                MessageBox.Show("Potrebno je izabrati osobu za birsanje");
                return;
            }

            db.Customers.Remove(customer);
            db.SaveChanges();

            GetAllCustomers();
        }
    }
}
