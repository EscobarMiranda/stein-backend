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
            return bll.ClientLogic.Get();
        }

        // GET api/<controller>/5
        public Client Get(int id)
        {
            return bll.ClientLogic.Get(id);
        }

        // POST api/<controller>
        public void Post(Client client)
        {
            bll.ClientLogic.Post(client);
        }
    }
}