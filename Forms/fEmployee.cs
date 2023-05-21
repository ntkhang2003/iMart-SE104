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

namespace iMart.Forms
{
    public partial class fEmployee : Form
    {
        BindingSource accountList = new BindingSource();

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
            txtAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "AccountType", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        //Events

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
