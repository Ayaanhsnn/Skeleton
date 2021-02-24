using System;

namespace ClassLibrary
{
    public class clsStock
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
        private string mStockDescription;
        public string StockDescription
        {
            get
            {
                return mStockDescription;
            }
            set
            {
                mStockDescription = value;
            }
        }
        private DateTime mDatePurchased;
        public DateTime DatePurchased
        {
            get
            {
                return mDatePurchased;
            }
            set
            {
                mDatePurchased = value;
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", StockNo);
            DB.Execute("sproc_tblStock_FilterByStockNo");

            if (DB.Count == 1)
            {


                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mDatePurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);


                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
