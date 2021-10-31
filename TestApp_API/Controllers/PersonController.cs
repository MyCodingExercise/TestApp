using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestApp_Core.Entities;
using TestApp_Core.Intefaces;

namespace TestApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repo;

        public PersonController(IPersonRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public string Get() {
            return "TestApp_API";
        }

        [HttpPost]
        public async Task<IActionResult> Post(Person person)
        {
            await _repo.SavePersonAsync(person);
            return Ok();
        }

    }
}
