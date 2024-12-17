using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        private ProductServices services = new ProductServices();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            List<object> products = services.GetAllProducts();
            dgvProducts.DataSource = products;
        }

        private void LoadFilteredProducts(int min, int max)
        {
            List<object> filteredProducts = services.GetFilteredProducts(min, max);
            dgvProducts.DataSource = filteredProducts;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtPriceFrom.Text == "" || txtPriceTo.Text == "")
            {
                MessageBox.Show("Unesite raspon od i do"); return;
            }
            int min = int.Parse(txtPriceFrom.Text);
            int max = int.Parse(txtPriceTo.Text);
            LoadFilteredProducts(min, max);

        }

        private void bntClear_Click(object sender, EventArgs e)
        { 
            txtPriceFrom.Clear();
            txtPriceTo.Clear();
            LoadProducts();
        }
    }
}
