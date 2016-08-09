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
    public class AgentLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Agent> Get()
        {
            try
            {
                return (from agents in db.Agents
                        where agents.active == true
                        select agents).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new AgentListNotFoundException("Agent list not found");
            }
        }

        public static Agent Get(int id)
        {
            try
            {
                return (from agent in db.Agents
                        where agent.idAgent == id
                        select agent).Single();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new AgentNotFoundException("Agent not found");
            }
        }

        public static void Post(Agent agent)
        {
            try
            {
                db.Agents.InsertOnSubmit(agent);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new PostAgentException("Error creating agent");
            }
        }

        public static void Delete(int id)
        {
            try
            {
                Agent tmpAgent = Get(id);
                tmpAgent.active = false;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new DeleteAgentException("Error deleting agent");
            }
        }
    }
}