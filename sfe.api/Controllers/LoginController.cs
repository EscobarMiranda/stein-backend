using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class LoginController : ApiController
    {
        // POST api/<controller>
        public User Post(LoginData loginObject)
        {
            return bll.LoginLogic.Read(loginObject);
        }
    }
}
