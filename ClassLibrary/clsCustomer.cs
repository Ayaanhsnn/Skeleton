using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the properties
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
        //public property for date of birth
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }

        //public property for the username
        public string Username
        {
            get
            {
                //return the private data
                return mUsername;
            }
            set
            {
                //set the private data
                mUsername = value;
            }
        }

        //public property for password
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }

        }
        //public property for Address
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
        //public property for ReceiveMail
        public bool ReceiveMail
        {
            get
            {
                //return the private data
                return mReceiveMail;
            }
            set
            {
                //set the private data
                mReceiveMail = value;
            }
        }
        
       

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomerDetails_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[0]["ReceiveMail"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string username, string password, string address, string dateOfBirth)
        {
            //create a string variable tp store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Username is blank
            if (username.Length == 0)
            {
                //record the error
                Error = Error + "The username may not be blank : ";
            }

            //if the username is greater than 50 characters
            if (username.Length > 50)
            {
                //record the error

                Error = Error + "The username must be less than 50 characters : ";
            }
            try
            {


                //copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";

                }
                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "the date was not a valid date : ";
            }
            //if the password is blank
            if (password.Length == 0)
            {
                //record
                Error = Error + " The password may not be blank : ";
            

            }
            //if the password is greater than 50 characters
            if (password.Length > 50)
            {
                //record the error
                Error = Error + "The password must be less than 50 characters : ";
            }

            //if the address is blank
            if (address.Length == 0)
            {
                //record
                Error = Error + " The address may not be blank : ";
            }

            //if the address is greater than 50 characters
            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }

            //return any error messages
            return Error;
        }
    }
}