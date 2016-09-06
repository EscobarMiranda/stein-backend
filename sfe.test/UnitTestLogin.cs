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
             
            Assert.IsNotNull(bll.LoginLogic.Read( new LoginData() { username = "jperez", password = "Pernix123.", country = "Costa Rica" }));
        }

        [TestMethod]
        public void TestMethodChangePassword()
        {
            bll.LoginLogic.ChangePassword(new ChangePasswordData() { username = "jperez", password = "Pernix123.", newPassword = "123.Pernix" });
            Assert.IsNotNull(bll.LoginLogic.Read(new LoginData() { username = "jperez", password = "123.Pernix", country = "Costa Rica" }));
        }
    }
}
