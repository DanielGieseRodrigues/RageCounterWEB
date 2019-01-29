using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RageCounterWEBModule
{
    [Route("api/[controller]")]
    public class HeroController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            string url = @"https://api.opendota.com/api/heroes/1/matches";
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync(url);
            if(message.IsSuccessStatusCode)
            {
               string hero = await message.Content.ReadAsStringAsync();
            }
            return "penis";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
