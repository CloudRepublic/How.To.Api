using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CLR.How.To.Tree.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DragonController : ControllerBase
    {
        // GET: api/<DragonController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DragonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DragonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DragonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DragonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
