using System;
using System.Collections.Generic;
using System.Data;
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

        public void InsertBill(string displayName)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @cashierName ", new object[] { displayName });
        }
        public int GetMaxIDBill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idBill) FROM dbo.BILL");
        }
        public void AddTotalPrice(int id, double totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_AddTotalPrice @idBill , @totalPrice", new object[] { id, totalPrice });
        }
        public DataTable GetListBillByDate(DateTime dateBegin, DateTime dateEnd)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListBillByDate @dateBegin , @dateEnd", new object[] { dateBegin, dateEnd });
        }
        public int GetNumberOfBill(DateTime dateBegin, DateTime dateEnd)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(idBill) FROM dbo.BILL WHERE billDate >= '" + dateBegin + "' AND billDate <= '" + dateEnd + "'");
        }
        public double GetTotalOfTotal(DateTime dateBegin, DateTime dateEnd)
        {
            return (double)DataProvider.Instance.ExecuteScalar("SELECT SUM(totalPrice) FROM dbo.BILL WHERE billDate >= '" + dateBegin + "' AND billDate <= '" + dateEnd + "'");
        }
    }
}
