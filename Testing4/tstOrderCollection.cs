using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.ClothesAvailable = true;
            TestItem.OrderNo = 1;
            TestItem.Address = "105 Vancouver Road Leicester";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void ThisOrderDataOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.ClothesAvailable = true;
            TestOrder.OrderNo = 1;
            TestOrder.Address = "105 Vancouver Road Leicester";
            TestOrder.DeliveryDate = DateTime.Now.Date;
            TestOrder.DatePurchased = DateTime.Now.Date;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.ClothesAvailable = true;
            TestItem.OrderNo = 1;
            TestItem.Address = "105 Vancouver Road Leicester";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.ClothesAvailable = true;
            TestItem.OrderNo = 1;
            TestItem.Address = "105 Vancouver Road Leicester";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.DatePurchased = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.ClothesAvailable = true;
            TestItem.OrderNo = 1;
            TestItem.Address = "105 Vancouver Road Leicester";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.DatePurchased = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            TestItem.ClothesAvailable = false;
            TestItem.OrderNo = 3;
            TestItem.Address = "21 Oxford Street Leicester";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.DatePurchased = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.ClothesAvailable = true;
            TestItem.OrderNo = 1;
            TestItem.Address = "105 Vancouver Road Leicester";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.DatePurchased = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByAddressMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredAddress = new clsOrderCollection();
            FilteredAddress.ReportByAddress("");
            Assert.AreEqual(AllOrders.Count, FilteredAddress.Count);
        }
        [TestMethod]
        public void ReportByAddressNoneFound()
        {
            clsOrderCollection FilteredAddress = new clsOrderCollection();
            FilteredAddress.ReportByAddress("108 twinkle Street");
            Assert.AreEqual(0, FilteredAddress.Count);
        }
        [TestMethod]
        public void ReportByAddressTestDataFound()
        {
            clsOrderCollection FilteredAddress = new clsOrderCollection();
            Boolean OK = true;
            FilteredAddress = ReportByAddress(" 89 pink street leicester");
            if (FilteredAddress.Count == 2)
            {
                if (FilteredAddress.OrderList[0].OrderNo != 1)
                {
                    OK = false;
                }
                if (FilteredAddress.OrderList[1].OrderNo != 2)
                {
                    OK = false;
                }
            }
        }

    }
}
