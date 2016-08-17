using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestLogin
    {
        private User user = new User();

        [TestMethod]
        public void TestMethodLogin()
        {
            Assert.IsNotNull(bll.LoginLogic.Read( new LoginData() { username = "test", password = "1234test", country = "Costa Rica" }));
        }
    }
}
