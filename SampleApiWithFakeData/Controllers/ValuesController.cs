using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleApiWithFakeData.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static IEnumerable<int> _numbers = Enumerable.Range(1, 30000);
        // GET api/values
        [HttpGet]
        public IEnumerable<int> Get(int pageIndex, int pageSize)
        {                      
            var filtered = _numbers
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize);

            return filtered;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
