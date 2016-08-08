using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sfe.test
{
    [TestClass]
    public class UnitTestReaction
    {
        [TestMethod]
        public void TestMethodGetReactionList()
        {
            Assert.IsTrue(bll.ReactionLogin.Get().Count > 0);
        }
    }
}
