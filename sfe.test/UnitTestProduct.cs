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
            product.active = true;
        }

        [TestMethod]
        public void TestMethodGetProducts()
        {
            Assert.IsTrue(bll.ProductLogic.Read().Count > 0);
        }

        [TestMethod]
        public void TestMethodGetProduct()
        {
            Assert.IsNotNull(bll.ProductLogic.Read(1));
        }

        [TestMethod]
        public void TestMethodPutProduct()
        {
            product.idProduct = 1;
            product.name = "acetaminofenUpdate";
            bll.ProductLogic.Update(product);
        }
    }
}
