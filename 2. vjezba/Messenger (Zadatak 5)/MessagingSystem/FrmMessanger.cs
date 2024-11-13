using DataLayer;
using MessengerLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var oznacenaOsoba = dgvUsers.SelectedRows[0].DataBoundItem as User;
                var message = txtMessage.Text;

                var kanali = new List<IKanal>();

                if (chkEmail.Checked) kanali.Add(new Email());
                if (chkSMS.Checked) kanali.Add(new SMS());
                if (chkViber.Checked) kanali.Add(new Viber());

                var messenger = new Messenger(kanali);
                var result = messenger.saljiPoruke(oznacenaOsoba, message);

                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Molimo odaberite korisnika iz liste.");
            }
                
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
