using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JourTibourApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JourTibourApi.Controllers
{
    [Route("api/[controller]")]
    public class EditionController : Controller
    {

        private JourTibourContext _context; 
        public EditionController(JourTibourContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Edition> Get()
        {
            return _context.Editions;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Edition Get(int id)
        {
            return _context.Editions.FirstOrDefault(e => e.EditionId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Edition edition)
        {
            _context.Editions.Add(edition);
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
