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
            clsOrder Anorder = new clsOrder();
            Assert.IsNotNull(Anorder);
        }
    }
        
   

  



}
