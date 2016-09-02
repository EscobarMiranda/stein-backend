using sfe.bll.Exceptions;
using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    public class QuestionLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Question> Read()
        {
            try
            {
                return (from questions in db.Questions where questions.active == true
                        select questions).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new QuestionListNotFoundException("Question list not found");
            }
        }

        public static void Create(QuestionOptions questionOptions)
        {
            try
            {
                db.Questions.InsertOnSubmit(questionOptions.question);
                db.SubmitChanges();
                foreach(Option option in questionOptions.options)
                {
                    option.FK_question = questionOptions.question.idQuestion;
                    db.Options.InsertOnSubmit(option);
                    db.SubmitChanges();
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new PostQuestionOptionsException("Error creating questions and options");
            }
        }
    }
}
