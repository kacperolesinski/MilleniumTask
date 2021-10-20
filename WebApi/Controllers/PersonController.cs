using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<PersonDto> persons = _personService.GetAll();
            if(persons.Count().Equals(0))
            {
                return NotFound();
            }
            return Ok(persons);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PersonDto person = _personService.GetById(id);
            if (person is null)
            {
                return NotFound();
            }
            return Ok(person);
        }
        [HttpPost]
        public IActionResult Create(PersonDto person)
        {
            if(string.IsNullOrEmpty(person.Name))
            {
                ModelState.AddModelError("Name", "The name cannot by empty");
                return BadRequest(ModelState);
            }
            PersonDto createdPerson = _personService.Create(person);
            return Created($"api/person/{createdPerson.Id}", createdPerson);
        }
        [HttpPut]
        public IActionResult Update(PersonDto person)
        {
            _personService.Update(person);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            PersonDto person = _personService.GetById(id);
            if (person is null)
            {
                NotFound();
            }
            _personService.Delete(person);
            return NoContent();
        }
    }
}
