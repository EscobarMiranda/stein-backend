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
    public class VisitLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Visit> Read()
        {
            try
            {
                return (from visits in db.Visits
                        select visits).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new VisitListNotFoundException("Visit list not found");
            }
        }

        public static List<Visit> ReadByUser(int userId)
        {
            try
            {
                return (from visits in db.Visits
                        where visits.FK_user == userId
                        select visits).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new VisitListNotFoundException("Visit list not found");
            }
        }

        public static Visit Read(int id)
        {
            try
            {
                return (from visit in db.Visits
                        where visit.idVisit == id
                        select visit).Single();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new VisitNotFoundException("Visit not found");
            }
        }

        public static void Create(Visit visit)
        {
            try
            {
                db.Visits.InsertOnSubmit(visit);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new PostVisitException("Error creating visit");
            }
        }
    }
}
