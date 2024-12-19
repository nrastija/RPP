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

namespace vj4_zadatak6
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
            var newProduct = new Product
            {
                ProductName = TxtProductName.Text,
                Category = CmbCategory.SelectedItem as Category,
                Supplier = CmbSupplier.SelectedItem as Supplier
            };

            if (newProduct.ProductName == null || newProduct.Category == null ||
                newProduct.Supplier == null)
            {
                MessageBox.Show("Potrebno je unesti sva polja.");
                return;
            }

            db.Products.Add(newProduct);
            db.SaveChanges();

            var window = Window.GetWindow(this) as MainWindow;

            if (window != null)
            {
                window.ControlPanel.Content = new ShowProducts();
            }
        }
    }
}
