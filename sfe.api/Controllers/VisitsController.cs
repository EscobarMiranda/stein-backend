using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class VisitsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Visit> Get()
        {
            return bll.VisitsLogic.Get();
        }

        // GET api/<controller>/5
        public Visit Get(int id)
        {
            return bll.VisitsLogic.Get(id);
        }

        // POST api/<controller>
        public void Post(Visit visit)
        {
            bll.VisitsLogic.Post(visit);
        }
    }
}