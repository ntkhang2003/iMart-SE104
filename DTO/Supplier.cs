using iMart.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DTO
{
    public class Supplier
    {
        public Supplier(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Supplier(DataRow row)
        {
            this.ID = (int)row["idSupplier"];
            this.Name = row["supplierName"].ToString();
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
