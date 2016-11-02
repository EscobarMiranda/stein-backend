using Newtonsoft.Json;
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
        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };
        public static List<Visit> Read()
        {
            try
            {
                //return (from visits in db.Visits
                //        select visits).ToList();

                string json = JsonConvert.SerializeObject(db.Visits.ToList(), settings);
                List<Visit> listVisitsTmp = JsonConvert.DeserializeObject<List<Visit>>(json);
                List<Visit> listVisits = new List<Visit>();
                listVisitsTmp.ForEach(visits => {
                    visits.Client = null;
                    visits.Reaction = null;
                    visits.ProductsPerVisits = null;
                    visits.VisitType = null;
                    listVisits.Add(visits);
                });
                return listVisits;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new VisitListNotFoundException("Visit list not found");
            }
        }

        public static List<Frequency> ReadFrequencyByUser(int month, int type, int IdUser)
        {
            var currentMonth = month;
            List<Frequency> frecuencies = new List<Frequency>();
            try 
            {
                db.Visits.Where(v => v.Client.FK_user == IdUser && v.FK_visitType == type && v.date.Month == currentMonth).GroupBy(v => v.Client).ToList().ForEach
                    (i => frecuencies.Add(new Frequency
                    {
                        idClient = i.Key.idClient,
                        FK_clientType = i.Key.FK_clientType,
                        fullName = i.Key.name + " " +  i.Key.lastName,
                        frequency = i.Count()
                    }));
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new VisitListNotFoundException("Visit list not found");
            }
            return frecuencies;
        }

        public static List<Visit> ReadByUser(int idUser)
        {
            try
            {
                string json = JsonConvert.SerializeObject(db.Visits.Where(v => v.Client.FK_user == idUser).ToList(), settings);
                List<Visit> listVisitsTmp = JsonConvert.DeserializeObject<List<Visit>>(json);
                List<Visit> listVisits = new List<Visit>();
                listVisitsTmp.ForEach(visits => {
                    visits.Client = null;
                    visits.Reaction = null;
                    visits.ProductsPerVisits = null;
                    visits.VisitType = null;
                    listVisits.Add(visits);
                });
                return listVisits;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new VisitListNotFoundException("Visit list not found");
            }
        }

        public static List<Visit> ReadByClient(int idClient)
        {
            try
            {
                return (from visits in db.Visits
                        where visits.FK_client == idClient
                        select visits).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new VisitListNotFoundException("Visit list not founed");
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
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
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
                EventLog.WriteEntry("sfe", e.Message, EventLogEntryType.Error);
                EventLog.WriteEntry("sfe", e.StackTrace, EventLogEntryType.Information);
                throw new PostVisitException("Error creating visit");
            }
        }

        public static void Update(Visit visit)
        {
            try
            {
                Visit tmpVisit = Read(visit.idVisit);
                tmpVisit.FK_reaction = visit.FK_reaction;
                tmpVisit.comment = visit.comment;
                tmpVisit.latitude = visit.latitude;
                tmpVisit.longitude = visit.longitude;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UpdateVisitException("Error updating visit");
            }
        }
    }
}
