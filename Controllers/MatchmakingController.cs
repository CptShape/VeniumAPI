using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace VeniumAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchmakingController : ControllerBase
    {
        private readonly MyDbContext db;

        public MatchmakingController(MyDbContext context)
        {
            db = context;
        }

        // GET: api/<TestAPIController>
        [HttpGet]
        public async Task<List<Matchmaking>> Get()
        {
            return await db.Matchmaking.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Matchmaking> Get(int id)
        {
            return await db.Matchmaking.FindAsync(id);
        }

        [HttpPost]
        public async Task<List<Matchmaking>> AddPersonel(Matchmaking newUser)
        {
            db.Matchmaking.Add(newUser);
            await db.SaveChangesAsync();
            return await db.Matchmaking.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersonel(int id, Matchmaking newData)
        {
            var match = await db.Matchmaking.FindAsync(id);

            if (match == null)
            {
                return NotFound(); // Eðer match bulunamazsa 404 döner
            }

            match.User1Id = newData.User1Id;
            match.User2Id = newData.User2Id;
            match.User1HP = newData.User1HP;
            match.User2HP = newData.User2HP;

            try
            {
                await db.SaveChangesAsync();
                return Ok(match); // Güncellenmiþ match objesi döner
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message }); // Hata durumunda 400 döner
            }
        }

        [HttpDelete("{id}")]
        public async Task<List<Matchmaking>> DeletePersonel(int id)
        {
            var match = await db.Matchmaking.FindAsync(id);
            db.Matchmaking.Remove(match);
            await db.SaveChangesAsync();
            return await db.Matchmaking.ToListAsync();
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