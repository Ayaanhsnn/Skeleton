using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        // public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return for private data
                return mStockList;
            }
            set
            {
                // set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return count of the list
                return mStockList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }
        

        // constructor for the class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AStock = new clsStock();
                //read in fields from current record
                AStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AStock.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNo"]);
                AStock.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AStock.DatePurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePurchased"]);
                AStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderNo", mThisStock.OrderNo);
            DB.AddParameter("StockDescription", mThisStock.StockDescription);
            DB.AddParameter("DatePurchased", mThisStock.DatePurchased);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Availability", mThisStock.Availability);
            return DB.Execute("sproc_tblStock_Insert");

        }
    }
            
    }
