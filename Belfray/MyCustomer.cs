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

        public string CustomerTitle
        {
            get { return cusTitle; }
            set { cusTitle = value; }
        }

        public string CustomerSurname
        {
            get { return cusSurname; }
            set { cusSurname = value; }
        }

        public string CustomerForename
        {
            get { return cusFname; }
            set { cusFname = value; }
        }

        public string CustomerStreet
        {
            get { return cusStreet; }
            set { cusStreet = value; }
        }

        public string CustomerCity
        {
            get { return cusCity; }
            set { cusCity = value; }
        }

        public string CustomerCounty
        {
            get { return cusCounty; }
            set { cusCounty = value; }
        }

        public string CustomerPC
        {
            get { return cusPC; }
            set { cusPC = value; }
        }

        public string CustomerTelNo
        {
            get { return cusTel; }
            set { CustomerTelNo = value; }
        }
    }
}
