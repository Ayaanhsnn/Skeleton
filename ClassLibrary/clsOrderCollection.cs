using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<ClsOrder> mOrderList = new List<ClsOrder>();
        ClsOrder mThisOrder = new ClsOrder();
        public List<ClsOrder> OrderList
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

        public ClsOrder ThisOrder
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
    }
}
