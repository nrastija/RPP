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

namespace vj4_zadatak5
{
    /// <summary>
    /// Interaction logic for ShowProducts.xaml
    /// </summary>
    public partial class ShowProducts : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        public ShowProducts()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = db.Products.Select(p => new
            {
                p.ProductID,
                p.ProductName,
                Category = p.Category.CategoryName,
                Supplier = p.Supplier.CompanyName,
            });

            DgvProducts.ItemsSource = products.ToList();
        }
    }
}
