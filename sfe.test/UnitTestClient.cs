using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestClient
    {
        private Client client = new Client();

        [TestMethod]
        public void TestMethodPostClient()
        {
            client.name = "test";
            client.lastName = "test";
            client.country = "Costa Rica";
            client.email = "test@test.com";
            client.active = true;
            client.FK_clientType = 1;
            client.FK_user = 2;
            client.maxNumVisits = 2;
            client.FK_adoption = 1;
            client.FK_potential = 1;
            client.creationDate = new System.DateTime(2016,01,01);
            bll.ClientLogic.Create(client);
        }

        [TestMethod]
        public void TestMethodGetClients()
        {
            Assert.IsTrue(bll.ClientLogic.Read().Count > 0);
        }

        [TestMethod]
        public void TestMethodGetClient()
        {
            Assert.IsNotNull(bll.ClientLogic.Read(1));
        }

        [TestMethod]
        public void TestMethodDeleteClient()
        {
            bll.ClientLogic.Delete(1);
        }

        [TestMethod]
        public void TestMethodPutClient()
        {
            client.idClient = 1;
            client.name = "testUpdate";
            client.lastName = "testUpdate";
            client.country = "Costa Rica";
            client.email = "test@test.com";
            client.FK_clientType = 1;
            client.active = true;
            client.maxNumVisits = 5;
            client.FK_user = 2;
            bll.ClientLogic.Update(client);
        }
    }
}
