using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyProduct
    {
        //private int qtyInStock, packSize, reorderLvl;
        //private double costPrice;
        private string productNo, productTypeCode, productDesc, supplierID, qtyInStock, packSize, reorderLvl, costPrice;

        public MyProduct()
        {
            this.productNo = ""; this.productTypeCode = ""; this.productDesc = "";
            this.qtyInStock = ""; this.packSize = ""; this.reorderLvl = ""; this.supplierID = "";
            this.costPrice = "";
        }

        public MyProduct(string qtyInStock, string packSize, string reorderLvl, string supplierID, string costPrice, string productNo, string productTypeCode, string productDesc)
        {
            this.productNo = productNo; this.productTypeCode = productTypeCode; this.productDesc = productDesc;
            this.qtyInStock = qtyInStock; this.packSize = packSize; this.reorderLvl = reorderLvl; this.supplierID = supplierID;
            this.costPrice = costPrice;
        }

        //ProductNo THIS NEEDS CHANGED TO VALIDATE PRODUCT NUMBER
        public string ProductNo
        {
            get { return productNo; }
            set { productNo = value; }
        }
        //ProductTypeCode
        public string ProductTypeCode
        {
            get { return productTypeCode; }
            set { productTypeCode = value; }
        }
        //ProductDesc
        public string ProductDesc
        {
            get { return productDesc; }
            set { if (MyValidation.validLength(value, 5, 30) && MyValidation.validDesc(value))
                {
                    productDesc = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Product Description must be between 5-30 Characters"); }
        }
        //QtyInStock **NEEDS VALIDATION**
        public string QtyInStock
        {
            get { return qtyInStock; }
            set {
                if (MyValidation.validLength(value, 1, 50) && MyValidation.validNumber(value))
                {
                    qtyInStock = value;
                }
                else
                    throw new MyException("Quantity must be a valid number between 1 - 50");
            }

        }
        //PackSize
        public string PackSize
        {
            get { return packSize; }
            set {
                if (MyValidation.validNumber(value) && MyValidation.validLength(value, 1, 24))
                {
                    packSize = value;
                }
                else
                    throw new MyException("Pack Size must be a valid number between 1 - 24");
            }
        }
        //ReOrderLvl
        public string ReOrderLvl
        {
            get { return reorderLvl; }
            set
            {
                if (MyValidation.validNumber(value) && MyValidation.validLength(value, 1, 5))
                {
                    reorderLvl = value;
                }
                else
                    throw new MyException("Re-order level must be a valid number between 1 - 5");
            }
        }
        //SupplierID
        public string SupplierID
        {
            get { return supplierID; }
            set
            {
                if (MyValidation.validLength(value, 8, 8))
                {
                    supplierID = value;
                }
                else
                    throw new MyException("Supplier ID must be 8 Characters");
            }
        }
        //CostPrice
        public string CostPrice
        {
            get { return costPrice; }
            set { costPrice = value;
            }
        }
    }
}
