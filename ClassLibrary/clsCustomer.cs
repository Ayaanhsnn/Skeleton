using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mCustomerId;
        private DateTime mDateOfBirth;
        private String mUsername;
        private String mPassword;
        private String mAddress;
        private Boolean mReceiveMail;

        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
       
        }

        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }


        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }


        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }

        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public bool ReceiveMail
        {
            get
            {
                return mReceiveMail;
            }
            set
            {
                mReceiveMail = value;
            }
        }
        
       

        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomerDetails_FilterByCustomerId");
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[0]["ReceiveMail"]);

                return true;
            }

            else
            {
                return false;
            }

        }




    }
}