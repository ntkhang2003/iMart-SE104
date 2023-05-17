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
    }
}
