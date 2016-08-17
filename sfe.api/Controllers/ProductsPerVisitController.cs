using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class ProductsPerVisitController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ProductsPerVisit> Get()
        {
            return bll.ProductsPerVisitLogic.Read();
        }

        // GET api/<controller>
        public IEnumerable<ProductsPerVisit> Get(int visitId)
        {
            return bll.ProductsPerVisitLogic.ReadPerVisit(visitId);
        }

        // GET api/<controller>/5/5
        public ProductsPerVisit Get(int id, int userId)
        {
            return bll.ProductsPerVisitLogic.Read(id, userId);
        }

        // POST api/<controller>
        public void Post(ProductsPerVisit productPerVisit)
        {
            bll.ProductsPerVisitLogic.Create(productPerVisit);
        }

        // PUT api/<controller>
        public void Put(ProductsPerVisit productPerVisit)
        {
            bll.ProductsPerVisitLogic.Update(productPerVisit);
        }
    }
}
