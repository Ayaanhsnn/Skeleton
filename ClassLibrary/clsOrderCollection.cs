using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }




        
    }
        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            
            DB.AddParameter("@ClothesAvailable", mThisOrder.ClothesAvailable);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@DatePurchased", mThisOrder.DatePurchased);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }
        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@ClothesAvailable", mThisOrder.ClothesAvailable);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@DatePurchased", mThisOrder.DatePurchased);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Update");
            
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrder_Delete");
        }
        public void ReportByAddress(string Address)
        {
            //filters records based on full or partial description
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send description parameter to the database
            DB.AddParameter("@Address", Address);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_FilterByAddress");
            //populate array list with data table
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                AnOrder.DatePurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePurchased"]);
                AnOrder.ClothesAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["ClothesAvailable"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}
