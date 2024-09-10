using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace VeniumAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly MyDbContext db;

        public PokemonController(MyDbContext context)
        {
            db = context;
        }

        // GET: api/<TestAPIController>
        [HttpGet]
        public async Task<List<Pokemon>> Get()
        {
            return await db.Pokemon.ToListAsync();
        }

        // GET api/<PersonelController>/5
        [HttpGet("{id}")]
        public async Task<Pokemon> Get(int id)
        {
            var pokemon = await db.Pokemon.FindAsync(id);
            return pokemon;
        }
























        //// GET: api/<PersonelController>
        //[HttpGet]
        //public async Task<List<Personel>> Get()
        //{
        //    return await _context.SalesData.ToListAsync();
        //}

        //// GET api/<PersonelController>/5
        //[HttpGet("{id}")]
        //public async Task<Personel> Get(int id)
        //{
        //    var personel = await _context.SalesData.FindAsync(id);
        //    return personel;
        //}

        //// POST api/<PersonelController>
        //[HttpPost]
        //public async Task<List<Personel>> AddPersonel(Personel newPersonel)
        //{
        //    _context.SalesData.Add(newPersonel);
        //    await _context.SaveChangesAsync();
        //    return await _context.SalesData.ToListAsync();
        //}

        //// PUT api/<PersonelController>/5
        //[HttpPut]
        //public async Task<List<Personel>> UpdatePersonel(Personel request)
        //{
        //    var personel = await _context.SalesData.FindAsync(request.id);
        //    personel.isim = request.isim;
        //    personel.maas = request.maas;
        //    await _context.SaveChangesAsync();
        //    return await _context.SalesData.ToListAsync();
        //}

        //// DELETE api/<PersonelController>/5
        //[HttpDelete("{id}")]
        //public async Task<List<Personel>> DeletePersonel(int id)
        //{
        //    var personel = await _context.SalesData.FindAsync(id);
        //    _context.SalesData.Remove(personel);
        //    await _context.SaveChangesAsync();
        //    return await _context.SalesData.ToListAsync();
        //}
    }
}