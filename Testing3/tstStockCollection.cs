using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace test_Framework
{
    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            // test to see that it exists
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            //create instance of class
            clsStockCollection AllStock = new clsStockCollection();
            // create test data in list of objects
            List<clsStock> TestList = new List<clsStock>();
            // add item to list and create item of test data
            clsStock TestItem = new clsStock();
            // set its properties
            TestItem.Availability = true;
            TestItem.StockNo = 1;
            TestItem.OrderNo = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.StockDescription = "Small";
            TestItem.Quantity = 1;
            // add item to test list
            TestList.Add(TestItem);
            // assign data to stock
            AllStock.StockList = TestList;
            // test to see two values are same
            Assert.AreEqual(AllStock.StockList, TestList);
            {
            }
        }
        [TestMethod]
        public void ThisStockDataOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            // setting properties of test object
            TestStock.Availability = true;
            TestStock.StockNo = 1;
            TestStock.OrderNo = 1;
            TestStock.DatePurchased = DateTime.Now.Date;
            TestStock.StockDescription = "Small";
            TestStock.Quantity = 1;
            // assign data to stock
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Availability = true;
            TestItem.StockNo = 1;
            TestItem.OrderNo = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.StockDescription = "Small";
            TestItem.Quantity = 1;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Availability = true;
            TestItem.StockNo = 1;
            TestItem.OrderNo = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.StockDescription = "Small";
            TestItem.Quantity = 1;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Availability = true;
            TestItem.StockNo = 1;
            TestItem.OrderNo = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.StockDescription = "large";
            TestItem.Quantity = 1;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Availability = true;
            TestItem.StockNo = 1;
            TestItem.OrderNo = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.StockDescription = "small";
            TestItem.Quantity = 1;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            //modity test data
            TestItem.Availability = false;
            TestItem.StockNo = 3;
            TestItem.OrderNo = 3;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.StockDescription = "large";
            TestItem.Quantity = 3;
            //set record based on new test data
            AllStock.ThisStock = TestItem;
            //update record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void ReportByStockDescriptionMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByStockDescription("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByStockDescriptionNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByStockDescription("xxxx");
            Assert.AreEqual(0, FilteredStock.Count);

        }
        [TestMethod]
        public void ReportByStockDescriptionTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByStockDescription("yyy yyy");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].StockNo != 1)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].StockNo != 21)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
            }
        }
}
        
    

          
    
        
        

    
    

