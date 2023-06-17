using iMart.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMart.Forms
{
    public partial class fIncome : Form
    {
        public fIncome()
        {
            InitializeComponent();
        }

        //Methods
        void LoadListBillByDate(DateTime dateBegin, DateTime dateEnd)
        {
            dtgvBillManifest.DataSource = BillDAO.Instance.GetListBillByDate(dateBegin, dateEnd);
            txbNumber.Text = BillDAO.Instance.GetNumberOfBill(dateBegin, dateEnd).ToString();
            txbTotalTotal.Text = "$" + BillDAO.Instance.GetTotalOfTotal(dateBegin, dateEnd).ToString();
        }

        //Events
        private void btnManifest_Click(object sender, EventArgs e)
        {
            if (dtpkToDate.Value <= dtpkFromDate.Value)
            {
                MessageBox.Show("Incorrect date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            }
        }
    }
}
