using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<ClsOrder> mOrderList = new List<ClsOrder>();
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
       
        public ClsOrder ThisOrder { get; set; }
        public clsOrderCollection()
        { }
    }
}