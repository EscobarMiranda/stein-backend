using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sfe.dal;
using System.Collections.Generic;

namespace sfe.test
{
    [TestClass]
    public class UnitTestQuestion
    {
        [TestMethod]
        public void TestMethodReadQuestions()
        {
            Assert.IsTrue(bll.QuestionLogic.Read().Count > 0);
        }

        [TestMethod]
        public void TestMethodCreateQuestion()
        {
            Question question = new Question() { question = "Question 1" };
            List<Option> options = new List<Option> { new Option() { description = "option 1" },
                                                      new Option() { description = "option 2" } };
            QuestionOptions qo = new QuestionOptions() { question = question, options = options };
            bll.QuestionLogic.Create(qo);
        }
    }
}
