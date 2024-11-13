using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingSystem
{
    public partial class FrmMessanger : Form
    {
        UserRepository repozitorij = new UserRepository();
        public FrmMessanger()
        {
            InitializeComponent();
            dgvUsers.DataSource = repozitorij.Users;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

        }

        private void FrmMessanger_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string vrijednost = txtSearch.Text;

            List<User> filtriraniKorisnici = repozitorij.Users.Where(osoba => osoba.Phone.StartsWith(vrijednost)).ToList();

            dgvUsers.DataSource = filtriraniKorisnici;
        }
    }
}
