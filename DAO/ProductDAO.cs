using iMart.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        public static int ProductWidth = 160;
        public static int ProductHeight = 160;
        private ProductDAO() { }
        public List<Product> LoadProductList()
        {
            List<Product> productList = new List<Product>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetProductList");
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }
            return productList;
        }
        public List<Product> SearchProductByName(string name) 
        {
            List<Product> productList = new List<Product>();

            string query = string.Format("SELECT idProduct, productName, price, supplierName " +
                "FROM dbo.PRODUCT JOIN dbo.SUPPLIER ON dbo.PRODUCT.idSupplier = dbo.SUPPLIER.idSupplier " +
                "WHERE productName LIKE N'%{0}%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }

            return productList;
        }

        public int GetIDProductByName(string name)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT idProduct FROM dbo.PRODUCT WHERE productName = '" + name + "'");

            return (int)data.Rows[0]["idProduct"];
        }

        public bool InsertProduct(string productName, double price, int idSupplier)
        {
            string query = string.Format("INSERT INTO dbo.PRODUCT (productName, price, idSupplier) VALUES (N'{0}', {1}, {2})", productName, price, idSupplier);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(int idProduct, string productName, double price, int idSupplier)
        {
            string query = string.Format("UPDATE dbo.PRODUCT SET productName = N'{0}', price = {1}, idSupplier = {2} WHERE idProduct = {3}", productName, price, idSupplier, idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteProduct(int idProduct)
        {
            BillDetailDAO.Instance.DeleteBillDetailByProductID(idProduct);
            string query = string.Format("DELETE FROM dbo.PRODUCT WHERE idProduct = {0}", idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
