using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AdventureWorks.Models;
using AdventureWorks.Services;
using AdventureWorks.Services.Impl;

namespace AdventureWorks.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsService _service;
        
        public PersonsController(IPersonsService service)
        {
            _service = service;
        }
        
        // GET api/persons/load
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Person>> Load()
        {
            var persons = new List<Person>();
            
            try
            {
                persons = _service.Load();
                if (persons.Count > 0 ) return Ok(persons);
                else return NotFound("No records returned");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
            
        }
        
        // GET api/persons/loadbyfirstname/{fname}
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<PersonByFirstName>> LoadByFirstName(string fname)
        {
            var PersonsByFirstName = new List<PersonByFirstName>();
            
            try
            {
                PersonsByFirstName = (List<PersonByFirstName>)_service.LoadByFirstName(fname);
                if (PersonsByFirstName.Count > 0) return Ok(PersonsByFirstName);
                else return NotFound("No records returned with the query: " + fname + ".");
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        // GET api/persons/loadone/{id}
        [HttpGet("{id}")]
        public ActionResult<Person> LoadOne(int id)
        {
            var Person = new Person();
            
            try
            {
                Person = (Person)_service.LoadByID(id);
                if (Person != null) return Ok(Person);
                else return NotFound("No record found with the ID: " + id + ".");
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/persons/countpersons
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<int> CountPersons()
        {
            int PersonsCount;
            try
            {
                PersonsCount = _service.CountPersons();
                if (PersonsCount > 0) return Ok(PersonsCount);
                else return NotFound("No persons where found, the count is currently 0.");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }


        }

        // POST api/persons/update
        [HttpPost]
        public ActionResult Update([FromBody]string value)
        {
            return Ok();
        }

        // PUT api/persons/add/{id}
        [HttpPut("{id}")]
        public ActionResult Add(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE api/persons/delete/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
