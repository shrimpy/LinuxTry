using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPISample45.Controllers
{
    public class ValuesController : ApiController
    {
        // GET /api/values/5
        public string Get(int id)
        {
            return "value";
        }
    }
}