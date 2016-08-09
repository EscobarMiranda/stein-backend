using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestProduct
    {
        private Product product = new Product();

        [TestMethod]
        public void TestMethodPostProduct()
        {
            product.name = "acetaminofen";
            product.FK_salesBook = 1;
            product.active = true;
        }

        [TestMethod]
        public void TestMethodGetProducts()
        {
            Assert.IsTrue(bll.ProductLogic.Get().Count > 0);
        }

        [TestMethod]
        public void TestMethodGetProduct()
        {
            Assert.IsNotNull(bll.ProductLogic.Get(1));
        }
    }
}
