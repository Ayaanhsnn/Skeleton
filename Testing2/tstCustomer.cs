using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ReceiveMailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data 
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.ReceiveMail = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnCustomer.ReceiveMail, TestData);

        }
      
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);

        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);

        }

        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Mark1";
            //assign the data to the property
            AnCustomer.Username = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Username, TestData);
        }
        

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "PassMark1";
            //assign the data to the property
            AnCustomer.Password = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Password, TestData);
        }



        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "27 Wrong Lane";
            //assign the data to property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Address, TestData);

        }
    }
}
