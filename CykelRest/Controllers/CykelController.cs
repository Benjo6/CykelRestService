using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cykel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CykelRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cykel1Controller : ControllerBase
    {
        //DATA
        private static List<Cykel1> _data = new List<Cykel1>()
        {
            new Cykel1("Blå", 10, 10, 1),
            new Cykel1("Rød", 11, 11, 2),
            new Cykel1("Gul", 12, 12, 3),

        };
        // GET: api/<Cykel1sController>
        [HttpGet]
        public IEnumerable<Cykel1> Get()
        {
            return _data;
        }
        // GET api/<Cykel1sController>/5
        [HttpGet("{id}")]
        public Cykel1 Get(int id)
        {
            return _data.Find(p => p.Id == id);
        }

        // POST api/<Cykel1sController>
        [HttpPost]
        public void Post([FromBody] Cykel1 value)
        {
            _data.Add(value);
        }

        // PUT api/<Cykel1sController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cykel1 value)
        {
            Cykel1 Cykel1 = Get(id);
            if (Cykel1 != null)
            {
                Cykel1.Id = value.Id;
                Cykel1.Farve = value.Farve;
                Cykel1.Gear = value.Gear;
                Cykel1.Pris = value.Pris;
            }
        }

        // DELETE api/<Cykel1sController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Cykel1 Cykel1 = Get(id);
            if (Cykel1 != null)
            {
                _data.Remove(Cykel1);
            }
        }
    }
}
