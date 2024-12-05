using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccesLayer;

namespace CustomersApp
{
    public partial class FrmCustomers : Form
    {
        private CustomerServices services = new CustomerServices();
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            GetCountriesForComboBox();
            GetAllCustomers();
        }

        private void GetAllCustomers()
        {
            List<Customer> customers = services.GetAllCustomers();
            dgvCustomers.DataSource = customers;
        }

        private void GetCountriesForComboBox()
        {
            List<string> countries = services.GetCountries();
            cmbCountry.DataSource = countries;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string filter = cmbCountry.Text;
            if (filter == "")
            {
                MessageBox.Show("Potrebno je izabrati državu");
                return;
            }
            else
            {
                List<Customer> filtered = services.GetCustomersFromCountry(filter);
                dgvCustomers.DataSource = filtered;
            }
        }
    }
}
