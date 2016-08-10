using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestUser
    {
        private User user = new User();

        [TestMethod]
        public void TestMethodPostUser()
        {
            user.name = "Test";
            user.lastName = "Test";
            user.username = "test";
            user.password = "1234test";
            user.creationDate = new DateTime(2016,01,01);
            user.country = "Costa Rica";
            bll.UserLogic.Post(user);
        }

        [TestMethod]
        public void TestMethodGetUsers()
        {
            Assert.IsTrue(bll.UserLogic.Get().Count > 0);
        }

        [TestMethod]
        public void TestMethodGetUser()
        {
            Assert.IsNotNull(bll.UserLogic.Get(1));
        }

        [TestMethod]
        public void TestMethodDeleteUser()
        {
            bll.UserLogic.Delete(1);
        }
    }
}
