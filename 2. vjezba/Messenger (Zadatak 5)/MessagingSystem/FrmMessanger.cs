using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MessengerLib;

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
            var oznacenaOsoba = dgvUsers.SelectedRows[0];
            var message = txtMessage.Text;

            
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
