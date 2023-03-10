using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Presentation.WebApi.Controllers;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpresaAdministrador.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitleController : BaseApiController
    {
        // GET: api/<JobTitleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<JobTitleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JobTitleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JobTitleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JobTitleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
