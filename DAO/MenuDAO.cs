using iMart.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenu(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT productName, price, quantity, price*quantity AS amount FROM dbo.BILLDETAIL JOIN dbo.PRODUCT ON dbo.PRODUCT.idProduct = dbo.BILLDETAIL.idProduct WHERE dbo.BILLDETAIL.idBill = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
