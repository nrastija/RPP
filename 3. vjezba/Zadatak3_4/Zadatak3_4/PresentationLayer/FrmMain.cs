using BusinessLogicLayer;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        protected CustomerServices services = new CustomerServices();
        public FrmMain()
        {
            InitializeComponent();
            dgvCustomers.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void GetCustomers()
        {
            List<Customer> customers = services.GetCustomers();
            dgvCustomers.DataSource = customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                CustomerID = txtID.Text,
                CompanyName = txtCompany.Text,
                Country = txtCountry.Text,
                City = txtCity.Text
            };

            if (CustomerExists(customer.CustomerID))
            {
                MessageBox.Show("Kupac s ovim ID-jem već postoji u bazi.");
            }
            else if (customer.CustomerID != "" && customer.CompanyName != "" && customer.Country != "" &&
               customer.City != "")
            {
                if (customer.CustomerID.Length > 5)
                {
                    MessageBox.Show("ID ima više od 5 znamenaka");
                    return;
                }

                services.AddCusomter(customer);
                GetCustomers();
            }
            else
            {
                MessageBox.Show("Potrebno je ispuniti sva polja.");
            }
        }

        private bool CustomerExists(string ID)
        {
            return services.CheckIfCustomerExists(ID);
        }

        private Customer GetSelectedCustomer()
        {
            return dgvCustomers.CurrentRow.DataBoundItem as Customer;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = GetSelectedCustomer();

            if (selectedCustomer != null)
            {
                services.RemoveCustomer(selectedCustomer);
            }
            else
            {
                MessageBox.Show("Potrebno je označiti kupca za brisanje!");
            }

            GetCustomers();
        }
    }
}
