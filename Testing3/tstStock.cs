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


    }
}
