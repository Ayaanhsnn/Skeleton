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
            Int32 TestData = 1;
            AStock.StockNo = TestData;
            Assert.AreEqual(AStock.StockNo, TestData);
        }
        [TestMethod]
        public void OrderNoOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.OrderNo = TestData;
            Assert.AreEqual(AStock.OrderNo, TestData);
        }

        [TestMethod]
        public void StockDescriptionOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "large";
            AStock.StockDesc = TestData;
            Assert.AreEqual(AStock.StockDesc, TestData);
        }
        public void DatePurchasedOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DatePurch = TestData;
            Assert.AreEqual(AStock.DatePurch, TestData);
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
            Int32 TestData = 1;
            AStock.Quantity = TestData;
            Assert.AreEqual(AStock.Quantity, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 StockNo = 1;
            Found = AStock.Find(StockNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNoFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 21;
            Found = AStock.Find(StockNo);
            if (AStock.StockNo != 21)
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
            Int32 OrderNo = 21;
            Found = AStock.Find(OrderNo);
            if (AStock.OrderNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockDescFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 18;
            Found = AStock.Find(StockNo);
            if (AStock.StockDesc != "small")
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
            Int32 Quantity = 21;
            Found = AStock.Find(Quantity);
            if (AStock.Quantity != 21)
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
            Int32 StockNo = 21;
            Found = AStock.Find(StockNo);
            if (AStock.DatePurch != Convert.ToDateTime("11/09/2020"))
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
            Int32 StockNo = 21;
            Found = AStock.Find(StockNo);
            if (AStock.Availability != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
    }
}