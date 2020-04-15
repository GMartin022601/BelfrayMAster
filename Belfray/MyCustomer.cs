 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyCustomer
    {
        private string customerNo, cusTitle, cusSurname, cusFname, cusStreet, cusCity, cusCounty, cusPC, cusTel;

        public MyCustomer()
        {
            this.customerNo = ""; this.cusTitle = ""; this.cusSurname = ""; this.cusFname = ""; this.cusStreet = ""; this.cusCity = "";
            this.cusCounty = ""; this.cusPC = ""; this.cusTel = "";
        }

        public MyCustomer(string customerNo, string cusTitle, string cusSurname, string cusFname, string cusStreet, string cusCity, string cusCounty, string cusPC, string cusTel)
        {
            this.customerNo = customerNo; this.cusTitle = cusTitle; this.cusSurname = cusSurname; this.cusFname = cusFname; this.cusStreet = cusStreet; this.cusCounty = cusCounty;
            this.cusPC = cusPC; this.cusTel = cusTel;
        }

        public string CustomerNumber
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        public string Title
        {
            get { return cusTitle; }
            set
            {
                if (value.ToUpper() != "MR" && value.ToUpper() != "MISS" && value.ToUpper() != "MRS" && value.ToUpper() != "MS" && value.ToUpper() != "DR")
                {
                    throw new MyException("Title must be MR, MISS, MRS, MS or DR");
                }
                else
                {
                    cusTitle = MyValidation.EachLetterToUpper(value);
                }
            }
        }

        public string Surname
        {
            get { return cusSurname; }
            set
            {
                if (MyValidation.validLength(value, 2, 16) && MyValidation.validSurname(value))
                {
                    cusSurname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Surname must be between 2-16 letters");
                }
            }
        }

        public string Forename
        {
            get { return cusFname; }
            set
            {
                if (MyValidation.validLength(value, 2, 16) && MyValidation.validForename(value))
                {
                    cusFname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Forename must be between 2-16 letters");
                }
            }
        }

        public string Street
        {
            get { return cusStreet; }
            set
            {
                if (MyValidation.validLength(value, 5, 30) && MyValidation.validLetterNumberWhiteSpace(value))
                {
                    cusStreet = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Street must be between 5-30 letters");
                }
            }
        }

        public string City
        {
            get { return cusCity; }
            set
            {
                if (MyValidation.validLength(value, 2, 18) && MyValidation.validLetterWhiteSpace(value))
                {
                    cusCity = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Street must be between 2-18 letters");
                }
            }
        }

        public String County
        {
            get { return cusCounty; }
            set
            {
                if (MyValidation.validLength(value, 5, 18) && MyValidation.validLetter(value))
                {
                    cusCounty = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("County must be between 5-18 letters");
                }
            }
        }

        public string Postcode
        {
            get { return cusPC; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhiteSpace(value))
                {
                    cusPC = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Postcode must be between 7-8 characters and alphanumeric only");
                }
            }

        }

        public string TelNo
        {
            get { return cusTel; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    cusTel = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Telephone must be between 11-15 digits");
                }
            }
        }
    }
}
