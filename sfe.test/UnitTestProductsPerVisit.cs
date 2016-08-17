using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestProductsPerVisit
    {
        private ProductsPerVisit productsPerVisit = new ProductsPerVisit();

        [TestMethod]
        public void TestMethodPostProductsPerVisit()
        {
            productsPerVisit.FK_visit = 1;
            productsPerVisit.FK_product = 1;
            productsPerVisit.quantity = 10;
            bll.ProductsPerVisitLogic.Create(productsPerVisit);
        }

        [TestMethod]
        public void TestMethodGetProductsPerVisit()
        {
            Assert.IsTrue(bll.ProductsPerVisitLogic.ReadPerVisit(1).Count > 0);
        }

        [TestMethod]
        public void TestMethodGetProductPerVisit()
        {
            Assert.IsNotNull(bll.ProductsPerVisitLogic.Read(1, 1));
        }

        [TestMethod]
        public void TestMethodPutProductsPerVisit()
        {
            productsPerVisit.idProductPerVisit = 1;
            productsPerVisit.quantity = 5;
            bll.ProductsPerVisitLogic.Update(productsPerVisit);
        }

    }
}
