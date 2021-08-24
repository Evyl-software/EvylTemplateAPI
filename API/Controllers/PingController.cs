using API.Controllers;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Template.API.Controllers
{
    public class PingController : BaseApiController
    {

        private readonly ILogger<PingController> _logger;
        private readonly IMongoRepository<Person> _peopleRepository;

        public PingController(ILogger<PingController> logger, IMongoRepository<Person> peopleRepository)
        {
            _logger = logger;
            _peopleRepository = peopleRepository;
        }

        [HttpPost("registerPerson")]
        public async Task AddPerson(string firstName, string lastName)
        {
            var person = new Person()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            await _peopleRepository.InsertOneAsync(person);
        }

        [HttpGet("getPeopleData")]
        public IEnumerable<string> GetPeopleData()
        {
            var people = _peopleRepository.FilterBy(
                filter => filter.FirstName != "test",
                projection => projection.FirstName
            );
            return people;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Ponged you!");
            return Ok("Pong");
        }
    }
}
