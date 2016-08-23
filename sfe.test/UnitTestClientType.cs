using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sfe.test
{
    [TestClass]
    public class UnitTestClientType
    {
        [TestMethod]
        public void TestMethodGetClientTypes()
        {
            Assert.IsTrue(bll.ClientTypesLogic.Read().Count > 0);
        }
    }
}
