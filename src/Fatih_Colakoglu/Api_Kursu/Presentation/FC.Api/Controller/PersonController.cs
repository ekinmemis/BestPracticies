using AutoMapper;
using FC.Api.DTOs;
using FC.Api.Filters;
using FC.Core.Models;
using FC.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FC.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IService<Person> _personService;
        private readonly IMapper _mapper;
        public PersonController(IService<Person> personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<PersonDto>>(await _personService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<PersonDto>(await _personService.GetByIdAsync(id)));
        }
        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Insert(PersonDto dto)
        {
            return Created(string.Empty, await _personService.AddAsync(_mapper.Map<Person>(dto)));
        }
        [ValidationFilter]
        [HttpPut]
        public IActionResult Update(PersonDto dto)
        {
            var person = _personService.Update(_mapper.Map<Person>(dto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Remove(_personService.GetByIdAsync(id).Result);
            return NoContent();
        }

    }
}
