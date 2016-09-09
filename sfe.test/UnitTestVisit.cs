using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;

namespace sfe.test
{
    [TestClass]
    public class UnitTestVisit
    {
        [TestMethod]
        public void TestMethodPostVisit()
        {
            Visit visit = new Visit();
            visit.comment = "test comment";
            visit.date = new DateTime(2016,01,01);
            visit.FK_client = 1;
            visit.FK_reaction = 1;
            bll.VisitLogic.Create(visit);
        }

        [TestMethod]
        public void TestMethodGetVisitList()
        {
            Assert.IsTrue(bll.VisitLogic.Read().Count > 0);
        }

        [TestMethod]
        public void TestMethodGetVisit()
        {
            Assert.IsNotNull(bll.VisitLogic.Read(1));
        }

        [TestMethod]
        public void TestMethodGetFrequency()
        {
            Assert.IsNotNull(bll.VisitLogic.ReadFrequencyByUser(9, 1, 1));
        }

        [TestMethod]
        public void TestMethodGetVisitByUser()
        {
            Assert.IsTrue(bll.VisitLogic.ReadByUser(1).Count > 0);
        }

        [TestMethod]
        public void TestMethodGetVisitByClient()
        {
            Assert.IsTrue(bll.VisitLogic.ReadByClient(1).Count > 0);
        }

        [TestMethod]
        public void TestMethodPutVisit()
        {
            Visit visit = new Visit();
            visit.idVisit = 1;
            visit.comment = "test comment update";
            visit.FK_reaction = 2;
            bll.VisitLogic.Update(visit);
        }
    }
}
