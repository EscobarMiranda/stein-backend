using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class VisitController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Visit> Get()
        {
            return bll.VisitLogic.Read();
        }

        // GET api/<controller>/5
        public Visit Get(int id)
        {
            return bll.VisitLogic.Read(id);
        }

        // GET api/<controller>/5
        public IEnumerable<Visit> GetByUser(int userId)
        {
            return bll.VisitLogic.ReadByUser(userId);
        }

        // POST api/<controller>
        public void Post(Visit visit)
        {
            bll.VisitLogic.Create(visit);
        }

        // PUT api/<controller>
        public void Put(Visit visit)
        {
            bll.VisitLogic.Update(visit);
        }
    }
}
