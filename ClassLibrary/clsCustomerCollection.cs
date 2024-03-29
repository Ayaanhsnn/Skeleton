﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer 
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }



       public clsCustomerCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomerDetails_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@ReceiveMail", mThisCustomer.ReceiveMail);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomerDetails_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomerDetails_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@ReceiveMail", mThisCustomer.ReceiveMail);
            //execture the stored procedure
            DB.Execute("sproc_tblCustomerDetails_Update");
        }

        public void ReportByUsername(string Username)
        {
            //filter the records based on a full or partial username
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the Username parameter to the database
            DB.AddParameter("@Username", Username);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomerDetails_FilterByUsernames");
            //populate the array list with the data table 
            PopulateArray(DB);
           
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.ReceiveMail = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReceiveMail"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    }
}