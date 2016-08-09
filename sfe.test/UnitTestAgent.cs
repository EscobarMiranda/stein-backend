using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestAgent
    {
        private Agent agent = new Agent();

        [TestMethod]
        public void TestMethodPostAgent()
        {
            agent.name = "Test";
            agent.lastName = "Test";
            agent.username = "test";
            agent.password = "1234test";
            agent.idGroup = 1;
            agent.creationDate = new DateTime(2016,01,01);
            agent.country = "Costa Rica";
            bll.AgentLogic.Post(agent);
        }

        [TestMethod]
        public void TestMethodGetAgents()
        {
            Assert.IsTrue(bll.AgentLogic.Get().Count > 0);
        }

        [TestMethod]
        public void TestMethodGetAgent()
        {
            Assert.IsNotNull(bll.AgentLogic.Get(1));
        }
    }
}
