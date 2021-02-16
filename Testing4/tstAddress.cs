using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrder Anorder = new clsOrder();
            Assert.IsNotNull(Anorder);
        }
    }
}
