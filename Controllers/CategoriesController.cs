using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace VeniumAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly MyDbContext db;

        public CategoriesController(MyDbContext context)
        {
            db = context;
        }

        // GET: api/<TestAPIController>
        [HttpGet]
        public async Task<List<Abilities>> Get()
        {
            return await db.Abilities.ToListAsync();
        }

        // GET api/<PersonelController>/5
        [HttpGet("{id}")]
        public async Task<Abilities> Get(int id)
        {
            var ability = await db.Abilities.FindAsync(id);
            return ability;
        }
    }
}