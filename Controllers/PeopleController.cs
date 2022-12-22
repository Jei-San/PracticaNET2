using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaNET2.Context;
using PracticaNET2.Entities;
using PracticaNET2.Models;

namespace PracticaNET2.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly TestDbContext testDbContext;

        public PeopleController(TestDbContext testDbContext)
        {
            this.testDbContext = testDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            return await testDbContext.People.ToListAsync();
        }

        [HttpPost]
        public async Task<int> Post(PersonDTO personDTO)
        {
            var person = new Person()
            {
                Name = $"{personDTO.FirstName} {personDTO.LastName}",
                Username = personDTO.Username,
                Password = personDTO.Password,
            };

            await testDbContext.People.AddAsync(person);
            await testDbContext.SaveChangesAsync();

            return (await testDbContext.People.Where(x => x.Username == personDTO.Username).FirstOrDefaultAsync()).Id;
        }
    }
}
