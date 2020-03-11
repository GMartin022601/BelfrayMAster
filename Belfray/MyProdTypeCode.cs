using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyProdTypeCode
    {
        private string prodTypeCode = "", prodTypeDesc = "";

        public MyProdTypeCode()
        {
            this.prodTypeCode = ""; this.prodTypeDesc = "";
        }

        public MyProdTypeCode(string prodTypeCode, string prodTypeDesc)
        {
            this.prodTypeCode = prodTypeCode;
            this.prodTypeDesc = prodTypeDesc;
        }

        public String ProdTypeCode
        {
            get { return prodTypeCode; }
            set
            {
                if (MyValidation.validLength(value, 1, 2))
                {
                    prodTypeCode = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Product Type Code must be between 1-2 Characters");
            }
        }

        public String ProdTypeDesc
        {
            get { return prodTypeDesc; }
            set
            {
                if (MyValidation.validLength(value, 5, 30) && MyValidation.validDesc(value))
                {
                    prodTypeDesc = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Product Description must be between 5-30 Characters");
            }
        }

    }
}
