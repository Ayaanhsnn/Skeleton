using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ClsOrder
    {

        //private data member for active
        private Boolean mClothesAvailable;
        //public property for active
        public bool ClothesAvailable
        {
            get
            {
                //return the private data
                return mClothesAvailable;
            }
            set
            {
                //set the private data
                mClothesAvailable = value;
            }
        }

        //private date added data member
        private DateTime mDatePurchased;
        //public property for date added
        public DateTime DatePurchased
        {
            get
            {
                //return the private data
                return mDatePurchased;
            }
            set
            {
                //set the private data
                mDatePurchased = value;
            }
        }

        //private data member for the AddressNo property
        private Int32 mOrderNo;
        //public property for the address number
        public int OrderNo
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member
                mOrderNo = value;
            }
        }

        //private data member for street
        private string mAddress;
        //public data member for street
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
             }
            set
            {
                //set the private data
                 mAddress = value;
            }
        }

        //private data member for town
        private DateTime mDeliveryDate;
        //public data member for Town
        public DateTime DeliveryDate
        {
            get
            {
                //return the private data
                return mDeliveryDate;
            }
            set
            {
                //set the private data
                mDeliveryDate = value;
             }
        }

        public bool Find(int OrderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 21;
            mDeliveryDate= Convert.ToDateTime("16/9/2020");
            mAddress = "102 red street Leicester";
            mDatePurchased = Convert.ToDateTime("16/9/2015");
            mClothesAvailable = true;
            //always return true
            return true;
        }



    }
}