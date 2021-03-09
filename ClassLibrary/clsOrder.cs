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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mDatePurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                mClothesAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["ClothesAvailable"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string Address, string DeliveryDate, string DatePurchased)
        {
            String Error = "";
            DateTime DateTemp;
            if (Address.Length == 0)
            {
                Error = Error + "The address may not be blank";
            }
            //if the town is too long
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }
            DateTemp = Convert.ToDateTime(DeliveryDate);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future";
            }

            //return any error messages
            return Error;

        }
                  
        }

    }
