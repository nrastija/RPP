using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        protected CustomerServices services = new CustomerServices();
        public FrmMain()
        {
            InitializeComponent();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            List<Customer> customers = services.GetCustomers().ToList();
            dgvCustomers.DataSource = customers;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                CustomerID = txtID.Text,
                CompanyName = txtCompany.Text,
                Country = txtCountry.Text,
                City = txtCity.Text
            };

            if (services.CustomerExists(customer.CustomerID))
            {
                MessageBox.Show("Vec postoji kupac s ovim ID-jem");
            }
            else if (customer.CustomerID != "" && customer.CompanyName != "" && customer.Country != "" &&
                customer.City != ""  )
            {
                if (customer.CustomerID.Length > 5)
                {
                    MessageBox.Show("ID mora biti 5 ili manje znamenaka");
                }

                var custServices = new CustomerServices();
                custServices.AddCustomer(customer);
            }
            else
            {
                MessageBox.Show("Trebate popuniti sva polja!");
            }

            LoadCustomers();
        }
    }
}
