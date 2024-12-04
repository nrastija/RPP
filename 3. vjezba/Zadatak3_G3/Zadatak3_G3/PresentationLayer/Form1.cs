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

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private SupplierServices services = new SupplierServices();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowAll()
        {
            List<Supplier> allSuppliers = services.GetAllSuppliers();
            dataGridView1.DataSource = allSuppliers;

        }

        private void LoadCountries()
        {
            List<String> countries = services.GetCountries();
            cmbCountry.DataSource = countries;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAll();
            LoadCountries();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                CompanyName = txtCompany.Text,
                Country = cmbCountry.Textini,
                City = txtCity.Text
            };

            if (supplier.CompanyName != "" && supplier.Country != "" && supplier.City != "")
            {
                services.addSupplier(supplier);
            }
            else
            {
                MessageBox.Show("Potrebno je ispuniti sva polja");
            }

            ShowAll();
        }
    }
}
