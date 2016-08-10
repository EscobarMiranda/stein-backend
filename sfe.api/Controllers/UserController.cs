﻿using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfe.api.Controllers
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<User> Get()
        {
            return bll.UserLogic.Get();
        }

        // GET api/<controller>/5
        public User Get(int id)
        {
            return bll.UserLogic.Get(id);
        }

        // POST api/<controller>
        public void Post(User user)
        {
            bll.UserLogic.Post(user);
        }

        // DELETE api/<controller>
        public void Delete(int id)
        {
            bll.UserLogic.Delete(id);
        }
    }
}