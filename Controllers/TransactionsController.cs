using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace VeniumAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly MyDbContext db;

        public TransactionsController(MyDbContext context)
        {
            db = context;
        }

        // GET: api/<TestAPIController>
        [HttpGet]
        public async Task<List<Elements>> Get()
        {
            return await db.Elements.ToListAsync();
        }

        // GET api/<PersonelController>/5
        [HttpGet("{id}")]
        public async Task<Elements> Get(int id)
        {
            var element = await db.Elements.FindAsync(id);
            return element;
        }
    }
}