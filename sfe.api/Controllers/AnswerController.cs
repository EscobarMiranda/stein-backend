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
    public class AnswerController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Answer> Get()
        {
            return bll.AnswerLogic.Read();
        }

        // POST api/<controller>
        public void Post(List<Answer> answers)
        {
            bll.AnswerLogic.Create(answers);
        }
    }
}