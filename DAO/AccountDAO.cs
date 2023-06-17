using iMart.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; } 
        }

        private AccountDAO() { }
        public string HashPass(string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        public bool Login (string userName, string passWord)
        {
            string hasPass = HashPass(passWord);

            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass});

            return result.Rows.Count > 0;  
        }

        public bool UpdateAccount (string userName, string displayName, string pass, string newPass)
        {
            string hasPass = HashPass(pass);
            string hasNewPass = HashPass(newPass);

            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayname , @password , @newPassword", new object[] { userName, displayName, hasPass, hasNewPass });

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT userName, displayName, accountType FROM dbo.ACCOUNT");
        }
        public DataTable SearchAccount(string displayName)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("SELECT userName, displayName, accountType FROM dbo.ACCOUNT WHERE displayName LIKE N'%{0}%'", displayName));
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ACCOUNT where userName ='" + userName + "'");
            
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.ACCOUNT ( UserName, DisplayName, accountType, password )VALUES ( N'{0}', N'{1}', {2}, N'{3}')", name, displayName, type, "1962026656160185351301320480154111117132155");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET DisplayName = N'{1}', accountType = {2} WHERE Username = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {

            string query = string.Format("DELETE ACCOUNT WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE ACCOUNT SET password = N'1962026656160185351301320480154111117132155' WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
