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
    /// Interaction logic for ShowSuppliers.xaml
    /// </summary>
    public partial class ShowSuppliers : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        public ShowSuppliers()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var suppliers = db.Suppliers.ToList();
            DgvSuppliers.ItemsSource = suppliers;
        }
    }
}
