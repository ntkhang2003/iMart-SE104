using iMart.DAO;
using iMart.DTO;
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
    public partial class fInventory : Form
    {
        BindingSource productList = new BindingSource();
        public fInventory()
        {
            InitializeComponent();
            LoadProductList();
            AddProductBinding();
        }

        //Methods
        void LoadProductList()
        {
            dtgvInven.DataSource = productList;
            productList.DataSource = ProductDAO.Instance.LoadProductList();
            cbSupplier.DataSource = SupplierDAO.Instance.GetListSupplier();
            cbSupplier.DisplayMember = "Name";
        }
        void AddProductBinding()
        {
            txbProductID.DataBindings.Add(new Binding("Text", dtgvInven.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbProductName.DataBindings.Add(new Binding("Text", dtgvInven.DataSource, "Name", true, DataSourceUpdateMode.Never));
            cbSupplier.DataBindings.Add(new Binding("Text", dtgvInven.DataSource, "SupplierName", true, DataSourceUpdateMode.Never));
            nmProductPrice.DataBindings.Add(new Binding("Value", dtgvInven.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        //Events
        private void btnReadInven_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnCreateInven_Click(object sender, EventArgs e)
        {
            string productName = txbProductName.Text;
            double price = (double)nmProductPrice.Value;
            string supplierName = (cbSupplier.SelectedItem as Supplier).Name ;
            int idSupplier = SupplierDAO.Instance.GetIDSupplierByName(supplierName);
            if (ProductDAO.Instance.InsertProduct(productName, price, idSupplier))
            {
                MessageBox.Show("Add product successfully!");
                LoadProductList();
            }
            else
            {
                MessageBox.Show("Error occurred when adding product!");
            }
        }

        private void btnUpdateInven_Click(object sender, EventArgs e)
        {
            string productName = txbProductName.Text;
            double price = (double)nmProductPrice.Value;
            string supplierName = (cbSupplier.SelectedItem as Supplier).Name;
            int idSupplier = SupplierDAO.Instance.GetIDSupplierByName(supplierName);
            int idProduct = Convert.ToInt32(txbProductID.Text);
            if (ProductDAO.Instance.UpdateProduct(idProduct, productName, price, idSupplier))
            {
                MessageBox.Show("Update product successfully!");
                LoadProductList();
            }
            else
            {
                MessageBox.Show("Error occurred when updating product!");
            }
        }

        private void btnDeleteInven_Click(object sender, EventArgs e)
        {
            int idProduct = Convert.ToInt32(txbProductID.Text);
            if (ProductDAO.Instance.DeleteProduct(idProduct))
            {
                MessageBox.Show("Delete product successfully!");
                LoadProductList();
            }
            else
            {
                MessageBox.Show("Error occurred when deleting product!");
            }
        }
    }
}
