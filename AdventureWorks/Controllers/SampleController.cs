using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        // GET api/sample/load
        [HttpGet]
        public ActionResult<IEnumerable<string>> Load()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/sample/loadone/{id}
        [HttpGet("{id}")]
        public ActionResult<string> LoadOne(int id)
        {
            return "value";
        }

        // POST api/sample/update
        [HttpPost]
        public ActionResult Update([FromBody]string value)
        {
            return Ok();
        }

        // PUT api/sample/add/{id}
        [HttpPut("{id}")]
        public ActionResult Add(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE api/sample/delete/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
