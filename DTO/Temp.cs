using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DTO
{
    public class Temp
    {
        public Temp(string productName, int quantity, double unitPrice, double amount = 0)
        {
            this.ProductName = productName;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.Amount = amount;
        }

        public Temp(DataRow row)
        {
            this.ProductName = (string)row["name"];
            this.Quantity = (int)row["quantity"];
            this.UnitPrice = (double)row["price"];
            this.Amount = (double)row["amount"];
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
