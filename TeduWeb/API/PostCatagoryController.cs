using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeduWeb.API
{
    public class PostCatagoryController : ApiController
    {
        // GET: api/PostCatagory
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PostCatagory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PostCatagory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PostCatagory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PostCatagory/5
        public void Delete(int id)
        {
        }
    }
}
