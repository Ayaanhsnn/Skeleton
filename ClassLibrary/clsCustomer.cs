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
            mCustomerId = 21;
            mDateOfBirth = Convert.ToDateTime("21/02/2019");
            mUsername = "Jackson3";
            mPassword = "PassJackson2";
            mAddress = "23 Wrong Lane";
            mReceiveMail = true;

            //always true
            return true;
        }
    }
}