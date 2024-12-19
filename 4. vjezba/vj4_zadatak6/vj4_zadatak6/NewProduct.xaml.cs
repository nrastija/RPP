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
        public NewProduct()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this) as MainWindow;

            if (window != null)
            {
                window.ControlPanel.Content = new ShowProducts();
            }
        }
    }
}
