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
        public IEnumerable<Visit> GetByUser(int idUser)
        {
            return bll.VisitLogic.ReadByUser(idUser);
        }

        // GET api/<controller>/5
        public IEnumerable<Visit> GetByClient(int idClient)
        {
            return bll.VisitLogic.ReadByClient(idClient);
        }

        // GET api/<controller>/5/5/5
        public IEnumerable<Frequency> GetFrequencyByUser(int month, int type, int IdUser)
        {
            return bll.VisitLogic.ReadFrequencyByUser(month, type, IdUser);
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
