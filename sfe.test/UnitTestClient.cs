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

        [TestMethod]
        public void TestMethodGetClient()
        {
            Assert.IsNotNull(bll.ClientLogic.getClient(2));
        }
    }
}
