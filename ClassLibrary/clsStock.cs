using System;

namespace ClassLibrary
{
    public class  clsStock
    {
        private Int32 mStockNo;
        public int StockNo
        {
            get
            {
                return mStockNo;
            }
            set
            {
                mStockNo = value;
            }
        }
        private Int32 mOrderNo;
        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }

        private Int32 mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        private string mStockDesc;
        public string StockDesc
        {
            get
            {
                return mStockDesc;
            }
            set
            {
                mStockDesc = value;
            }
        }
        private DateTime mDatePurch;
        public DateTime DatePurch
        {
            get
            {
                return mDatePurch;
            }
            set
            {
                mDatePurch = value;
            }
        }
        private Boolean mAvailability;
        public bool Availability
        {
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }
        }

        public bool Find(int StockNo)
        {
            mStockNo = 21;
            mOrderNo = 22;
            mStockDesc = "Large";
            mDatePurch = Convert.ToDateTime("16/9/2015");
            mAvailability = true;
            mQuantity = 20;

            return true;
        }
    }
}