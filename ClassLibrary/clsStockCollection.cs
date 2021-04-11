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
        
        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
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

        public void Delete()
        {
            //deletes record pointed to by thisStock
            //connects to database
            clsDataConnection DB = new clsDataConnection();
            //sets parameter for stored procedure
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update existing record based on thisStock values
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("StockNo", mThisStock.StockNo);
            DB.AddParameter("OrderNo", mThisStock.OrderNo);
            DB.AddParameter("StockDescription", mThisStock.StockDescription);
            DB.AddParameter("DatePurchased", mThisStock.DatePurchased);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Availability", mThisStock.Availability);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");

        }

        public void ReportByStockDescription(string StockDescription)
        {
            //filters records based on full or partial description
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send description parameter to the database
            DB.AddParameter("@StockDescription", StockDescription);
            //execute stored procedure
            DB.Execute("sproc_tblStock_FilterByStockDescription");
            //populate array list with data table
            PopulateArray(DB);
            
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on data table in parameter DB
            //var for index
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are new records to process
            while (Index < RecordCount)
            {
                //create blank stock
                clsStock AStock = new clsStock();
                //fields from active record
                AStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AStock.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNo"]);
                AStock.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AStock.DatePurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePurchased"]);
                AStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add record to private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }
    }
            
    }
