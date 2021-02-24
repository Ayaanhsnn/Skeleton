using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass the method 
        string Username = "Jaehyun3";
        string Password = "PassJaehyun1";
        string Address = "21 Love Lane";
        string DateOfBirth = DateTime.Now.Date.ToString();



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


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the results of validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 CustomerId = 8;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }
        
        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 8;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerId != 8 )
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 8;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("21/02/2019"))
            {
                OK = false;

            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestUsernameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 8;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Username != "TestUser")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 8;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Password != "TestPass")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 8;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Address != "Test Address")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReceiveMail()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 8;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.ReceiveMail != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Username = ""; // this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the reult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Username = "a";
            //invoke method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Username = "aa";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the test is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Username = "";
            Username = Username.PadRight(49, 'a');
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Username = "";
            Username = Username.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Username = "";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Username = "";
            Username = Username.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Username = "";
            Username = Username.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Password = "";
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Password = "a";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Password = "aa";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(49, 'a');
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(50, 'a');
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Password = "";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Password = "";
            Password = Password.PadRight(25, 'a');
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Password = "";
            Password = Password.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aa";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
            
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
            
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            Address = Address.PadRight(500, 'a');
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable 
            string DateOfBirth = TestDate.ToString();
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //set the DateOfBirth to a non date value
            string DateOfBirth = "this is not a date!";
            //invoke the method 
            Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
