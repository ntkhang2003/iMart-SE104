using iMart.DAO;
using iMart.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Menu = iMart.DTO.Menu;

namespace iMart.Forms
{
    public partial class fHome : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fHome(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            this.AcceptButton = btnSearchItem;
            LoadProduct();
        }

        //Method
        void LoadProduct()
        {
            List<Product> productList = ProductDAO.Instance.LoadProductList();

            foreach (Product item in productList)
            {
                Button btn = new Button() { Width = ProductDAO.ProductWidth, Height = ProductDAO.ProductHeight };
                btn.Text = item.Name + Environment.NewLine + "$" + item.Price + Environment.NewLine + item.SupplierName;
                btn.Font = new Font("Comic Sans MS", 10, FontStyle.Regular);
                btn.Click += btn_Click;
                btn.Tag = item;
                flpItem.Controls.Add(btn);
            }
        }
        List<Product> SearchProductByName(string name)
        {
            List<Product> productList = ProductDAO.Instance.SearchProductByName(name);
            foreach (Product item in productList)
            {
                Button btn = new Button() { Width = ProductDAO.ProductWidth, Height = ProductDAO.ProductHeight };
                btn.Text = item.Name + Environment.NewLine + "$" + item.Price + Environment.NewLine + item.SupplierName;
                btn.Font = new Font("Comic Sans MS", 10, FontStyle.Regular);
                btn.Click += btn_Click;
                btn.Tag = item;
                flpItem.Controls.Add(btn);
            }
            return productList;
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillDetail = MenuDAO.Instance.GetListMenu(id);
            double totalPrice = 0;
            foreach (Menu item in listBillDetail)
            {
                ListViewItem lsvItem = new ListViewItem(item.ProductName.ToString());
                lsvItem.SubItems.Add(item.UnitPrice.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Amount.ToString());
                totalPrice += item.Amount;
                lsvBill.Items.Add(lsvItem);
            }
            txbTotal.Text = "$" + totalPrice.ToString();
        }
        //Events
        private void btn_Click(object sender, EventArgs e)
        {
            string productName = ((sender as Button).Tag as Product).Name;
            txbItemName.Text = productName;
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            flpItem.Controls.Clear();
            //if (txbSearchItem.Text != "")
            //    SearchProductByName(txbSearchItem.Text);
            //else
            //    LoadProduct();
            SearchProductByName(txbSearchItem.Text);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm payment?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                int idBill = BillDAO.Instance.GetMaxIDBill();
                lsvBill.Visible = false;
                btnAddOrder.Enabled = true;
                BillDAO.Instance.AddTotalPrice(idBill, Convert.ToDouble(txbTotal.Text.Remove(0, 1)));
                txbTotal.Text = "$0";
                btnPay.Enabled = false;
                lsvBill.Items.Clear();
                btnAddItem.Enabled = false;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetMaxIDBill();
            if (txbItemName.Text != "")
            {
                int idProduct = ProductDAO.Instance.GetIDProductByName(txbItemName.Text);
                int quantity = (int)nmItemCount.Value;
                BillDetailDAO.Instance.InsertBillDetail(idBill, idProduct, quantity);
                ShowBill(idBill);
                nmItemCount.Value = 1;
            }
            else
            {
                MessageBox.Show("You must choose item before adding!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            lsvBill.Items.Clear();
            BillDAO.Instance.InsertBill(LoginAccount.DisplayName);
            lsvBill.Visible = true;
            btnAddItem.Enabled = true;
            btnAddOrder.Enabled = false;
            btnPay.Enabled = true;
        }
    }
}