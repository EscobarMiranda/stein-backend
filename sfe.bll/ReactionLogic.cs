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
    public class ReactionLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };
        public static List<Reaction> Read()
        {
            try
            {
                string json = JsonConvert.SerializeObject(db.Reactions.ToList(), settings);
                List<Reaction> listReactionsTmp = JsonConvert.DeserializeObject<List<Reaction>>(json);
                List<Reaction> listReactions = new List<Reaction>();
                listReactionsTmp.ForEach(reactions => {
                    reactions.Visits = null;
                    listReactions.Add(reactions);
                });
                return listReactions;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ReactionListNotFoundException("Reaction list not found");
            }
        }
    }
}
