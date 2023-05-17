using iMart.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DTO
{
    public class Menu
    {
        public Menu(string productName, int quantity, double price, double amount = 0)
        {
            this.ProductName = productName;
            this.Quantity = quantity;
            this.UnitPrice = price;
            this.Amount = amount;
        }

        public Menu(DataRow row)
        {
            this.ProductName = row["productName"].ToString();
            this.Quantity = (int)row["quantity"];
            this.UnitPrice = (double)(row["price"]);
            this.Amount = (double)(row["amount"]);
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private double unitPrice;

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
    }
}
