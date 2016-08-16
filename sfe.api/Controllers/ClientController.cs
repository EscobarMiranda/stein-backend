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
            return bll.ClientLogic.Read();
        }

        // GET api/<controller>/5
        public Client Get(int id)
        {
            return bll.ClientLogic.Read(id);
        }

        // GET api/<controller>/5/5
        public IEnumerable<Client> Get(int clientTypeId, int userId)
        {
            return bll.ClientLogic.Read(clientTypeId, userId);
        }

        // POST api/<controller>
        public void Post(Client client)
        {
            bll.ClientLogic.Create(client);
        }

        // PUT api/<controller>
        public void Put(Client client)
        {
            bll.ClientLogic.Update(client);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            bll.ClientLogic.Delete(id);
        }
    }
}
