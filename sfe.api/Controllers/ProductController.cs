using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return bll.ProductLogic.Read();
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            return bll.ProductLogic.Read(id);
        }

        // POST api/<controller>
        public void Post(Product product)
        {
            bll.ProductLogic.Create(product);
        }

        // PUT api/<controller>
        public void Put(Product product)
        {
            bll.ProductLogic.Update(product);
        }
    }
}
