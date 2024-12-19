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
    /// Interaction logic for NewProduct.xaml
    /// </summary>
    public partial class NewProduct : UserControl
    {
        private NorthwndModel db = new NorthwndModel();
        public NewProduct()
        {
            InitializeComponent();
            LoadCategories();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var suppliers = db.Suppliers.ToList();

            CmbSupplier.ItemsSource = suppliers;
            CmbSupplier.DisplayMemberPath = "CompanyName";
            CmbSupplier.SelectedValuePath = "SupplierID";
        }

        private void LoadCategories()
        {
            var categories = db.Categories.ToList();

            CmbCategory.ItemsSource = categories;
            CmbCategory.DisplayMemberPath = "CategoryName";
            CmbCategory.SelectedValuePath = "CategoryID";
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this) as MainWindow;

            if (window != null)
            {
                window.ControlPanel.Content = new ShowProducts();
            }

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            var product = new Product
            {
                ProductName = TxtProductName.Text,
                Supplier = CmbSupplier.SelectedItem as Supplier,
                Category = CmbCategory.SelectedItem as Category
            };

            if (product.ProductName == null || product.Supplier == null ||
                product.Category == null)
            {
                MessageBox.Show("Potpuno je ispuniti sva polja.");
                return;
            }

            db.Products.Add(product);
            db.SaveChanges();

            var window = Window.GetWindow(this) as MainWindow;

            if (window != null)
            {
                window.ControlPanel.Content = new ShowProducts();
            }
        }
    }
}
