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
using DataAccessLayer;

namespace Zadatak3_2
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
            LoadCountries();
        }

        private void LoadCountries()
        {
            List<string> countryList = services.GetCountries();
            cmbCountry.DataSource = countryList;
        }

        private void LoadCities(string filter)
        {
            List<string> cityList = services.GetCities(filter);
            cmbCity.DataSource = cityList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filterCountry = cmbCountry.SelectedItem.ToString(); 
            var filterCity = cmbCity.SelectedItem.ToString();
            List<Customer> customers = services.GetCustomerByCountryAndCity(filterCountry, filterCity);

            dataGridView1.DataSource = customers;
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterCountry = cmbCountry.SelectedItem.ToString();
            LoadCities(filterCountry);
        }
    }
}
