using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        string OrderNo = "8";
        string StockDescription = "Small";
        string DatePurchased = DateTime.Now.Date.ToString();
        string Quantity = "7";


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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 OrderNoTemp;
            OrderNoTemp = 0;
            OrderNoTemp = OrderNoTemp - 1;
            String OrderNo = OrderNoTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 OrderNoTemp;
            OrderNoTemp = 0;
            String OrderNo = OrderNoTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 OrderNoTemp;
            OrderNoTemp = 0;
            OrderNoTemp = OrderNoTemp + 1;
            String OrderNo = OrderNoTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 OrderNoTemp;
            OrderNoTemp = 0;
            OrderNoTemp = OrderNoTemp - 1;
            String OrderNo = OrderNoTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 OrderNoTemp;
            OrderNoTemp = Int32.MaxValue;
            OrderNoTemp = OrderNoTemp - 1;
            String OrderNo = OrderNoTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 OrderNoTemp;
            OrderNoTemp = Int32.MaxValue;
            OrderNoTemp = OrderNoTemp + 1;
            String OrderNo = OrderNoTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        // starting stock description 
        [TestMethod]
        public void StockDescriptionMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockDescriptionMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockDescriptionMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "ss";
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockDescriptionMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(49, 'a');
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockDescriptionMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(50, 'a');
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockDescriptionMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(25, 'a');
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(500, 'a');
            //invoke the method
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");

        }
        // date purchased 
        [TestMethod]
        public void DatePurchasedExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";

            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity); Assert.AreNotEqual(Error, "");
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity); Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity); Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity); Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 QuantityTemp;
            QuantityTemp = 0;
            QuantityTemp = QuantityTemp - 1;
            String Quantity = QuantityTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 QuantityTemp;
            QuantityTemp = 0;
            String Quantity = QuantityTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 QuantityTemp;
            QuantityTemp = 0;
            QuantityTemp = QuantityTemp + 1;
            String Quantity = QuantityTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 QuantityTemp;
            QuantityTemp = 0;
            QuantityTemp = QuantityTemp - 1;
            String OrderNo = QuantityTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 QuantityTemp;
            QuantityTemp = Int32.MaxValue;
            QuantityTemp = QuantityTemp - 1;
            String Quantity = QuantityTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Int32 QuantityTemp;
            QuantityTemp = Int32.MaxValue;
            QuantityTemp = QuantityTemp + 1;
            String Quantity = QuantityTemp.ToString();
            Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
            Assert.AreEqual(Error, "");



























        }
    }
    }