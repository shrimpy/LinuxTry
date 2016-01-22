using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RunOnLinuxTry2.Controllers
{
    public class ValueController : ApiController
    {
        // GET: api/Value
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Value/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
