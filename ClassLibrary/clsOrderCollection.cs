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
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@ClothesAvailable", mThisOrder.ClothesAvailable);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@DatePurchased", mThisOrder.DatePurchased);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
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
            
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrder_Delete");
        }
    }
}
