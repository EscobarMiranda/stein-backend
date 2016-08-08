﻿using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace sfe.bll
{
    public class VisitsLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Visit> Get()
        {
            try
            {
                return (from visit in db.Visits
                        select visit).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new Exception(); // TODO: custom exception
            }
        }

        public static Visit Get(int id)
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
                throw new Exception(); // TODO: custom exception
            }
        }

        public static void Post(Visit visit)
        {
            try
            {
                db.Visits.InsertOnSubmit(visit);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new Exception(); // TODO: custom exception
            }
        }
    }
}