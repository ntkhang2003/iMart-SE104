using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace iMart
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void txbUsername_Enter(object sender, EventArgs e)
        {
            if (txbUsername.Text == "username")
            {
                txbUsername.Text = "";
                txbUsername.ForeColor = Color.Silver;
            }
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
            {
                txbUsername.Text = "username";
                txbUsername.ForeColor = Color.Black;
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "password")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.Silver;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "password";
                txbPassword.ForeColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fMainMenu f = new fMainMenu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
