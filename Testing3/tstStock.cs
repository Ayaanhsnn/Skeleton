using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);

        }
        [TestMethod]
        public void StockNoOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 21;
            AStock.StockNo = TestData;
            Assert.AreEqual(AStock.StockNo, TestData);
        }
        [TestMethod]
        public void OrderNoOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 21;
            AStock.OrderNo = TestData;
            Assert.AreEqual(AStock.OrderNo, TestData);
        }

        [TestMethod]
        public void StockDescriptionOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "large";
            AStock.StockDescription = TestData;
            Assert.AreEqual(AStock.StockDescription, TestData);
        }
        public void DatePurchasedOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DatePurchased = TestData;
            Assert.AreEqual(AStock.DatePurchased, TestData);
        }
        [TestMethod]
        public void AvailabilityOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.Availability = TestData;
            Assert.AreEqual(AStock.Availability, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 6;
            AStock.Quantity = TestData;
            Assert.AreEqual(AStock.Quantity, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 StockNo = 6;
            Found = AStock.Find(StockNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNoFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 6;
            Found = AStock.Find(StockNo);
            if (AStock.StockNo != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 6;
            Found = AStock.Find(StockNo);
            if (AStock.OrderNo != 8)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockDescriptionFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 6;
            Found = AStock.Find(StockNo);
            if (AStock.StockDescription != "Small")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        { 
            clsStock AStock = new clsStock();
        Boolean Found = false;
        Boolean OK = true;
        Int32 StockNo = 6;
        Found = AStock.Find(StockNo);
            if (AStock.Quantity != 7)

            {
                OK = false;
                        
            }
    Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDatePurchasedFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 6;
            Found = AStock.Find(StockNo);
            if (AStock.DatePurchased != Convert.ToDateTime("08/06/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailabilityFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 6;
            Found = AStock.Find(StockNo);
            if (AStock.Availability != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
    }
}