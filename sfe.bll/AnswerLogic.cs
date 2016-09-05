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
    public class AnswerLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Answer> Read()
        {
            try
            {
                return (from answers in db.Answers
                        select answers).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new AnswerListNotFoundException("Answer list not found");
            }
        }
        
        public static void Create(List<Answer> answers)
        {
            try
            {
                db.Answers.InsertAllOnSubmit(answers);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new PostAnswersException("Error creating answers");
            }
        }
    }
}
