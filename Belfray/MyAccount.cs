using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyAccount
    {
        private int staffNo, accTypeID;
        private string staffLogin, staffPassword;

        public MyAccount()
        {
            this.staffNo = 0;
            this.staffLogin = "";
            this.staffPassword = "";
            this.accTypeID = 0;
        }

        public MyAccount(int staffNo, string username, string password, int accType)
        {
            this.staffNo = staffNo;
            this.staffLogin = username;
            this.staffPassword = password;
            this.accTypeID = accType;
        }

        public int StaffNo
        {
            get { return staffNo; }
            set { staffNo = value; }
        }

        public string StaffLogin
        {
            get { return staffLogin; }
            set { staffLogin = value; }
        }

        public string StaffPassword
        {
            get { return staffPassword; }
            set { staffPassword = value; }
        }

        public int AccTypeID
        {
            get { return accTypeID; }
            set { accTypeID = value; }
        }
    }
}
