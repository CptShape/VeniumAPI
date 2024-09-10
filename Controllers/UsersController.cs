using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace VeniumAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly MyDbContext db;

        public UsersController(MyDbContext context)
        {
            db = context;
        }

        // GET: api/<TestAPIController>
        [HttpGet]
        public async Task<List<Users>> Get()
        {
            return await db.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<List<Users>> AddPersonel(Users newUser)
        {
            db.Users.Add(newUser);
            await db.SaveChangesAsync();
            return await db.Users.ToListAsync();
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