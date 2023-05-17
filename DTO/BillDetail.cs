using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DTO
{
    public class BillDetail
    {
        public BillDetail(int id, int idBIll, int idProduct, int quantity)
        {
            this.ID = id;
            this.IdBill = idBIll;
            this.IdProduct = idProduct;
            this.quantity = quantity;
        }

        public BillDetail(DataRow row)
        {
            this.ID = (int)row["idBillDetail"];
            this.IdBill = (int)row["idBill"];
            this.IdProduct = (int)row["idProduct"];
            this.quantity = (int)row["quantity"];
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private int idProduct;

        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        private int idBill;

        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
