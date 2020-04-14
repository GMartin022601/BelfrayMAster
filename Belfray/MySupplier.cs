using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MySupplier
    {
        //private int supplierID = 0;
        private string supplierName, supplierAddress, supplierTown, supplierCounty, supplierPostCode, supplierEmail, supplierTelNo, supplierID;

        public MySupplier()
        {
            this.supplierID = "";
            this.supplierName = ""; this.supplierAddress = ""; this.supplierTown = ""; this.supplierCounty = "";
            this.supplierPostCode = ""; this.supplierEmail = ""; this.supplierTelNo = "";
        }

        public MySupplier(string supplierID, string supplierName, string supplierAddress, string supplierTown, string supplierCounty, string supplierPostCode, string supplierEmail, string supplierTelNo)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName; this.supplierAddress = supplierAddress; this.supplierTown = supplierTown; this.supplierCounty = supplierCounty;
            this.supplierPostCode = supplierPostCode; this.supplierEmail = supplierEmail; this.supplierTelNo = supplierTelNo;
        }
        public string SupplierID
        {
            get { return supplierID; }
            set
            {
                //if (MyValidation.validNumber(value))
               // {
                    supplierID = value;
               // }
               // else
                //    throw new MyException("Must be a Number");
            }
        }
    public string SupplierName
        { 
            get { return supplierName; }
            set
            {
                if (MyValidation.validLetterWhiteSpace(value) && MyValidation.validLength(value, 2, 25))
                {
                    supplierName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Supplier Name must be between 2 & 25 Characters");
            }
        }
        public string SupplierAddress
        {
            get { return supplierAddress; }
            set
            {
                if (MyValidation.validLetterNumberWhiteSpace(value) && MyValidation.validLength(value, 5, 50))
                {
                    supplierAddress = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Address must be between 5 - 50 Characters");
            }
        }
        public string SupplierTown
        {
            get { return supplierTown; }
            set
            {
                if (MyValidation.validLength(value, 3, 20))
                {
                    supplierTown = value;
                }
                else
                    throw new MyException("Town must be between 3 - 20 Characters");
            }
        }
        public string SupplierCounty
        {
            get { return supplierCounty; }
            set
            {
                if (MyValidation.validLength(value, 3, 18) && MyValidation.validDesc(value))
                {
                    supplierCounty = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be between 3 - 18 Characters");
            }
        }
        public string SupplierPostCode
        {
            get { return supplierPostCode; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhiteSpace(value))
                {
                    supplierPostCode = value;
                }
                else
                    throw new MyException("Postcode must be 8 Characters");
            }
        }
        public string SupplierEmail
        {
            get { return supplierEmail; }
            set
            {
                if (MyValidation.validEmail(value))
                {
                    supplierEmail = value;
                }
                else
                    throw new MyException("Invalid Email");
            }
        }
        public string SupplierTelNo
        {
            get { return supplierTelNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 13))
                {
                    supplierTelNo = value;
                }
                else
                    throw new MyException("Invalid Tel No");
            }
        }

    }
}