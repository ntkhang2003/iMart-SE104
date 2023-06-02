using iMart.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iMart.DTO;

namespace iMart.Forms
{
    public partial class fEmployee : Form
    {
        BindingSource accountList = new BindingSource();

        public Account loginAccount;

        public fEmployee()
        {
            InitializeComponent();
            dtgvAccount.DataSource = accountList;

            LoadAccount();
            AddAccountBinding();

        }

        //Method

        void AddAccountBinding()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName",true, DataSourceUpdateMode.Never));
            numericUpDown2.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "AccountType", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Add account successfully");
            }
            else
            {
                MessageBox.Show("Add account unsuccessfully");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Update account successfully");
            }
            else
            {
                MessageBox.Show("Update account unsuccessfully");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Can't delete yourself");
                return;
            }

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Delete account successfully");
            }
            else
            {
                MessageBox.Show("Delete account unsuccessfully");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Reset password successfully");
            }
            else
            {
                MessageBox.Show("Reset password unsuccessfully");
            }
        }

        //Events

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)numericUpDown2.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;

            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)numericUpDown2.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;

            ResetPass(userName);
        }
    }
}
