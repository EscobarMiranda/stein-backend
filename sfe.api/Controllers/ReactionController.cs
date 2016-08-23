using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace sfe.api.Controllers
{
    //TODO: change origin to app url
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReactionController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Reaction> Get()
        {
            return bll.ReactionLogic.Read();
        }
    }
}
