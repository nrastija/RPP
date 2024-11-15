namespace Digitalna_Brava
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }
        
        
        private void btnVrata501_Click(object sender, EventArgs e)
        {
            Sigurnosna_Kontrola kontrola = new Sigurnosna_Kontrola();
            var brKartice = int.Parse(txtKartica.Text);
            var pin = int.Parse(txtPIN.Text);

            kontrola.OtvoriVrata(brKartice, pin, 501);
        }

        private void btnVrata502_Click(object sender, EventArgs e)
        {
            Sigurnosna_Kontrola kontrola = new Sigurnosna_Kontrola();
            var brKartice = int.Parse(txtKartica.Text);
            var pin = int.Parse(txtPIN.Text);

            kontrola.OtvoriVrata(brKartice, pin, 502);
        }

        private void btnVrata503_Click(object sender, EventArgs e)
        {
            Sigurnosna_Kontrola kontrola = new Sigurnosna_Kontrola();
            var brKartice = int.Parse(txtKartica.Text);
            var pin = int.Parse(txtPIN.Text);

            kontrola.OtvoriVrata(brKartice, pin, 503);

        }
    }
}
