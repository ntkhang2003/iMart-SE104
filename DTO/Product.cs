using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace iMart.DTO
{
    public class Product
    {
        public Product(int id, string name, float price, string supplierName) 
        { 
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.SupplierName = supplierName;
        }
        public Product(DataRow row)
        {
            this.ID = (int)row["idProduct"];
            this.Name = (string)row["productName"];
            this.Price = (double)row["price"];
            this.SupplierName = (string)row["supplierName"];
        }
        private int iD;
        private string name;
        private double price;
        private string supplierName;
        public int ID
        {
            get { return iD; }
            set { iD = value; } 
        }

        public string Name 
        { 
            get { return name; }
            set { name = value; } 
        }

        public double Price 
        { 
            get { return price; }
            set { price = value; }
        }

        public string SupplierName 
        {
            get { return supplierName; }
            set { supplierName = value; }
        }
    }
}
