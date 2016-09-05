using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;
using System.Collections.Generic;

namespace sfe.test
{
    [TestClass]
    public class UnitTestAnswer
    {
        [TestMethod]
        public void TestMethodCreateAnswers()
        {
            int quantity = bll.AnswerLogic.Read().Count;
            List<Answer> answers = new List<Answer>() {
                                                        new Answer() { FK_client = 1, FK_option = 1 },
                                                        new Answer() { FK_client = 1, FK_option = 2 }
                                                      };
            bll.AnswerLogic.Create(answers);
            Assert.IsTrue(bll.AnswerLogic.Read().Count > quantity + 1);
        }

        [TestMethod]
        public void TestMethodReadQuestions()
        {
            Assert.IsTrue(bll.AnswerLogic.Read().Count > 0);
        }
    }
}
