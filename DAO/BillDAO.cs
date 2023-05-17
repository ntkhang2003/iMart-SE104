using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        public void InsertBill()
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBill");
        }
        public int GetMaxIDBill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idBill) FROM dbo.BILL");
        }
        public void AddTotalPrice(int id, double totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_AddTotalPrice @idBill , @totalPrice", new object[] { id, totalPrice });
        }
    }
}
