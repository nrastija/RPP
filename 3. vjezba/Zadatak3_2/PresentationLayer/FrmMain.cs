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
            LoadCities();
        }

        private void LoadCountries()
        {
            
        }

        private void LoadCities()
        {

        }
    }
}
