using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class AgentController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Agent> Get()
        {
            return bll.AgentLogic.Get();
        }

        // GET api/<controller>/5
        public Agent Get(int id)
        {
            return bll.AgentLogic.Get(id);
        }

        // POST api/<controller>
        public void Post(Agent client)
        {
            bll.AgentLogic.Post(client);
        }
    }
}