using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? billDate, double totalPrice)
        {
            this.ID = id;
            this.BillDate = billDate;
            this.TotalPrice = totalPrice;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["idBill"];
            this.BillDate = (DateTime?)row["billDate"];
            this.TotalPrice = (double)row["totalPrice"];
        }

        private double totalPrice;

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private DateTime? billDate;

        public DateTime? BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
