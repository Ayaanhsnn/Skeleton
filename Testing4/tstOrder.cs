using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void ClothesAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.ClothesAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ClothesAvailable, TestData);
        }

        [TestMethod]
        public void DatePurchasedPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DatePurchased = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DatePurchased, TestData);
        }

        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DeliveryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryDate, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }




        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            string TestData = "105 Lincon Street Leicester";
            //assign the data to the property
            AnOrder.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the address no
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Address != "105 Vancouver Road Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePurchasedFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.DatePurchased != Convert.ToDateTime("12/02/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.DeliveryDate != Convert.ToDateTime("15/02/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestClothesAvailableFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.ClothesAvailable != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }


}

        
   

  




