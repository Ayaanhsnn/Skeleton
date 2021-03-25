using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);

        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ReceiveMail = true;
            TestItem.CustomerId = 11;
            TestItem.Username = "Rain1";
            TestItem.Password = "PassRain3";
            TestItem.Address = "32 Stormy Lane";
            TestItem.DateOfBirth = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

       


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.ReceiveMail = true;
            TestCustomer.CustomerId = 11;
            TestCustomer.Username = "Rain1";
            TestCustomer.Password = "PassRain3";
            TestCustomer.Address = "32 Stormy Lane";
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ReceiveMail = true;
            TestItem.CustomerId = 11;
            TestItem.Username = "Rain1";
            TestItem.Password = "PassRain3";
            TestItem.Address = "32 Stormy Lane";
            TestItem.DateOfBirth = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.ReceiveMail = true;
            TestItem.CustomerId = 11;
            TestItem.Username = "Rain1";
            TestItem.Password = "PassRain3";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "32 Stormy Lane";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of testdata
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ReceiveMail = true;
            TestItem.CustomerId = 11;
            TestItem.Username = "Rain1";
            TestItem.Password = "PassRain3";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "32 Stormy Lane";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ReceiveMail = true;
            TestItem.Username = "Rain1";
            TestItem.Password = "PassRain3";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "32 Stromy Lane";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key to the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test data
            TestItem.ReceiveMail = false;
            TestItem.Username = "Rainism3";
            TestItem.Password = "PassRainism5";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "23 Rain Street";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisAddress matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByUsernameOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data 
            clsCustomerCollection FilteredUsernames = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredUsernames.ReportByUsername("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, FilteredUsernames.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilteredUsernames = new clsCustomerCollection();
            //apply a username that doesnt exsit
            FilteredUsernames.ReportByUsername("xxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredUsernames.Count);
        }

        [TestMethod]
        public void ReportByUsernamesTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a username that doesnt exist
            FilteredCustomers.ReportByUsername("TestUser");
            //check that the correct number of records are found 
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 8
                if(FilteredCustomers.CustomerList[0].CustomerId != 8)
                {
                    OK = false;

                }
                //check that the Second record is ID 32
                if (FilteredCustomers.CustomerList[1].CustomerId != 32)
                {
                    OK = false;

                }
            }
            else
            {
                OK = false;

            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
