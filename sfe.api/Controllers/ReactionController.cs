using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class ReactionController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Reaction> Get()
        {
            return bll.ReactionLogic.Read();
        }
    }
}