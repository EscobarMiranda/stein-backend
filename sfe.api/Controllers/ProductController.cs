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
            return bll.ProductLogic.Get();
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            return bll.ProductLogic.Get(id);
        }

        // POST api/<controller>
        public void Post(Product product)
        {
            bll.ProductLogic.Post(product);
        }
    }
}