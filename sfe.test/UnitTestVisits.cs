using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestVisits
    {
        [TestMethod]
        public void TestMethodPostVisit()
        {
            Visit visit = new Visit();
            visit.comment = "test comment";
            visit.date = new DateTime(2016,01,01);
            visit.FK_agent = 1;
            visit.FK_client = 1;
            visit.FK_reaction = 1;
            bll.VisitsLogic.Post(visit);
        }

        [TestMethod]
        public void TestMethodGetVisitList()
        {
            Assert.IsTrue(bll.VisitsLogic.Get().Count > 0);
        }

        [TestMethod]
        public void TestMethodGetVisit()
        {
            Assert.IsNotNull(bll.VisitsLogic.Get(1));
        }
    }
}
