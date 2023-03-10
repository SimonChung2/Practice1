using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Practice1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id*100, id * 300 };
        }

        // GET api/values/5
        public string Get()
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
