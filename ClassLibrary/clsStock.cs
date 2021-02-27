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

        public string Valid(string orderNo, string stockDescription, string datePurchased, string quantity)
        {
            DateTime DateTemp;
            
            //create a string variable to store the error
            String Error = "";
            Int32 OrderNoTemp;
            // if the OrderNo is blank

            OrderNoTemp = Convert.ToInt32(orderNo);
            if (OrderNoTemp < 0)
            {
                //record the error
                Error = Error + "The orderNo can not be below 0";
            }
            if (OrderNoTemp > Int32.MaxValue)
            {
                Error = Error + "The orderNo can not be above 2147483647 (MaxValue) : ";

            }
                // stock description 
                if (stockDescription.Length == 0)
                {
                    Error = Error + "The stock description may not be blank : ";
                }
                if (stockDescription.Length > 50)
                {
                    Error = Error + "The stock description must be less than 50 characters : ";
                } 
            // date purchased 
            try
            {


                DateTemp = Convert.ToDateTime(datePurchased);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            // quantity
            Int32 QuantityTemp;

            QuantityTemp = Convert.ToInt32(orderNo);
            if (QuantityTemp < 0)
            {
                Error = Error + "The quantity can not be below 0";
            }
            if (QuantityTemp > Int32.MaxValue)
            {
                Error = Error + "The quantity can not be above 2147483647 (MaxValue) : ";

            }

            //return any error messages
            return Error;


            }
        }

    }

