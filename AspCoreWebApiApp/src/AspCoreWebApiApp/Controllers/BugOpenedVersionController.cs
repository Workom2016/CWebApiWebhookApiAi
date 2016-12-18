using System.Collections.Generic;
using AspCoreWebApiApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspCoreWebApiApp.Controllers
{
    // https://yahoo-weather-demos.herokuapp.com/webhook
    [Route("webhook")]
    public class BugOpenedVersionController : Controller
    {
        [HttpPost]
        public IActionResult Create([FromBody] BugOpenedVersionRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var bugOpenedVersionResponse = new BugOpenedVersionResponse();
            bugOpenedVersionResponse.speech = "Hi you succeeded";
            bugOpenedVersionResponse.displayText = bugOpenedVersionResponse.speech;
            bugOpenedVersionResponse.source = "apiaiBugOpenedVersion";

            return new ObjectResult(bugOpenedVersionResponse);
        }

        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new List<string> { "1", "2", "3" };
        }

        //[HttpGet("{id}", Name = "GetBugOpenedVersion")]
        //public IActionResult GetById(string id)
        //{
        //    var item = id;
        //    if (id == "0")
        //    {
        //        return NotFound();
        //    }
        //    return new ObjectResult(item);
        //}

        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
