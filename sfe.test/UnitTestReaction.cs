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
            Assert.IsTrue(bll.ReactionLogic.Get().Count > 0);
        }
    }
}
