using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyStaff
    {
        private string staffNo, staffFName, staffSName, staffStreet, staffCity, staffCounty, staffPC, staffTel, contactName, contactTel, staffLogin, staffPW, accTypeID;

        public MyStaff()
        {
            this.staffNo = "";
            this.staffFName = "";
            this.staffSName = "";
            this.staffStreet = "";
            this.staffCity = "";
            this.staffCounty = "";
            this.staffPC = "";
            this.staffTel = "";
            this.contactName = "";
            this.contactTel = "";
            this.staffLogin = "";
            this.staffPW = "";
            this.accTypeID = "";
        }

        public MyStaff(string staffNo, string staffFName, string staffSName, string staffStreet, string staffCity, string staffCounty, string staffPC, string staffTel, string contactName, string contactTel, string staffLogin, string staffPW, string accTypeID)
        {
            this.staffNo = staffNo;
            this.staffFName = staffFName;
            this.staffSName = staffSName;
            this.staffStreet = staffStreet;
            this.staffCity = staffCity;
            this.staffCounty = staffCounty;
            this.staffPC = staffCounty;
            this.staffTel = staffTel;
            this.contactName = contactName;
            this.contactTel = contactTel;
            this.staffLogin = staffLogin;
            this.staffPW = staffPW;
            this.accTypeID = accTypeID;
        }

        public string StaffNumber
        {
            get { return staffNo; }
            set { staffNo = value; }
        }

        public string Surname
        {
            get { return staffSName; }
            set
            {
                if (MyValidation.validLength(value, 2, 16) && MyValidation.validSurname(value))
                {
                    staffSName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Surname must be between 2-16 letters");
                }
            }
        }

        public string Forename
        {
            get { return staffFName; }
            set
            {
                if (MyValidation.validLength(value, 2, 16) && MyValidation.validForename(value))
                {
                    staffFName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Forename must be between 2-16 letters");
                }
            }
        }

        public string Street
        {
            get { return staffStreet; }
            set
            {
                if (MyValidation.validLength(value, 5, 30) && MyValidation.validLetterNumberWhiteSpace(value))
                {
                    staffStreet = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Street must be between 5-30 letters");
                }
            }
        }

        public string City
        {
            get { return staffCity; }
            set
            {
                if (MyValidation.validLength(value, 2, 18) && MyValidation.validLetterWhiteSpace(value))
                {
                    staffCity = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("City must be between 2-18 letters");
                }
            }
        }

        public string County
        {
            get { return staffCounty; }
            set
            {
                if (MyValidation.validLength(value, 5, 18) && MyValidation.validDesc(value))
                {
                    staffCounty = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("County must be between 5-18 letters");
                }
            }
        }

        public string Postcode
        {
            get { return staffPC; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhiteSpace(value))
                {
                    staffPC = MyValidation.EachLetterToUpper(value);
                }
                else
                {
                    throw new MyException("Postcode must be between 7-8 characters and alphanumeric only");
                }
            }

        }

        public string TelNo
        {
            get { return staffTel; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    staffTel = value;
                }
                else
                {
                    throw new MyException("Telephone must be between 11-15 digits");
                }
            }
        }

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (MyValidation.validLength(value, 4, 30) && MyValidation.validLetterWhiteSpace(value))
                {
                    contactName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Name must be between 4-30 letters");
                }
            }
        }

        public string ContactTelNo
        {
            get { return contactTel; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    contactTel = value;
                }
                else
                {
                    throw new MyException("Telephone must be between 11-15 digits");
                }
            }
        }

        public string StaffLogin
        {
            get { return staffLogin; }
            set
            {
                if (MyValidation.validLength(value, 4, 20) && MyValidation.validLetterWhiteSpace(value))
                {
                    staffLogin = MyValidation.firstLastLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Login must be between 4-20 letters");
                }
            }
        }

        public string StaffPW
        {
            get { return staffPW; }
            set
            {
                if (MyValidation.validLength(value, 8, 20) && MyValidation.validPW(value))
                {
                    staffPW = value;
                }
                else
                {
                    throw new MyException("Password must be between 8 and 20 characters long and can only contain numbers, letters and special characters like (@-_.!?$*). Please try again.");
                }
            }
        }

        public string AccType
        {
            get { return accTypeID; }
            set { accTypeID = value;}
        }
    }
}
