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

namespace Zadatak3_1
{
    public partial class FrmMain : Form
    {
        private CustomerServices services = new CustomerServices();
        public FrmMain()
        {
            InitializeComponent();
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            GetCountriesForCmb();
            ShowAllCustomers();
        }

        private void ShowAllCustomers()
        {
            var allCustomers = services.GetCustomers();
            dataGridView1.DataSource = allCustomers;
        }

        private void GetCountriesForCmb()
        {
            var allCountries = services.GetCountries();
            cmbCountry.DataSource = allCountries;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var filter = cmbCountry.Text;
            var allFilteredCustomers = services.GetCustomersByCountry(filter);
            dataGridView1.DataSource = allFilteredCustomers;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ShowAllCustomers();
        }
    }
}
