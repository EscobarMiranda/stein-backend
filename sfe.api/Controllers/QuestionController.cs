using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class QuestionController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<QuestionOptions> Get()
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