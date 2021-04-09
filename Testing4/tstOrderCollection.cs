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
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();
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
            ClsOrder TestOrder = new ClsOrder();
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
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();
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
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            ClsOrder TestItem = new ClsOrder();
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


    }
}
