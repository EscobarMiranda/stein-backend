using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class ClientController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Client> Get()
        {
            return bll.ClientLogic.getClients();
        }

        // GET api/<controller>/5
        public Client Get(int id)
        {
            return bll.ClientLogic.getClient(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}