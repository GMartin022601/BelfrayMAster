using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyProduct
    {
        private int qtyInStock, packSize, reorderLvl, supplierID;
        private double costPrice;
        private string productNo, productTypeCode, productDesc;

        public MyProduct()
        {
            this.productNo = ""; this.productTypeCode = ""; this.productDesc = "";
            this.qtyInStock = 0; this.packSize = 0; this.reorderLvl = 0; this.supplierID = 0;
            this.costPrice = 0.0;
        }

        public MyProduct(int qtyInStock, int packSize, int reorderLvl, int supplierID, double costPrice, string productNo, string productTypeCode, string productDesc)
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
            set { if (value.ToUpper() != "A" && value.ToUpper() != "L" && value.ToUpper() != "AF" && value.ToUpper() != "F" && value.ToUpper() != "F" && value.ToUpper() != "RE")
                    throw new MyException("Product Code should be one of the following: A, AF, L, F, RE");
                else
                    productTypeCode = MyValidation.EachLetterToUpper(value); }
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
        public int QtyInStock
        {
            get { return qtyInStock; }
            set { qtyInStock = value; }
        }
        //PackSize
        public int PackSize
        {
            get { return packSize; }
            set { packSize = value; }
        }
        //ReOrderLvl
        public int ReOrderLvl
        {
            get { return reorderLvl; }
            set { reorderLvl = value; }
        }
        //SupplierID
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        //CostPrice
        public double CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }
    }
}
