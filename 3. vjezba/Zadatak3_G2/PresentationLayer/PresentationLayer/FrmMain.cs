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

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        private EmployeeServices services = new EmployeeServices();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GetAllEmployees();
            GetAllCities();
        }

        private void GetAllEmployees()
        {
            List<object> employees = services.GetAllEmployees();
            dgvEmployees.DataSource = employees;
        }

        private void GetFilteredEmployees(string city)
        {
            List<object> filteredEmployees = services.GetFilteredEmployees(city);
            dgvEmployees.DataSource = filteredEmployees;
        }

        private void GetAllCities()
        {
            List<string> cities = services.GetCities();
            cmbCity.DataSource = cities;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem != "")
            {
                string city = cmbCity.SelectedItem.ToString();
                GetFilteredEmployees(city);
            }
            else
            {
                MessageBox.Show("Morate odabrati grad");
                return;
            }
    }
    }
}
