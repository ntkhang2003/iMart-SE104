using iMart.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance
        {
            get { if (instance == null) instance = new BillDetailDAO(); return BillDetailDAO.instance; }
            private set { BillDetailDAO.instance = value; }
        }

        private BillDetailDAO() { }

        public List<BillDetail> GetListBillDetail(int id) 
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BILLDETAIL WHERE idBill = " + id);

            foreach (DataRow item in data.Rows) 
            {
                BillDetail detail = new BillDetail(item);
                listBillDetail.Add(detail);
            }
            return listBillDetail;
        }
        public void InsertBillDetail(int idBill, int idProduct, int quantity)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillDetail @idBill , @idProduct , @quantity", new object[] { idBill, idProduct, quantity });
        }

        public void DeleteBillDetailByProductID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE FROM dbo.BILLDETAIL WHERE idProduct = " + id);
        }
    }
}
