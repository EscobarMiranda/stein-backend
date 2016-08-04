using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sfe.test
{
    [TestClass]
    public class UnitTestClient
    {
        [TestMethod]
        public void TestMethodGetClients()
        {
            Assert.IsTrue(bll.ClientLogic.getClients().Count > 0);
        }
    }
}
