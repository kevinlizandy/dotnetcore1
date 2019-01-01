using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        // [HttpGet("{id:int}")]
        // [HttpGet("{id:int}/{nama?}")]
        [HttpGet("{id}/{nama=kevin}")]
        public ActionResult<string> Get(int id, string nama)
        {
            return $"value {id}, {nama}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        // [HttpPut("{id}")]
        [HttpPut]
        [ActionName("echodata")]
        public Value Put([FromBody] Value vObj)
        {
            return vObj;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
