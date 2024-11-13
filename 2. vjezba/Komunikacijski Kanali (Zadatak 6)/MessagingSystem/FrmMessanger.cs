using DataLayer;
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

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
