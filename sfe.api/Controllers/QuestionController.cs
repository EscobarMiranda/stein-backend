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
    public class QuestionController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Question> Get()
        {
            return bll.QuestionLogic.Read();
        }

        // POST api/<controller>
        public void Post(QuestionOptions questionOptions)
        {
            bll.QuestionLogic.Create(questionOptions);
        }
    }
}