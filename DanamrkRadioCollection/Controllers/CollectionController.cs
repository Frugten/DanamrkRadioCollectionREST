using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DanamrkRadioCollection.Managers;
using DanamrkRadioCollection.Models;

namespace DanamrkRadioCollection.Controllers
{
    [Route("api/[controller]")]
        // the controller is available on ..../api/books
        // [controller] means the name of the controller minus "Controller"
        [ApiController]
        public class CollectionController : ControllerBase
        {
            private readonly CollectionManager _manager = new CollectionManager();

            // GET: api/<BooksController>
            [HttpGet]
            public IEnumerable<Collection> Get()
            {
                return _manager.GetAll();
            }

            // GET api/<BooksController>/5
            [HttpGet("{id}")]
            public Collection Get(int id)
            {
                return _manager.GetById(id);
            }

            // POST api/<BooksController>
            [HttpPost]
            public Collection Post([FromBody] Collection value)
            {
                return _manager.Add(value);
            }

            // PUT api/<BooksController>/5
            [HttpPut("{id}")]
            public Collection Put(int id, [FromBody] Collection value)
            {
                return _manager.Update(id, value);
            }

            // DELETE api/<BooksController>/5
            [HttpDelete("{id}")]
            public Collection Delete(int id)
            {
                return _manager.Delete(id);
            }
        }
    }


