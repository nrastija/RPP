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

        private void GetAllCities()
        {
            List<string> cities = services.GetCities();
            cmbCity.DataSource = cities;
        }

    }
}
