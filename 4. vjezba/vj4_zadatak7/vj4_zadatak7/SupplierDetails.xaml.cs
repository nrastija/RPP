using System;
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

namespace vj4_zadatak7
{
    /// <summary>
    /// Interaction logic for SupplierDetails.xaml
    /// </summary>
    public partial class SupplierDetails : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        private Supplier targetedSupplier;
        public SupplierDetails(Supplier targetedSupplier)
        {
            InitializeComponent();
            this.targetedSupplier = targetedSupplier;
            LoadContent();
        }

        private void LoadContent()
        {
            TxtId.Text = targetedSupplier.SupplierID.ToString();
            TxtCompanyName.Text = targetedSupplier.CompanyName;
            TxtCountry.Text = targetedSupplier.Country;
            TxtCity.Text = targetedSupplier.City;
        }
    }
}
