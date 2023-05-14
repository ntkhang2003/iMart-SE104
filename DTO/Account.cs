using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMart.DTO
{
    public class Account
    {
        public Account (string userName, string displayName, int accountType, string passWord = null)
        {
            this.UserName = userName;
            this.displayName = displayName;
            this.accountType = accountType;
            this.passWord = passWord;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.displayName = row["displayName"].ToString();
            this.accountType = (int)row["accountType"];
            this.passWord = row["passWord"].ToString();
        }

        public int accountType;
        public int AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        private string passWord;

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}
