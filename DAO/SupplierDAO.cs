using iMart.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;

        public static SupplierDAO Instance
        {
            get { if (instance == null) instance = new SupplierDAO(); return SupplierDAO.instance; }
            private set { SupplierDAO.instance = value; }
        }

        private SupplierDAO() { }

        public List<Supplier> GetListSupplier()
        {
            List<Supplier> list = new List<Supplier>();

            string query = "select * from dbo.SUPPLIER";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Supplier Supplier = new Supplier(item);
                list.Add(Supplier);
            }

            return list;
        }

        public int GetIDSupplierByName(string name)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT idSupplier FROM dbo.SUPPLIER WHERE supplierName = '" + name + "'");

            return (int)data.Rows[0]["idSupplier"];
        }
    }
}
