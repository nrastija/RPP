namespace Digitalna_Brava
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnVrata501_Click(object sender, EventArgs e)
        {
            string brKartice = txtBrKartice.Text;
            string pin = txtPin.Text;
            
            if (brKartice == "" || pin == "")
            {
                MessageBox.Show("Unesite broj kartice i pin");
                return;
            }

            Repozitorij repozitorij = new Repozitorij();
            Sigurnosna_Kontrola sigurnosnaKontrola = new Sigurnosna_Kontrola();

            if (repozitorij.DohvatiKorisnika(int.Parse(brKartice), int.Parse(pin)) != null)
            {
                if (sigurnosnaKontrola.OtvoriVrata(int.Parse(brKartice), int.Parse(pin), 501))
                {
                    MessageBox.Show("Vrata su otvorena");
                }
                else
                {
                    MessageBox.Show("Nemate pravo pristupa");
                }
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji");
            }
        }

        private void btnVrata502_Click(object sender, EventArgs e)
        {
            string brKartice = txtBrKartice.Text;
            string pin = txtPin.Text;

            if (brKartice == "" || pin == "")
            {
                MessageBox.Show("Unesite broj kartice i pin");
                return;
            }

            Repozitorij repozitorij = new Repozitorij();
            Sigurnosna_Kontrola sigurnosnaKontrola = new Sigurnosna_Kontrola();

            if (repozitorij.DohvatiKorisnika(int.Parse(brKartice), int.Parse(pin)) != null)
            {
                if (sigurnosnaKontrola.OtvoriVrata(int.Parse(brKartice), int.Parse(pin), 502))
                {
                    MessageBox.Show("Vrata su otvorena");
                }
                else
                {
                    MessageBox.Show("Nemate pravo pristupa");
                }
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji");
            }
        }

        private void btnVrata503_Click(object sender, EventArgs e)
        {
            string brKartice = txtBrKartice.Text;
            string pin = txtPin.Text;

            if (brKartice == "" || pin == "")
            {
                MessageBox.Show("Unesite broj kartice i pin");
                return;
            }

            Repozitorij repozitorij = new Repozitorij();
            Sigurnosna_Kontrola sigurnosnaKontrola = new Sigurnosna_Kontrola();

            if (repozitorij.DohvatiKorisnika(int.Parse(brKartice), int.Parse(pin)) != null)
            {
                if (sigurnosnaKontrola.OtvoriVrata(int.Parse(brKartice), int.Parse(pin), 503))
                {
                    MessageBox.Show("Vrata su otvorena");
                }
                else
                {
                    MessageBox.Show("Nemate pravo pristupa");
                }
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji");
            }
        }
    }
}
