using ClassLibrary1;
using DataLayer;
using MessengerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingSystem
{
    public partial class FrmMessanger : Form
    {
        private UserRepository repozitorij = new UserRepository();
        List<User> filtriraneOsobe;
        public FrmMessanger()
        {
            InitializeComponent();
            dgvUsers.DataSource = repozitorij.Users;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) { return; }

            var oznaceniKorisnik = dgvUsers.SelectedRows[0].DataBoundItem as User;
            var poruka = txtMessage.Text;

            IKanal kanal = null;

            if (rbEmail.Checked) kanal = new Email();
            else if (rbSMS.Checked) kanal = new SMS();

            var messenger = new Messenger(kanal);

            var result = messenger.saljiPoruku(oznaceniKorisnik, poruka);

            MessageBox.Show(result);

        }

        private void FrmMessanger_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if (filtriraneOsobe.Any()) dgvUsers.DataSource = filtriraneOsobe;
            else dgvUsers.DataSource = repozitorij;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string unos = txtSearch.Text;

            filtriraneOsobe = repozitorij.Users.Where(osoba => $"{osoba.FirstName} {osoba.LastName}" == unos).ToList();
        }
    }
}
